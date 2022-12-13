using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi.CustomException
{
    internal class ResultCannotBeNegativeException : Exception
    {
        public ResultCannotBeNegativeException(string message) : base(message) { }
    }
}
