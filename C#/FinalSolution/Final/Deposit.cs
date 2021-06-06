using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final
{
    public class Deposit : IComparable<Deposit>, IComparer<Deposit>
    {

        #region PrivateVars
        private PhysicalPerson user;
        private Guid identificator;
        private DateTime openDate;
        private decimal depositAmount;
        private decimal depositPercent;
        private Currency currency;
        #endregion

        #region Props
        public PhysicalPerson User { get => user; }
        public DateTime OpenDate { get => openDate; }
        public decimal DepositAmount { get => depositAmount; set { depositAmount = value; } }
        public decimal DepositPercent { get => depositPercent; set { depositPercent = value; } }
        public Currency DepositCurrency { get => currency; set { currency = value; } }
        #endregion

        #region Constructor

        public Deposit(Guid ident, decimal amount, decimal percent, Currency cur)
        {
            identificator = ident;
            depositAmount = amount;
            depositPercent = percent;
            currency = cur;
        }
        public Deposit(PhysicalPerson person, DateTime oDate, decimal amount, decimal percent, Currency cur)
        {
            user = person;
            openDate = oDate;
            depositAmount = amount;
            depositPercent = percent;
            currency = cur;
        }
        #endregion

        #region Methods

        public void OpenDeposit()
        {
            XDocument xdoc = XDocument.Load("deposits.xml");
            XElement deposit =
               new XElement("deposit",
                    new XElement("userGuid", identificator.ToString()),
                    new XElement("openDate", DateTime.Now),
                    new XElement("depositAmount",new XAttribute("currency", currency), depositAmount),
                    new XElement("depositPercent", depositPercent)
            );

            xdoc.Root.Add(deposit);
            xdoc.Save("deposits.xml");
        }
        public int Compare(Deposit x, Deposit y)
        {
            if (x.depositAmount == y.depositAmount) return 0;
            if (x.depositAmount < y.depositAmount) return -1;
            return 1;
        }

        public int CompareTo(Deposit dep)
        {
            if (depositAmount == dep.depositAmount) return 0;
            if (depositAmount < dep.depositAmount) return -1;
            return 1;
        }
        #endregion

        #region Enums
        public enum Currency
        {
            LARI,
            USD,
            EURO,
            YEN
        }
        #endregion

    }
}
