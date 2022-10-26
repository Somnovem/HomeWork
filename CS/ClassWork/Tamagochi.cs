using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace ClassWork
{ 
   

    internal class TamagochiController
    {
        static public void Reset(Tamagochi tama, System.Timers.Timer lifeTimer, System.Timers.Timer actionTimer, Stack<Action> previous)
        {
            tama = new Tamagochi();
            lifeTimer.Dispose();
            actionTimer.Dispose();
            previous.Clear();
        }
        static void PrintName()
        {
            Console.WriteLine("888                                                888           888     d8b");
            Console.WriteLine("888                                                888           888     Y8P ");
            Console.WriteLine("888                                                888           888         ");
            Console.WriteLine("888888 8888b. 88888b.d88b.  8888b.  .d88b.  .d88b. 888888 .d8888b88888b. 888 ");
            Console.WriteLine("888       \"88b888 \"888 \"88b    \"88bd88P\"88bd88\"\"88b888   d88P\"   888 \"88b888 ");
            Console.WriteLine("888   .d888888888  888  888.d888888888  888888  888888   888     888  888888 ");
            Console.WriteLine("Y88b. 888  888888  888  888888  888Y88b 888Y88..88PY88b. Y88b.   888  888888 ");
            Console.WriteLine("\"Y888\"Y888888888  888  888\"Y888888 \"Y88888 \"Y88P\"  \"Y888 \"Y8888P888  888888 ");
            Console.WriteLine("                                        888                                  ");
            Console.WriteLine("                                   Y8b d88P                                  ");
            Console.WriteLine("                                    \"Y88P\"                                   ");
        }
        static void Programm(string[] args)
        {
            Tamagochi MyTamagochi = new Tamagochi();
            List<Action> ActionList = new List<Action> { MyTamagochi.Die, MyTamagochi.RequestFood, MyTamagochi.RequestSleep, MyTamagochi.RequestGoOut, MyTamagochi.RequestPlay };
            Stack<Action> previousActions = new Stack<Action>();
            System.Timers.Timer LifeSpan = new System.Timers.Timer();
            System.Timers.Timer Action = new System.Timers.Timer();
            LifeSpan.Interval = 120000;
            Action.Interval = 15000;
            Action.Elapsed += (sender, e) => ElapsedAction(sender, e, ActionList, previousActions, MyTamagochi.Health);
            LifeSpan.Elapsed += (sender, e) => LifeSpan_Tick(sender, e, MyTamagochi.Die);
            LifeSpan.Start();
            Action.Start();
            Console.Read();
        }
        static void ElapsedAction(object sender, ElapsedEventArgs e, List<Action> actions, Stack<Action> previous, int Health)
        {
            if (Health == 1)
            {
                actions[1].Invoke();
            }
            else if (Health == 0)
            {
                actions[0].Invoke();
            }
            else
            {
                while (true)
                {
                    var temp = actions[new Random().Next(2,actions.Count)];
                    if (previous.Peek() != temp)
                    {
                        previous.Push(temp);
                        temp.Invoke();
                        break;
                    }
                }
                
            }
        }
        static void LifeSpan_Tick(object sender, EventArgs e, Action action)
        {
            action.Invoke();
        }
    }

    class Tamagochi
    {
        public int Health { get; private set; } = 4;
        void LowerHealth()
        {
            Health--;
        }
        void ResetHealth()
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
            DialogResult d = MessageBox.Show("Tamagochi wants to go out with you. Will you go with it?", "Tamagochi Life", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }

}
