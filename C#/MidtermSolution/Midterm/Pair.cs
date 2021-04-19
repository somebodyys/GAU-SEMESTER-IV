using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertation;

namespace Midterm
{
    public abstract class Pair
    {
     
        #region Props
        public int PairOne { get; set; }
        public int PairTwo { get; set; }
        #endregion

        #region Methods

        public virtual string Info()
            => $"({PairOne}, {PairTwo})";
        #endregion
    }


    public class Money : Pair, IComparable<Money>
    {

        public decimal InUSD { get; set; }
        public decimal InEuro { get; set; }

        public Money(int one, int two)
        {
            PairOne = one;
            PairTwo = two;
            InUSD = MoneyConverter.MoneyConvert(one * 100 + two, "usd");
            InEuro = MoneyConverter.MoneyConvert(one * 100 + two, "eur");
        }

        #region Methods


        public override string Info()
            => $"{PairOne} Lari and {PairTwo} Tetri.";
        #endregion

        #region Overridden
        public int CompareTo(Money obj)
        {
            int totalOne = (this.PairOne * 100) + this.PairTwo;
            int totalTwo = (obj.PairOne * 100) + obj.PairTwo;
            if (totalOne == totalTwo) return 0;
            if (totalOne < totalTwo) return -1;
            return 1;
        }

        public static bool operator >(Money m1, Money m2)
        {
            if (m1.CompareTo(m2) == 1) return true;
            return false;
        }
        public static bool operator <(Money m1, Money m2)
        {
            if (m1.CompareTo(m2) == -1) return true;
            return false;
        }

        public static bool operator >=(Money m1, Money m2)
        {
            int compared = m1.CompareTo(m2);
            if (compared == 1 || compared == 0) return true;
            return false;
        }
        public static bool operator <=(Money m1, Money m2)
        {
            int compared = m1.CompareTo(m2);
            if (compared == -1 || compared == 0) return true;
            return false;
        }
        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.CompareTo(m2) == 0) return true;
            return false;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.CompareTo(m2) != 0) return true;
            return false;
        }

        public static Money operator +(Money m1, Money m2)
            => new Money(m1.PairOne + m2.PairOne, m1.PairTwo + m2.PairTwo);

        public static Money operator -(Money m1, Money m2)
            => new Money(m1.PairOne - m2.PairOne, m1.PairTwo - m2.PairTwo);
        #endregion

    }


    public class ComplexNumber : Pair
    {
        public ComplexNumber(int one, int two)
        {
            PairOne = one;
            PairTwo = two;
        }


        #region Methods
        public override string Info()
        {
            string operation = PairTwo < 0 ? "" : "+";
            return $"{PairOne}{operation}{PairTwo}*i";
        }
        #endregion


        #region Overridden
        public static ComplexNumber operator +(ComplexNumber n1, ComplexNumber n2)
            => new ComplexNumber(n1.PairOne + n2.PairOne, n1.PairTwo + n2.PairTwo);
        public static ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2)
            => new ComplexNumber(n1.PairOne - n2.PairOne, n1.PairTwo - n2.PairTwo);
        #endregion
    }


    public class Series
    {
        private  List<Pair> storage = new List<Pair>();


        #region Constructors
        public Series() { }

        public Series(params Pair[] input)
        {
            foreach (var item in input)
            {
                storage.Add(item);
            }
        }

        #endregion

        public Pair this[int index]
        {
            get => storage[index];
            set => storage[index] = value;
        }
    }
}
