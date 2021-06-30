using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Source
    {
        //It has a static attribut of itself
        static Source source;
        //a private constructor that has no parameter
        private Source()
        {

        }
        //a static method which returns the attribut
        public static Source GetSourceInstance()
        {
            if (source == null)
            {
                source = new();
            }
            return source;
        }
    }
}
