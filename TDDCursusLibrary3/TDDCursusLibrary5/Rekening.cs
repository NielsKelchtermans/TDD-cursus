using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldoValue;
        public void Storten(decimal bedrag)
        {
            // throw new NotImplementedException();
            if (bedrag <=0)
            {
                throw new ArgumentException();
            }
            
            Saldo += bedrag;
            
           
        }
        public decimal Saldo
        {
            get
            {
                //throw new NotImplementedException();
                return saldoValue;
            }
            set
            {
                saldoValue = value;
            }
        }
    }
}
