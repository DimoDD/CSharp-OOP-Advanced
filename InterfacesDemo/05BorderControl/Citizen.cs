using System;
using System.Collections.Generic;
using System.Text;

namespace _05BorderControl
{
    class Citizen : IIdentifiable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }

        public string Id { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
