using System;
// See https://aka.ms/new-console-template for more information


namespace Zoo
{
    interface IAnimal
    {
        string Name { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
    }
    class Animal: IAnimal
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal();
            lion.Name = "Lion";
            lion.Description = "I am a lion.";
            lion.Quantity = 3;
            Console.WriteLine(lion.Name +' '+ lion.Description+' '+ lion.Quantity);
        }
    }
}

