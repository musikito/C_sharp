using System;


namespace oop_cSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var myDrinkMachine = new DrinksMachine("Kitchen","Greca","greca2000");
            
            Console.WriteLine(myDrinkMachine.Location);
            Console.WriteLine(myDrinkMachine.Make);
            Console.WriteLine(myDrinkMachine.Model);

            
            myDrinkMachine.MakeCapuccino();
        }
    }
}
