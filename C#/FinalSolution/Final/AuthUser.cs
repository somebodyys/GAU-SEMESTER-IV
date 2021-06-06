using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final
{
    public class AuthUser : PhysicalPerson
    {

        #region PrivateVars
        private string username;
        private string password;
        private Office office;
        private Role role;
        #endregion

        #region Prop
        public string Username { get => username; set { username = value; }}
        public string PassWord { get=>password; set { password = value; } }
        public Office UserOffice { get => office; set { office = value; } }
        public Role UserRole { get => role; set { role = value; } }
        #endregion

        #region Constructors
        public AuthUser(string prnum, string fname, string lname)
        {
            identifier =Guid.NewGuid();
            private_number = prnum;
            FirstName = fname;
            LastName = lname;
        }

        public AuthUser(string prnum, string fname, string lname, Sex sex, DateTime bdate)
            :this(prnum, fname, lname)
        {
            UserSex = sex;
            BirthDate = bdate;
        }

        public AuthUser(string prnum, string fname, string lname, Sex sex, DateTime bdate, Country country, City city, string phone, string email, Dictionary<Guid, ResponsiblePerson> resp)
            : this(prnum, fname, lname, sex, bdate)
        {
            UserCountry = country;
            UserCity = city;
            PhoneNumber = phone;
            Email = email;
            responsibles = resp;
        }
        #endregion

        #region Validations
        public override void ValidateBirthDate()
        {
            if (GetAge() < 18) throw new ArgumentException("Minimum age is 18");
            switch (sex)
            {
                case Sex.Male:
                    if (GetAge() > 65) throw new ArgumentException("Male In Pension age(65) can not is not eligable.");
                    break;
                case Sex.Female:
                    if (GetAge() > 60) throw new ArgumentException("Female In Pension age(60) can not is not eligable.");
                    break;
            }
        }

        public override void ValidateEmail()
        {
            Regex reg = new Regex("^[A-Za-z0-9]{3,20}@[A-Za-z]{3,10}.(com|co.in|co.au)$");
            if (!reg.IsMatch(Email)) throw new Exception("Wrong Email Format (something@gmail.com)");
        }

        public override void ValidateLastName()
        {
            if (lname.Equals("")) throw new ArgumentException("Last Name Can not be empty");
            if (lname.Length < 2 || lname.Length > 50) throw new ArgumentException("Last Name Length Should be in interval [2:50]");
        }

        public override void ValidateName()
        {
            if (fname.Equals("")) throw new ArgumentException("First Name Can not be empty");
            if (fname.Length < 2 || fname.Length > 50) throw new ArgumentException("First Name Length Should be in interval [2:50]");
        }

        public override void ValidatePhoneNumber()
        {
            Regex reg = new Regex("^[0-9]{4,50}$");
            if (!reg.IsMatch(PhoneNumber)) throw new Exception("Wrong Phone Number Format numbers[4-50]symbols!");
        }

        public override void ValidatePrivateNum()
        {
            Regex test = new Regex("^[0-9]{11}$");
            if (private_number.Equals("")) throw new ArgumentException("Private Number Can not be empty");
            if (!test.IsMatch(private_number)) throw new ArgumentException("Private Number must consist of 11 numbers");
        }

        #endregion

        #region Enums
        public enum Office
        {
            Office1,
            Office2,
            Office3
        }

        public enum Role
        {
            Operator,
            Cashier,
            Manager,
            OfficeLead
        }
        #endregion

        #region Methods

        
        public override string Info()
            => $"Username : {username}\nOffice : {office}\nRole : {role}\n{base.Info()}";

        public override void AddUser()
        {
            XDocument xdoc = XDocument.Load("myUsers.xml");
            XElement user =
                new XElement("user", new XAttribute("identificator", identifier),
                    new XElement("fname", fname),
                    new XElement("lname", lname),
                    new XElement("gender", sex),
                    new XElement("privateNum", private_number),
                    new XElement("birthDate", birth),
                    new XElement("country", country),
                    new XElement("city", city),
                    new XElement("phone", phone),
                    new XElement("email", email),
                    new XElement("username", username),
                    new XElement("password", password),
                    new XElement("office", office),
                    new XElement("role", role),
                    new XElement("responsibles",
                        responsibles.Select(res =>
                            new XElement("responsible",
                                new XElement("GUID", res.Key),
                                new XElement("type", res.Value))
                            )
                    )
            );

            xdoc.Root.Add(user);
            xdoc.Save("myUsers.xml");
        }
        #endregion

    }
}
