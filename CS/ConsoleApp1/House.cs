using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal interface IWorker
    {
        void Work(House house);
    }

    internal class Team
    {

        public List<IWorker> workers = new List<IWorker> { };

        public Team(params IWorker[] InitWorkers)
        {
            if (InitWorkers.Length == 0)
            {
                workers.Add(new Worker());
                workers.Add(new Worker());
                workers.Add(new Worker());
                workers.Add(new Worker());
                workers.Add(new TeamLead());
            }
            else
            {
                foreach (var item in InitWorkers)
                {
                    workers.Add(item);
                }
            }
        
        }
        public House BuildHouse()
        {
        House house = new House();
            bool finished = false;
            Random rand = new Random();
            while (!finished)
            {
            IWorker worker = workers[rand.Next(1,workers.Count)];
                worker.Work(house);
                if (house.parts.Count != 0)
                {
                    if (house.parts.Last() is Roof)
                    {
                        finished = true;
                    }
                }
            }
            return house;
        }

    }
    internal class Worker : IWorker
    {
        public void Work(House house)
        {
            var currentParts = house.GetParts();
            if (!currentParts.ContainsKey("Basement"))
            {
                house.parts.Add(new Basement());
            }
            else if(!currentParts.ContainsKey("Wall") || currentParts["Wall"] < 4)
            {
                house.parts.Add(new Wall());
            }
            else if (!currentParts.ContainsKey("Doors"))
            {
                house.parts.Add(new Doors());
            }
            else if (!currentParts.ContainsKey("Window") || currentParts["Window"] < 4)
            {
                house.parts.Add(new Window());
            }
            else if (!currentParts.ContainsKey("Roof"))
            {
                house.parts.Add(new Roof());
            }
        }
    }

    internal class TeamLead : IWorker
    {
        public void Work(House house)
        {
            var currentParts = house.GetParts();
            if (currentParts.Count == 0)
            {
                return;
            }
            Console.WriteLine("Teamlead inspected and found: ");
            foreach (var item in currentParts)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            decimal maxParts = 11.0M;
            Console.WriteLine("House completion: " + Math.Round((decimal)currentParts.Count * 100 / maxParts,2) + " %");
            Console.WriteLine("--------------------");
        }
    }


    internal interface IPart
    {

    }
    internal class House: IPart
    {
        public List<IPart> parts = new List<IPart> { };
        public Dictionary<string, Int32> GetParts()
        {
        Dictionary<string, Int32> result = new Dictionary<string, Int32>();
            foreach (var item in parts)
            {
                if (!(result.ContainsKey(item.GetType().Name)))
                {
                    result.Add(item.GetType().Name,1); 
                }
                else
                {
                    result[item.GetType().Name]++;
                }
            }
            return result;
        }
    }
    internal class Basement : IPart
    {

    }
    internal class Wall : IPart
    {

    }
    internal class Doors : IPart
    {

    }
    internal class Window : IPart
    {

    }
    internal class Roof : IPart
    {

    }
}
