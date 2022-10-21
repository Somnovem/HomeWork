using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK8;
namespace ConsoleApp1
{
    internal class Controller
    {
        static void Main()
        {
            Action action = Delegates.CurrentTime;
            action += Delegates.CurrentDayOfWeek;
            action += Delegates.CurrentDate;
            foreach (Action item in action.GetInvocationList())
            {
                item.Invoke();
            }
        }
    }
}
