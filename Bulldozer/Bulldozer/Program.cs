using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer("Yellow","Mini");
            var dozer2 = new BullDozer("Red", "Medium");
            

            Console.WriteLine("My bulldozer1 is " + dozer.Colour + "its size is " + dozer.Tamano);
            Console.WriteLine("My bulldozer2 is " + dozer2.Colour + "Its size is " + dozer2.Tamano);
        }
    }
    public class BullDozer
    {
        public BullDozer(string _Colour, string _Tamano)
        {
            this.Colour = _Colour;
            this.Tamano = _Tamano;
        }
        public string Colour { get; set; }
        public string Tamano { get; set; }
    }
}
