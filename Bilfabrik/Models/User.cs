﻿namespace Bilfabrik.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public EmployeeClass Employee { get; set; } = EmployeeClass.Montör;

    }
}
