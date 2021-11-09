using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  class OldalNemJoException : Exception
  {
    public OldalNemJoException (string message) : base(message)
    {

    }
  }
}
