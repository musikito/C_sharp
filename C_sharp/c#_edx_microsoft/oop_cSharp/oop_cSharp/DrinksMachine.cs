using System;

namespace oop_cSharp
{
    public class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        private string _location;
        private string _make;
        private string _model;

        public string Location
        { get => _location; 
          set => _location = value;
        }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        public void MakeCapuccino()
        {
            Console.WriteLine("Capuccino is made");
        }
    }
}