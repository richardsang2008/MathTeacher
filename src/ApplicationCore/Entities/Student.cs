using System;

namespace ApplicationCore.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}