using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Animal
    {
      public string Name;
       public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound()

        {
            Console.WriteLine("This animal makes a generic sound");
        }
        public virtual void DoTrick()
        {
            Console.WriteLine("This animal does a generic trick");
        }
    }
        class Lion : Animal
        {
            public Lion(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine($"{Name} lion roars loudly");
            }
            public override void DoTrick()
            {
                Console.WriteLine($"{Name} lion performs a majestic leap");
            }
        }
        class Elephant : Animal

        {
            public Elephant(string name, int age) : base(name, age) { }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} elephant roars loudly");
            }
            public override void DoTrick()
            {
                Console.WriteLine($"{Name} elephant sprays water with its trunk");
            }


        }
    class Zebra : Animal

    {
        public Zebra(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} zebra snorts heavily");
        }
        public override void DoTrick()
        {
            Console.WriteLine($"{Name} zebra jumps through hoops in the cirus");
        }


    }
    class Monkey : Animal

    {
        public Monkey(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} monkey makes annoying noise while eating");
        }
        public override void DoTrick()
        {
            Console.WriteLine($"{Name} monkey eats a lot of bananas in a day");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal("Simba", 30);
            Animal elephant = new Animal("Dumbo", 40);
            Animal zebra = new Animal("Thor", 40);
            Animal monkey = new Animal("Max", 40);

            lion.MakeSound();
            lion.DoTrick();

            elephant.MakeSound();
            elephant.DoTrick();
            zebra.MakeSound();
            monkey.DoTrick();

            Lion Simba = new Lion("Simba", 30);
            Elephant Dumbo = new Elephant("Dumbo", 40);
            Zebra Zoonie = new Zebra("Zoonie", 30);
            Monkey Max = new Monkey("Max", 40);

            Simba.MakeSound();
            Simba.DoTrick();

            Dumbo.MakeSound();
            Dumbo.DoTrick();

            Zoonie.MakeSound();
            Zoonie.DoTrick();

            Max.MakeSound();
            Max.DoTrick();
            Simba.Age = 20;
            Console.WriteLine("New age of Simba: " +  Simba.Age);

        }
    }
}
