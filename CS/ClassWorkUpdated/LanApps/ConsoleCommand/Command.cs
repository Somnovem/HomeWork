using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCommand
{

    [Serializable]
    public class Command
    {
        public CommandType Type { get; set; }
        public object Content { get; set; }
        public Command(CommandType type, object content)
        {
            Type = type;
            Content = content;
        }
    }

    public enum CommandType
    {
        date,
        time,
        datetime,
        exec,
        sort,
        numcurthreads,
        cpuusage,
        numcores,
        help,
        exit
    }
}
