using GameShop.Abstract;
using System;

namespace GameShop.MernisServiceReference
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NationalityID { get; set; }
    }
}
