using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Final.AuthUser;
using static Final.Deposit;

namespace Final
{
    public class Loan : IComparable<Loan>, IComparer<Loan>
    {

        #region PrivateVars
        private PhysicalPerson user;
        private Guid identificator;
        private DateTime openDate;
        private decimal loanAmount;
        private Currency currency;
        private decimal loanPercent;
        private decimal loanRoot;
        private DateTime dueDate;
        private Office of;
        #endregion

        #region Contructor
        public Loan(Guid ident, decimal amount, decimal percent, Currency cur, decimal root, DateTime due, Office o)
        {
            identificator = ident;
            loanAmount = amount;
            loanPercent = percent;
            currency = cur;
            loanRoot = root;
            dueDate = due;
            of = o;
        }
        public Loan(PhysicalPerson person, DateTime open, decimal amount, Currency cur, decimal percent, decimal root, DateTime due)
        {
            user = person;
            openDate = open;
            loanAmount = amount;
            currency = cur;
            loanPercent = percent;
            loanRoot = root;
            dueDate = due;
        }
        #endregion

        #region Methods
        public void OpenLoanByID()
        {
            XDocument xdoc = XDocument.Load("loans.xml");
            XElement loan =
               new XElement("loan",
                    new XElement("userGuid", identificator.ToString()),
                    new XElement("openDate", DateTime.Now),
                    new XElement("loanAmount", new XAttribute("currency", currency), loanAmount),
                    new XElement("loanPercent", loanPercent),
                    new XElement("loanRoot", loanRoot),
                    new XElement("loanDueDate", dueDate),
                    new XElement("office", of)
            );

            xdoc.Root.Add(loan);
            xdoc.Save("loans.xml");
        }
        #endregion

        #region InterfaceImplementation
        public int Compare(Loan x, Loan y)
        {
            return DateTime.Compare(x.dueDate, y.dueDate);
        }

        public int CompareTo(Loan obj)
        {
            if (dueDate == obj.dueDate) return 0;
            if (dueDate < obj.dueDate) return -1;
            return 1;

        }
        #endregion

    }
}
