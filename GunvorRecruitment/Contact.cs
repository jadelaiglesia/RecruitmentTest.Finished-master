namespace GunvorRecruitment
{
    public class Contact
    {
        private readonly object _lock = new object();

        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _secondName;

        private string _street;
        private string _postalCode;
        private string _city;

        private int _age;

        public Contact(string firstName, string middleName, string secondName, string street, string postalCode, string city, int age)
        {

                _firstName = firstName;
                _middleName = middleName;
                _secondName = secondName;    
                _street = street;
                _postalCode = postalCode;
                _city = city;
                _age = age;
  
            
        }

        public void UpdateAddress(string street, string postalCode, string city)
        {
            lock (_lock)
            {
                _street = street;
                _postalCode = postalCode;
                _city = city;
            }
        }

        public void UpdateAge(int age)
        {
            lock (_lock)
            {
                _age = age;
            }
        }

        public string GetFullName()
        {
               return string.Format("{0} {1} {2}", _firstName, _middleName, _secondName);
        }

        public string GetFullAddress()
        {
              return string.Format("{0},{1} {2}", _street, _city, _postalCode);
        }

        public int GetAge()
        {
              return _age;
        }
    }
}
