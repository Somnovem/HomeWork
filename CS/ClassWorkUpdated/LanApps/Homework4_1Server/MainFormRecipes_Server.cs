using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using Timer = System.Timers.Timer;
namespace Homework4_1Server
{

    public partial class MainFormRecipes_Server : Form
    {
        private const int portNumber = 8000;
        private UdpClient receiver;
        private List<Recipe> recipes;
        private static string userBannedMessage = "You spent your requsts for this hour, try again later";
        private static string serverOverflownMessage = "Server is overflown, try again later";
        private static string noMatchFoundMessage = "No recipe, containing provided products, was found";
        private int maxUsers;
        private int maxRequestsPerUser;
        private int currentUsers;
        private Dictionary<string, UserStats> recentUsers;
        private Dictionary<string, DateTime> bannedUsers;
        private Timer timeoutTimer;
        public MainFormRecipes_Server()
        {
            InitializeComponent();
            FillRecipes();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbMessages.Items.Clear();
            receiver = new UdpClient(portNumber);
            maxUsers = (int)edMaxClients.Value;
            maxRequestsPerUser = (int)edRequestsPerHour.Value;
            currentUsers = 0;
            recentUsers = new Dictionary<string, UserStats>();
            bannedUsers = new Dictionary<string, DateTime>();
            timeoutTimer = new Timer();
            timeoutTimer.Interval = 10000;
            timeoutTimer.AutoReset = true;
            timeoutTimer.Elapsed += TimeoutTimer_Elapsed;
            timeoutTimer.Start();
            Thread thread = new Thread(ReceiveData);
            thread.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void TimeoutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeoutTimer.Stop();
            var excluding = recentUsers.Where(x => DateTime.Now.Subtract(x.Value.LastRequest).TotalMinutes >= 10).ToArray();
            for (int i = 0; i < excluding.Length; i++)
            {
                recentUsers.Remove(excluding[i].Key);
            }
            timeoutTimer.Start();
        }

        private void FillRecipes()
        {
            recipes = new List<Recipe>();
            using (StreamReader reader = new StreamReader(@"..\..\Recipes.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Recipe recipe = new Recipe();
                    recipe.name = reader.ReadLine();
                    recipe.imagePath = reader.ReadLine();
                    recipe.ingridients = new List<string>();
                    string next = reader.ReadLine();
                    while (!next.StartsWith("---"))
                    {
                        recipe.ingridients.Add(next);
                        next = reader.ReadLine();
                    }
                    recipes.Add(recipe);
                }

            }
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteEndpoint = null;
                    
                    byte[] data = receiver.Receive(ref remoteEndpoint);
                    ClientState wasAllowed = ClientState.Banned;
                    if (currentUsers != maxUsers)
                    {
                        currentUsers++;
                        string address = remoteEndpoint.Address.ToString();
                        if (recentUsers.ContainsKey(address)) //Already registered client
                        {
                            recentUsers[address].RequestsRemaining--;
                            recentUsers[address].LastRequest = DateTime.Now;
                            wasAllowed = ClientState.Allowed;
                            if (recentUsers[address].RequestsRemaining == 0)
                            {
                                recentUsers.Remove(address);
                                bannedUsers.Add(address, DateTime.Now);
                            }
                        }
                        else //Client is banned or new
                        {
                            if (bannedUsers.ContainsKey(address)) //Client is banned
                            {
                                if (DateTime.Now.Subtract(bannedUsers[address]).TotalHours >= 1.0) //Enough time passed to unban the client
                                {
                                    recentUsers.Add(remoteEndpoint.Address.ToString(), new UserStats() { RequestsRemaining = maxRequestsPerUser-1,LastRequest = DateTime.Now});
                                    bannedUsers.Remove(address);
                                    wasAllowed = ClientState.Allowed;
                                }
                            }
                            else //Client is new
                            {
                                recentUsers.Add(remoteEndpoint.Address.ToString(), new UserStats() { RequestsRemaining = maxRequestsPerUser - 1, LastRequest = DateTime.Now });
                                wasAllowed = ClientState.Allowed;
                            }
                        }
                    }
                    else wasAllowed = ClientState.ServerOverflow;
                    Thread thread = new Thread(() => HandleData(data, remoteEndpoint, wasAllowed));
                    thread.Start();
                }
            }
            catch { }
        }

        private void HandleData(byte[] data, IPEndPoint remoteEndpoint, ClientState isAllowed)
        {
            try
            {
                UdpClient client = new UdpClient();
                string initialMessage = Encoding.UTF8.GetString(data);
                string[] parameters = initialMessage.Split(':');
                int portAdressed = int.Parse(parameters[0]);
                IPEndPoint clientEndPoint = new IPEndPoint(remoteEndpoint.Address, portAdressed);
                if (isAllowed == ClientState.Allowed)
                {
                    string[] ingridients = parameters[1].Split(';');
                    Action a = () =>
                    {
                        lbMessages.Items.Insert(0, $"{clientEndPoint.Address}:{clientEndPoint.Port} >> {parameters[1]}");
                    };
                    if (InvokeRequired) Invoke(a);
                    else a();
                    Recipe mostInCommonRecipe = null;
                    int maxCount = 0;
                    for (int i = 0; i < recipes.Count; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < recipes[i].ingridients.Count; j++)
                        {
                            if (ingridients.Contains(recipes[i].ingridients[j])) count++;
                        }
                        if (count > maxCount)
                        {
                            mostInCommonRecipe = recipes[i];
                            maxCount = count;
                        }
                    }
                    if (mostInCommonRecipe == null) 
                    {
                        byte[] noMatchFoundData = Encoding.UTF8.GetBytes(noMatchFoundMessage);
                        client.Send(noMatchFoundData, noMatchFoundData.Length, clientEndPoint);
                        byte[] noMatchImageData = File.ReadAllBytes(@"..\..\Images\nomatch.jpg");
                        int chunksSize = 1024;
                        List<byte[]> imageChunks = new List<byte[]>();
                        for (int i = 0; i < noMatchImageData.Length; i += chunksSize)
                        {
                            int chunkLength = Math.Min(chunksSize, noMatchImageData.Length - i);
                            byte[] chunk = new byte[chunkLength];
                            Array.Copy(noMatchImageData, i, chunk, 0, chunkLength);
                            imageChunks.Add(chunk);
                        }
                        foreach (byte[] chunk in imageChunks)
                        {
                            client.Send(chunk, chunk.Length, clientEndPoint);
                        }
                        return;
                    }
                    string recipe = "";
                    recipe += mostInCommonRecipe.name + '\n';
                    for (int i = 0; i < mostInCommonRecipe.ingridients.Count; i++)
                    {
                        recipe += mostInCommonRecipe.ingridients[i] + '\n';
                    }
                    byte[] sendingData = Encoding.UTF8.GetBytes(recipe);
                    client.Send(sendingData, sendingData.Length, clientEndPoint);
                    byte[] imageData = File.ReadAllBytes(mostInCommonRecipe.imagePath);
                    int chunkSize = 1024;
                    List<byte[]> chunks = new List<byte[]>();
                    for (int i = 0; i < imageData.Length; i += chunkSize)
                    {
                        int chunkLength = Math.Min(chunkSize, imageData.Length - i);
                        byte[] chunk = new byte[chunkLength];
                        Array.Copy(imageData, i, chunk, 0, chunkLength);
                        chunks.Add(chunk);
                    }
                    foreach (byte[] chunk in chunks)
                    {
                        client.Send(chunk, chunk.Length, clientEndPoint);
                    }
                }
                else if (isAllowed == ClientState.Banned)
                {
                    byte[] sendingData = Encoding.UTF8.GetBytes(userBannedMessage);
                    client.Send(sendingData, sendingData.Length, clientEndPoint);
                    byte[] imageData = File.ReadAllBytes(@"..\..\Images\banhammer.jpg");
                    int chunkSize = 1024;
                    List<byte[]> chunks = new List<byte[]>();
                    for (int i = 0; i < imageData.Length; i += chunkSize)
                    {
                        int chunkLength = Math.Min(chunkSize, imageData.Length - i);
                        byte[] chunk = new byte[chunkLength];
                        Array.Copy(imageData, i, chunk, 0, chunkLength);
                        chunks.Add(chunk);
                    }
                    foreach (byte[] chunk in chunks)
                    {
                        client.Send(chunk, chunk.Length, clientEndPoint);
                    }
                }
                else
                {
                    byte[] sendingData = Encoding.UTF8.GetBytes(serverOverflownMessage);
                    client.Send(sendingData, sendingData.Length, clientEndPoint);
                    byte[] imageData = File.ReadAllBytes(@"..\..\Images\overflow.jpg");
                    int chunkSize = 1024;
                    List<byte[]> chunks = new List<byte[]>();
                    for (int i = 0; i < imageData.Length; i += chunkSize)
                    {
                        int chunkLength = Math.Min(chunkSize, imageData.Length - i);
                        byte[] chunk = new byte[chunkLength];
                        Array.Copy(imageData, i, chunk, 0, chunkLength);
                        chunks.Add(chunk);
                    }
                    foreach (byte[] chunk in chunks)
                    {
                        client.Send(chunk, chunk.Length, clientEndPoint);
                    }
                }
                client.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally 
            {
                currentUsers--;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                receiver.Close();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch { }
        }
    }

    public enum ClientState
    { 
    Allowed,
    Banned,
    ServerOverflow
    }
    public class Recipe
    {
        public string name;
        public string imagePath;
        public List<string> ingridients;
    }
}
