using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDDCursusLibrary
{
    public static class Statistiek
    {
        //static method
        public static decimal Gemiddelde(decimal[] getallen)
        {
            //throw new NotImplementedException();
            if (getallen == null)
            {
                throw new ArgumentNullException();
            }
            if (getallen.Length == 0)
            {
                throw new ArgumentException();
            }
            return getallen.Average();
        }
    }
}
