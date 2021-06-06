using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final
{
    public abstract class PhysicalPerson
    {

        #region ProtectedVars
        protected Guid identifier;
        protected string fname;
        protected string lname;
        protected Sex sex;
        protected string private_number;
        protected DateTime birth;
        protected Country country;
        protected City city;
        protected string phone;
        protected string email;
        protected Dictionary<Guid, ResponsiblePerson> responsibles;
        #endregion

        #region Enums
        public enum Sex
        {
            Male,
            Female
        }

        public enum ResponsiblePerson
        {
            Mother,
            Father,
            Husband,
            Friend,
            Relative,
            Other
        }

        public enum Country
        {
            Georgia,
            Japan,
            Turkey,
            Russia,
            England,
            Canada,
            Portugal
        }

        public enum City
        {
            Tbilisi,
            Qutaisi,
            Batumi,
            Tokyo,
            Ankara,
            Moscow,
            Lisabon,
            Toronto,
            London
        }
        #endregion

        #region Props
        public Guid Identifier { get => identifier; }
        public string FirstName { get => fname; set { fname = value; } }
        public string LastName { get => lname; set { lname = value; } }
        public Sex UserSex { get=> sex; set { sex = value; } }
        public string PrivateNumber { get => private_number; }
        public DateTime BirthDate { get => birth; set { birth = value; } }
        public Country UserCountry { get => country; set { country = value; } }
        public City UserCity { get => city; set { city = value; } }
        public string PhoneNumber { get => phone; set { phone = value; } }
        public string Email { get => email; set { email = value; } }
        public Dictionary<Guid,ResponsiblePerson> ResponsiblePeople { get => responsibles; set { responsibles = value; } }
        #endregion

        #region Validations Signitues
        public abstract void ValidateName();
        public abstract void ValidateLastName();
        public abstract void ValidatePrivateNum();
        public abstract void ValidateBirthDate();
        public abstract void ValidatePhoneNumber();
        public abstract void ValidateEmail();
        #endregion

        #region Methods
        
        public short GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - birth.Year;
            if (birth.Date > today.AddDays(-age)) age--;
            return (short)age;
        }

        public abstract void AddUser();

        public void RemoveUser()
        {
            XDocument xdoc = XDocument.Load("myUsers.xml");
            var chosen = xdoc.Root.Descendants("user").Where(us => us.Attribute("identificator").Value.Equals(identifier.ToString()));
            chosen.Remove(); 
        }

        public void AddResponsible(Guid ident, ResponsiblePerson person)
        {
            responsibles.Add(ident, person);
        }

        public void RemoveResponsible(Guid ident)
        {
            responsibles.Remove(ident);
        }

        public override string ToString()
            => $"First Name : {FirstName}\nLast Name : {LastName}";

        public virtual string Info()
        {
            string tempRes = "[";
            foreach (var item in responsibles)
            {
                tempRes += $"{{{item.Key} : {item.Value}}} ";
            }
            return $"Identificator : {Identifier}\n{this}\nSex : {UserSex}\n" +
            $"Private Number : {PrivateNumber}\nBirth Date : {BirthDate}\n" +
            $"Country : {UserCountry}\nCity : {UserCity}\nPhone Numebr : {PhoneNumber}\n" +
            $"Email : {Email}\nResponsible People : {tempRes}]\n";
        }
        #endregion
    }
}
