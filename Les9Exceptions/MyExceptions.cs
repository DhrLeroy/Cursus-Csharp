using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9Exceptions
{
    public class NoCapsException : Exception
    {

        public NoCapsException(string ding) : base($"{ding} bevat geen hoofdletter.") {
        }
    }
    public class NoLowerCaseException : Exception
    {

        public NoLowerCaseException(string ding) : base($"{ding} bevat geen kleine letters.")
        {
        }
    }
}
