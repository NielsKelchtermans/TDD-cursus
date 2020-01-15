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
