using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndoParcialCOnsole_App
{
    class Exception : SystemException
    {


        public Exception(string mensaje) : base(mensaje)
        {

        }

        Exception(string mensaje, Exception innerE) : base(mensaje, innerE)
        {

        }
    }
}
