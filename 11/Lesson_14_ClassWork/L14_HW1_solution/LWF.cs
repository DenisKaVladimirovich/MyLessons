using System;
using System.Collections.Generic;
using System.Text;

namespace L14_HW1_solution
{
    public class LWF
    {
        private static LWF _lwf;

        private LWF() { }


        public static LWF GetInstance()
        {
            if (_lwf == null)
                _lwf = new LWF();
            return _lwf;
        }


        public ILogWriter GetWriter<T>(params ILogWriter[] writers) where T: ILogWriter, new()
        {
            if (writers != null)
            {
                foreach(ILogWriter writer in writers)
                {
                    MultipleLogWriter.LogWriters.Add(writer);
                }
                
            }


            return new T();

        }
    }
}
