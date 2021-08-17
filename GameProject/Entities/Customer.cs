using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Customer : IEntity
    {
        public Customer(int id, string nationalityId, string firstName, string lastName, int birthYear)
        {
            Id = id;
            NationalitId = nationalityId;
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }
        public int Id { get; set; }
        public string NationalitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
