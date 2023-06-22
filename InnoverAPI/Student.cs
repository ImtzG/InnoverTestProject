using System;
using System.Collections.Generic;

namespace InnoverAPI
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<Hobby> Hobbies { get; set; }
    }

    public class Hobby
    {
        public string HobbyName { get; set; }
    }
}
