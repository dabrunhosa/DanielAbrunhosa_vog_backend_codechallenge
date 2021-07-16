using System;

namespace VogCodeChallenge.Domain.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public Department Department { get; set; }

        /// <summary>
        /// Address of Residence (Mailing Address)
        /// </summary>
        public string Address { get; set; }
    }
}
