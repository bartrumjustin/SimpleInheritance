namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Human : Animal
    {
        public string hairColor;
        public string eyeColor;
        public bool isAlive;

        //default constructor
        public Human()
            : base()
        {
            hairColor = "";
            eyeColor = "";
            isAlive = false;
        }

        //param constructor

        public Human(string name, string hairColor, string eyeColor, bool isAlive)
            : base(name)
        {
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
            this.isAlive = isAlive;
        }

        public void printHuman()
        {
            Console.WriteLine("Name:" + "\n" + name + "\n" + "Hair Color:" + "\n" + hairColor + "\n" + "Eye Color:" + "\n" + eyeColor + "\n" + "Still living?:" + "\n" + isAlive + "\n\n");
        }
    }

    class Cat : Animal
    {
        public int age;
        public string owner;
        public string likes;

        //default constructor
        public Cat()
            : base()
        {
            age = 0;
            owner = "";
            likes = "";
        }

        //paramatized constructor
        public Cat(string name, int age, string owner, string likes)
            : base(name)
        {
            this.age = age;
            this.owner = owner;
            this.likes = likes;
        }


        //method
        public void printCat()
        {
            Console.WriteLine("Name:" + "\n" + name + "\n" + "Age:" + "\n" + age + "\n" + "Owner:" + "\n" + owner + "\n" + "Prefers:" + "\n" + likes + "\n\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Human person = new Human();
            person.name = "Justin";
            person.hairColor = "Brown";
            person.eyeColor = "Hazel";
            person.isAlive = true;
            person.printHuman();

            //derived class object using parameterized constructor
            Human person2 = new Human("Holly", "Blonde", "Blue", true);
            person2.printHuman();

            //derived class object with default second child
            Cat lucy = new Cat();
            lucy.name = "Lucy";
            lucy.age = 3;
            lucy.owner = "Holly";
            lucy.likes = "Holly";
            lucy.printCat();
            //derived class object with paramatized second child
            Cat harley = new Cat("Harley", 7, "Justin", "Holly");
            harley.printCat();

        }

    }
}
