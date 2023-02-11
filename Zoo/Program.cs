using System;
using System.Runtime.InteropServices;
using System.Threading;
// See https://aka.ms/new-console-template for more information


namespace Zoo
{
    interface IAnimal
    {
        //properties
        string Name { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
        public string[] illnesses { get; set; }

        public void addQuantity(int q);
        public void removeQuantity(int q);
        
    }
    public class Animal : IAnimal
    {
        //properties
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public string[] illnesses { get; set; } = new string[100];

        public string this[int i]
        {
            get { return illnesses[i]; }
            set { illnesses[i] = value; }
        }

        //instance methods
        public void addQuantity(int q)
        {
            Quantity += q;
        }
        public void removeQuantity(int q)
        {
            Quantity -= q;
            if (Quantity == 0)
            {
                Console.WriteLine("There are no " + Name+'s' + " in the zoo.");
            }
        }

    }
    /*
    public class LoadAnimal
    {
        //Delegate
        public delegate void AnimalEventHandler(object source, EventArgs args);
        //Event
        public event AnimalEventHandler animaltransport;

        public void waitAnimal(Animal animal)
        {
            Console.WriteLine(animal.Name + " is in the process of being transported.");
            Thread.Sleep(1000);

            animalImport();
        }

        protected virtual void animalImport()
        {
            if (animaltransport != null)
            {
                animaltransport(this, null);
            }
        }
    }

    public class animalEntered
    {
        public void animalImport(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Animal was placed into enclosure.");
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {   
            //class declarations
            var lion = new Animal();
            //property definitions
            lion.Name = "Lion";
            lion.Description = "I am a lion.";
            lion.Quantity = 3;
            lion.illnesses[0] = "none";
            //instance method change
            lion.addQuantity(5);
            lion.removeQuantity(8);
            Console.WriteLine(lion.Name + " has " + lion.illnesses[0]);
            /*
            //event
            var animalLoad = new LoadAnimal();
            var animalEntered = new animalEntered();
            animalLoad.animaltransport += animalEntered.animalImport();
            animalLoad.waitAnimal(lion);
            */
        }
    }
}

