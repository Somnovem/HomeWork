using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Homework5_1Server
{
    internal class Game
    {
        protected static string options = "Rock Paper Scissors";
        public static KeyValuePair<string, string> CompareChoices(string choice1, string choice2)
        {
            string result1 = "";
            string result2 = "";
            switch (choice1)
            {
                case "Rock":
                    if (choice2 == "Rock")
                    {
                        result1 = "Tie";
                        result2 = "Tie";
                    }
                    else if (choice2 == "Paper")
                    {
                        result1 = "Lost";
                        result2 = "Win";
                    }
                    else
                    {
                        result1 = "Win";
                        result2 = "Lost";
                    }
                    break;
                case "Paper":
                    if (choice2 == "Rock")
                    {
                        result1 = "Win";
                        result2 = "Lost";
                    }
                    else if (choice2 == "Paper")
                    {
                        result1 = "Tie";
                        result2 = "Tie";
                    }
                    else
                    {
                        result1 = "Lost";
                        result2 = "Win";
                    }
                    break;
                case "Scissors":
                    if (choice2 == "Rock")
                    {
                        result1 = "Lost";
                        result2 = "Win";
                    }
                    else if (choice2 == "Paper")
                    {
                        result1 = "Win";
                        result2 = "Lost";
                    }
                    else
                    {
                        result1 = "Tie";
                        result2 = "Tie";
                    }
                    break;
            }
            return new KeyValuePair<string, string>(result1, result2);
        }
        protected virtual void Tie() { }
    }

    internal class GameWithPlayer : Game
    {
        private TcpClientConnection player1;
        private TcpClientConnection player2;
        public GameWithPlayer(TcpClientConnection plr1, TcpClientConnection plr2)
        {
            this.player1 = plr1;
            this.player2 = plr2;
        }

        protected override async void Tie()
        {
            await player1.SendString("Tie");
            await player2.SendString("Tie");
        }
        public async void StartGame()
        {
            await player1.SendString("Game started!");
            await player2.SendString("Game started!");
            await player1.SendString(options);
            Thread.Sleep(500);
            await player2.SendString(options);
            for (int i = 0; i < 5; i++)
            {
                string choice1 = await player1.ReceiveString();
                string choice2 = await player2.ReceiveString();
                if ("Tie".Equals(choice1) || "Tie".Equals(choice2))
                {
                    if (choice1.Equals(choice2)) // already agreed on tie
                    {
                        Tie();
                        break;
                    }
                    else
                    {
                        if ("Tie".Equals(choice1)) //Player 1 suggested tie
                        {
                            await player2.SendString("Request to tie");
                            string requestResponse = await player2.ReceiveString();
                            if ("Yes".Equals(requestResponse))
                            {
                                Tie();
                                break;
                            }
                            else
                            {
                                await player1.SendString("Request denied");
                                choice1 = await player1.ReceiveString();
                            }
                        }
                        else //Player 2 suggested tie
                        {
                            await player1.SendString("Request to tie");
                            string requestResponse = await player1.ReceiveString();
                            if ("Yes".Equals(requestResponse))
                            {
                                Tie();
                                break;
                            }
                            else
                            {
                                await player2.SendString("Request denied");
                                choice2 = await player2.ReceiveString();
                            }
                        }
                    }
                }
                else if ("Surrender".Equals(choice1) || "Surrender".Equals(choice2))
                {
                    if (choice1.Equals(choice2)) // both surrendered
                    {
                        Tie();
                    }
                    else if ("Surrender".Equals(choice1)) // first player surrendered
                    {
                        await player1.SendString("Surrender");
                        await player2.SendString("Opponent surrendered");
                    }
                    else // second player surrendered
                    {
                        await player1.SendString("Opponent surrendered");
                        await player2.SendString("Surrender");
                    }
                    break;
                }
                KeyValuePair<string, string> result = Game.CompareChoices(choice1, choice2);
                await player1.SendString($"Opponent chose {choice2}:{result.Key}");
                await player2.SendString($"Opponent chose {choice1}:{result.Value}");
            }


        }
    }
    internal class GameWithComputer : Game
    {
        private TcpClientConnection player;
        protected override async void Tie()
        {
            await player.SendString("Tie");
        }
        public GameWithComputer(TcpClientConnection player)
        {
            this.player = player;
        }
        public async void StartGame()
        {
            await player.SendString("Game started!");
            Thread.Sleep(500);
            await player.SendString(options);
            Random random = new Random();
            string[] optionsArr = options.Split(' ');
            for (int i = 0; i < 5; i++)
            {
                string choice = await player.ReceiveString();
                if ("Tie".Equals(choice))
                {
                    Tie();
                    break;
                }
                else if ("Surrender".Equals(choice))
                {
                    await player.SendString("Surrender");
                    i = 5;
                }
                else
                {
                    string computerChoice = optionsArr[random.Next(0, optionsArr.Length)];
                    KeyValuePair<string, string> result = Game.CompareChoices(choice, computerChoice);
                    Thread.Sleep(1000);
                    await player.SendString($"Opponent chose {computerChoice}:{result.Key}");
                }
            }

        }
    }
}
