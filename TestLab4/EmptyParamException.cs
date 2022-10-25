using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab4
{
    public class EmptyParamException : Exception
    {
        public override string Message => "Empty parameter";
    }
}
