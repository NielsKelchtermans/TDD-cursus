using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TDDCursusLibrary
{
    public class Rekeningnummer
    {
        //Regex met stukje hoe rekeningnummer er moet uitzien
        private static readonly Regex regex = new Regex("^\\d{3}-\\d{7}-\\d{2}$"); //using regularexpressions zie boven
        //constructor
        public Rekeningnummer(string nummer)
        {
            //throw new NotImplementedException();
            if (!regex.IsMatch(nummer))    //regex heeft een IsMatch method
            {
                throw new ArgumentException();
            }
            var eerste10cijfers = long.Parse(nummer.Substring(0, 3) + nummer.Substring(4, 7));
            var laatste2cijfers = long.Parse(nummer.Substring(12, 2));

            if (eerste10cijfers %97L !=laatste2cijfers)
            {
                throw new ArgumentException();
            }
            this.nummer = nummer;
            
        }
        private readonly string nummer;

        //method override
        public override string ToString()
        {
            //throw new NotImplementedException();
            return nummer;
        }
    }
}
