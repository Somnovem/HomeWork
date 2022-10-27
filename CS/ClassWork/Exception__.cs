using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{

    [Serializable]
    public class MyException : ApplicationException
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    class GarbageGenereation: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposed");
            GC.SuppressFinalize(this);
        }

        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                PV111_CSharp.Student student = new PV111_CSharp.Student();
            }
        }
    }
}
