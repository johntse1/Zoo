using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Schema;
// See https://aka.ms/new-console-template for more information


namespace Zoo
{
    //Used a separate interface for zoo
    interface IZoo
    {
        Animal this[int i] { get; set; }    
        string zooName { get; set; }
    }

    public class Zoo : IZoo
    {
        //indexer
        public Animal[] animals = new Animal[100];
        public Animal this[int i]
        {
            get { return animals[i]; }
            set { animals[i] = value; }
        }
        public string zooName { get; set; } = "";
    }

    interface IAnimal
    {
        //properties
        string Name { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }

        public void addQuantity(int q);
        public void removeQuantity(int q);
        
    }
    public class Animal : IAnimal
    {
        //properties
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;

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
            Zoo zoo = new Zoo();
            zoo.zooName = "Wildlife Emporium";
            
            //class declarations

            //property definitions
            var lion = new Animal();
            lion.Name = "Lion";
            lion.Description = "I am a lion.";
            lion.Quantity = 5;

            var tiger = new Animal();
            tiger.Name = "Tiger";
            tiger.Description = "I am a tiger.";
            tiger.Quantity = 4;

            var seal = new Animal();
            seal.Name = "Seal";
            seal.Description = "I am a seal.";
            seal.Quantity = 7;

            var fish = new Animal();
            fish.Name = "Fish";
            fish.Description = "I am a fish.";
            fish.Quantity = 30;

            zoo[0] = lion;
            zoo[1] = tiger;
            zoo[2] = seal ;
            zoo[3] = fish;

            Console.WriteLine("Compiled successfully");
            Console.WriteLine(zoo[0].Name + zoo[1].Name + zoo[2].Name + zoo[3].Name);
            //instance method change
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

