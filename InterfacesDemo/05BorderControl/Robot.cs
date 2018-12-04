using System;
using System.Collections.Generic;
using System.Text;

namespace _05BorderControl
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Id { get; set; }
        public string Model { get => this.model; private set => this.model =value ; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
