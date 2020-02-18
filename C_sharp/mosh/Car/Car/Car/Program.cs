using System;

namespace Car
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car1 = new CarClass();
            var salooncar1 = new SaloonCar(2);
            var salooncar2 = new SaloonCar(3, "nissan");
            var salooncar3 = new SaloonCar(4, "Ford", "purple");


            Console.WriteLine("Saloon Car1 " + salooncar1.numberOfSeats);
            Console.WriteLine("Saloon Car2 " + salooncar2.numberOfSeats + ""+salooncar2.manufacturer);
            Console.WriteLine("Saloon Car3 " + salooncar3.numberOfSeats + salooncar3.manufacturer + salooncar3.colour);
            
        }
    }

    public class CarClass
    {
        //constructor
        public CarClass ()
        {
            

        }//end constructor
        public string colour { get; set; }
        public string manufacturer { get; set; }

    }//End of CarClass

    public class SaloonCar : CarClass
    {
        public SaloonCar(int _numberofseat)
        {
            this.numberOfSeats = _numberofseat;
            
        }
        public SaloonCar(int _numberofseats, string _manufacturer)
        {
            this.numberOfSeats = _numberofseats;
            this.manufacturer = _manufacturer;
        }
        public SaloonCar(int _numberofseats, string _manufacturer, string _colour)
        {
            this.numberOfSeats = _numberofseats;
            this.manufacturer = _manufacturer;
            this.colour = _colour;
        }
        public int numberOfSeats { get; set; }
    }


}
