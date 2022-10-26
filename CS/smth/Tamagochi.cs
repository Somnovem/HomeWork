using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;




class Tamagochi
{
    public int Health { get; private set; } = 4;
    public void LowerHealth()
    {
        Health--;
    }
    public void ResetHealth()
    {
        Health = 4;
    }
    public void RequestFood()
    {
        DialogResult d = MessageBox.Show("Tamagochi wants to eat. Do you feed it?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (d == DialogResult.No)
        {
            LowerHealth();
        }
    }
    public void RequestPlay()
    {
        DialogResult d = MessageBox.Show("Tamagochi wants to play. Will you play with it?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (d == DialogResult.No)
        {
            LowerHealth();
        }
    }
    public void RequestSleep()
    {
        DialogResult d = MessageBox.Show("Tamagochi wants to sleep. Do you tuck it in?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (d == DialogResult.No)
        {
            LowerHealth();
        }
    }
    public void RequestGoOut()
    {
        DialogResult d = MessageBox.Show("Tamagochi wants to go outside with you. Will you go with it?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (d == DialogResult.No)
        {
            LowerHealth();
        }
    }
    public void Heal()
    {
        DialogResult d = MessageBox.Show("Tamagochi is feeling ill. Will you heal it?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (d == DialogResult.Yes)
        {
            ResetHealth();
        }
        else
        {
            LowerHealth();
        }
    }
    public void Die()
    {
        MessageBox.Show("Tamagochi died. Press F to pay respect.", "Tamagochi Life", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public void ShowState()
    {
        Console.SetCursorPosition(5, 3);
        if (Health == 4)
        {
            Console.WriteLine("(^O^)");
        }
        else if (Health == 3)
        {
            Console.WriteLine("ʕ•ᴥ•ʔ");
        }
        else if (Health == 2)
        {
            Console.WriteLine("(@_@)");
        }
        else if (Health == 1)
        {
            Console.WriteLine("ಠ_ಠ");
        }
        else
        {
            Console.WriteLine("¯\\(°_o)/¯");
        }
    }
}



static class Globals
{
    public static System.Timers.Timer lifeSpan = new System.Timers.Timer();
    public static System.Timers.Timer actionTimer = new System.Timers.Timer();
    public static Stack<Action> previousActions = new Stack<Action>();
    public static Tamagochi tamagochi = new Tamagochi();
    public static List<Action> ActionList = new List<Action> { Globals.tamagochi.ShowState,Globals.tamagochi.Die,Globals.tamagochi.Heal,Globals.tamagochi.RequestFood, Globals.tamagochi.RequestSleep, Globals.tamagochi.RequestGoOut, Globals.tamagochi.RequestPlay };
    static Globals()
    {
        lifeSpan.Interval = 120000;
        actionTimer.Interval = 15000;
        Globals.lifeSpan.Elapsed += (sender, e) => smth.TamagochiController.LifeSpan_Tick(sender, e, Globals.tamagochi.Die);
        Globals.actionTimer.Elapsed += (sender, e) => smth.TamagochiController.ElapsedAction(sender, e, Globals.ActionList, Globals.previousActions, Globals.tamagochi.Health);
        Globals.lifeSpan.Start();
        Globals.actionTimer.Start();
    }
}



namespace smth
{
    internal class TamagochiController
    {
        static public void Reset()
        {
            Console.Clear();
            Globals.lifeSpan.Close();
            Globals.actionTimer.Close();
            DialogResult d = MessageBox.Show("Do you want to restart the game?", "Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Globals.tamagochi.ResetHealth();
                Globals.previousActions.Clear();
                Globals.lifeSpan.Start();
                Globals.actionTimer.Start();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void Programm(string[] args)
        {
            if (Globals.lifeSpan.Enabled)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetWindowSize(17, 8);
                Console.Clear();
                Globals.tamagochi.ShowState();
            }
            Console.ReadKey();
            RandomNumberAnalyzer.Work();
            //ExtensionMethod.Tests();
            //if (Globals.lifeSpan.Enabled)
            //{
            //    Console.OutputEncoding = System.Text.Encoding.Unicode;
            //    Console.InputEncoding = System.Text.Encoding.Unicode;
            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.SetWindowSize(17, 8);
            //    Console.Clear();
            //    Globals.tamagochi.ShowState();
            //}
            //Console.ReadKey();
        }
        static public void ElapsedAction(object sender, ElapsedEventArgs e, List<Action> actions, Stack<Action> previous, int Health)
        {
            Console.Clear();
            actions[0].Invoke();//showint the state of tamagochi
            if (Health == 1) //checking if it needs healing
            {
                actions[2].Invoke();
            }
            else if (Health == 0) //checking if it is dead
            {
                actions[1].Invoke();
                Reset();
            }
            else//every other action without continious repeating
            {
                while (true)
                {
                    var temp = actions[new Random().Next(3, actions.Count)];
                    if (previous.Count == 0 || previous.Peek() != temp)
                    {
                        previous.Push(temp);
                        temp.Invoke();
                        break;
                    }
                }

            }
        }
        static public void LifeSpan_Tick(object sender, EventArgs e, Action action)
        {
            action.Invoke();//making tamagochi die
            Reset();
        }
    }

}
