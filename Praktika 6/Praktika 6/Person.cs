using System;

namespace Praktika_6
{
    public class Person
    {
        private string name;
        private string surname;
        private System.DateTime bday;

        Person(string name, string surname, DateTime bday)
        {
            this.name = name;
            this.surname = surname;
            this.bday = bday;
        }

        Person()
        {
            this.name = "Ivan";
            this.surname = "Ivanov";
            this.bday = default;
        }
    }
}
