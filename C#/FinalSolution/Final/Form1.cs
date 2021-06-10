using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Final.AuthUser;
using static Final.Deposit;
using static Final.PhysicalPerson;

namespace Final
{
    public partial class bankForm : Form
    {
        public bankForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeDataGrids();
        }

        private void InitializeDataGrids()
        {
            XDocument xdoc = XDocument.Load("myUsers.xml");
            var list = xdoc.Root.Descendants("user")
                .Select( us => 
                    new { 
                        FirstName = us.Element("fname").Value,
                        LastName = us.Element("lname").Value,
                        UserName = us.Element("username").Value,
                        Office = us.Element("office").Value,
                        Role = us.Element("role").Value,
                        Gender = us.Element("gender").Value,
                        Country = us.Element("country").Value,
                        City = us.Element("city").Value,
                        Phone = us.Element("phone").Value,
                        Email = us.Element("email").Value,
                        Identificator = us.Attribute("identificator").Value
                    })
                .ToList();


            XDocument xdeposit= XDocument.Load("loans.xml");
            var loanList = xdeposit.Root.Descendants("loan")
                .Select(dep =>
                    new
                    {
                        GUID = dep.Element("userGuid").Value,
                        Amount = dep.Element("loanAmount").Value,
                        Currency = dep.Element("loanAmount").Attribute("currency").Value,
                        Percent = dep.Element("loanPercent").Value,
                        LoanRoot = dep.Element("loanRoot").Value,
                        OpenDate = dep.Element("openDate").Value,
                        LoanDue = dep.Element("loanDueDate").Value
                        
                    }
                )
                .ToList();

            loanGrid.DataSource = loanList;
            userGrid.DataSource = list;
            
        }

        private void InitializeComboBoxes()
        {
            userListBox.Items.Clear();
            genderBox.Items.Clear();
            countryBox.Items.Clear();
            cityBox.Items.Clear();
            officeBox.Items.Clear();
            roleBox.Items.Clear();
            resTypeBox.Items.Clear();
            currencyBox.Items.Clear();
            loanGuid.Items.Clear();
            loanCurrencyBox.Items.Clear();

            genderBox.Items.AddRange(Enum.GetNames(typeof(Sex)));
            countryBox.Items.AddRange(Enum.GetNames(typeof(Country)));
            cityBox.Items.AddRange(Enum.GetNames(typeof(City)));
            officeBox.Items.AddRange(Enum.GetNames(typeof(Office)));
            roleBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            resTypeBox.Items.AddRange(Enum.GetNames(typeof(ResponsiblePerson)));
            currencyBox.Items.AddRange(Enum.GetNames(typeof(Currency)));
            loanCurrencyBox.Items.AddRange(Enum.GetNames(typeof(Currency)));
            XDocument xdoc = XDocument.Load("myUsers.xml");
            var list = xdoc.Root.Descendants("user").Select(us => us.Attribute("identificator").Value).ToList();

            
            if (list.Count > 0)
            {
                loanGuid.Items.AddRange(list.Cast<object>().ToArray());
                userListBox.Items.AddRange(list.Cast<object>().ToArray());
                userListBox.SelectedIndex = 0;
                loanGuid.SelectedIndex = 0;
            }

            currencyBox.SelectedIndex = 0;
            genderBox.SelectedIndex = 0;
            countryBox.SelectedIndex = 0;
            cityBox.SelectedIndex = 0;
            officeBox.SelectedIndex = 0;
            roleBox.SelectedIndex = 0;
            resTypeBox.SelectedIndex = 0;
            loanCurrencyBox.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = fnameBox.Text;
                string lname = lnameBox.Text;
                Sex sex = (Sex)genderBox.SelectedIndex;
                string prnum = pnBox.Text;
                DateTime birth = birthBox.Value;
                Country country = (Country)countryBox.SelectedIndex;
                City city = (City)cityBox.SelectedIndex;
                string email = emailbox.Text;
                string phone = phoneBox.Text;
                Dictionary<Guid, ResponsiblePerson> tempRes = new Dictionary<Guid, ResponsiblePerson>();
                tempRes.Add(Guid.Parse(resBox.Text), (ResponsiblePerson)resTypeBox.SelectedIndex);
                string username = usernameBox.Text;
                string password = passbox.Text;
                Office office = (Office)officeBox.SelectedIndex;
                Role role = (Role)roleBox.SelectedIndex;

                AuthUser newUser = new AuthUser(prnum, fname, lname, sex, birth, country, city, phone, email, tempRes)
                {
                    Username = username,
                    PassWord = password,
                    UserOffice = office,
                    UserRole = role
                };

                newUser.ValidateBirthDate();
                newUser.ValidateEmail();
                newUser.ValidateLastName();
                newUser.ValidateName();
                newUser.ValidatePhoneNumber();
                newUser.ValidatePrivateNum();

                newUser.AddResponsible(Guid.NewGuid(), ResponsiblePerson.Friend);
                newUser.AddUser();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            InitializeDataGrids();
            InitializeComboBoxes();
            
        }

        private void openDepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ident = userListBox.Text;
                decimal amount = depositAmount.Value;
                decimal percent = percentBox.Value;
                Currency cur = (Currency)currencyBox.SelectedIndex;

                Deposit myDeposit = new Deposit(Guid.Parse(ident), amount, percent, cur);
                myDeposit.OpenDeposit();
            }
            catch (Exception)
            {

                throw;
            }

            InitializeDataGrids();
            InitializeComboBoxes();
        }

        private void getLoanButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ident = loanGuid.Text;
                decimal amount = loanAmountBox.Value;
                decimal percent = loanPercentBox.Value;
                Currency cur = (Currency)loanCurrencyBox.SelectedIndex;
                DateTime loanDue = loanDueDateBox.Value;
                decimal loanRoot = loanRootBox.Value;

                Loan newLoan = new Loan(Guid.Parse(ident), amount, percent, cur, loanRoot, loanDue, (Office)officeBox.SelectedIndex);
                newLoan.OpenLoanByID();
            }
            catch (Exception)
            {

                throw;
            }

            InitializeDataGrids();
            InitializeComboBoxes();
        }

        private void topFilter_Click(object sender, EventArgs e)
        {
            int compNum = Convert.ToInt32(topFilterVal.Value);
            XDocument xdeposit = XDocument.Load("loans.xml");
            var loanList = xdeposit.Root.Descendants("loan")
                .Select(dep =>
                    new
                    {
                        GUID = dep.Element("userGuid").Value,
                        Amount = dep.Element("loanAmount").Value,
                        Currency = dep.Element("loanAmount").Attribute("currency").Value,
                        Percent = dep.Element("loanPercent").Value,
                        LoanRoot = dep.Element("loanRoot").Value,
                        OpenDate = dep.Element("openDate").Value,
                        LoanDue = dep.Element("loanDueDate").Value
                    }
                )
                .OrderByDescending(r => r.LoanRoot)
                .Take(compNum)
                .ToList();

            loanGrid.DataSource = loanList;

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            XDocument xdeposit = XDocument.Load("loans.xml");
            var byOffice = xdeposit.Root.Descendants("loan").Select(item =>
                   new
                   {
                       myOffice = item.Element("office").Value,
                       amount = Convert.ToDecimal(item.Element("loanAmount").Value)
                   }
                ).GroupBy(pair => pair.myOffice);

            string result = "";
            foreach (var item in byOffice)
            {
                result += $"{item.Key} : {item.Sum(x => x.amount)}\n";
            }
            MessageBox.Show(result, "Report");
        }

        private void dateFilterButton_Click(object sender, EventArgs e)
        {
            DateTime ft = filterStart.Value;
            DateTime fe = filterEnd.Value;
            XDocument xdeposit = XDocument.Load("loans.xml");
            var loanList = xdeposit.Root.Descendants("loan")
                .Select(dep =>
                    new
                    {
                        GUID = dep.Element("userGuid").Value,
                        Amount = dep.Element("loanAmount").Value,
                        Currency = dep.Element("loanAmount").Attribute("currency").Value,
                        Percent = dep.Element("loanPercent").Value,
                        LoanRoot = dep.Element("loanRoot").Value,
                        OpenDate = dep.Element("openDate").Value,
                        LoanDue = dep.Element("loanDueDate").Value
                    }
                )
                .Where(item => DateTime.Parse(item.OpenDate) > ft && DateTime.Parse(item.OpenDate) < fe)
                .ToList();

            loanGrid.DataSource = loanList;
        }
    }
}
