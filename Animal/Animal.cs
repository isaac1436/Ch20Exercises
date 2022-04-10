namespace Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public int age { get; set; }
        public char gender { get; set; }

        public Animal() { }
        public Animal(string name, int age, char gender)
        {
            this.Name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void noise()
        {

        }

        static void Main()
        {
            Console.Write("\t\t\t Animal Registration System");
            Console.Write("\n\nHow many animals would you like to register: ");
            int no = int.Parse(Console.ReadLine());

            Animal[] animals = new Animal[no];
            string[] type = new string[no];

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write("\nWhat type of animal are you entering: ");
                type[i] = Console.ReadLine();

                Console.Write("\nWhat's the name of your {0}: ", type[i]);
                string name = Console.ReadLine();

                Console.Write("\nHow old is {0}: ", name);
                int age = int.Parse(Console.ReadLine());

                Console.Write("\nWhat is the gender of {0}: ", name);
                char gender = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                animals[i] = new Animal(name, age, gender);

            }

            Console.WriteLine("S/N\tName \t\t\t Age \tGender \tSpecies \tNoise");

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write("{0}\t{1} \t\t\t {2} \t{3}", i + 1, animals[i].Name, animals[i].age, animals[i].gender);

                if (type[i].ToLower() == "dog")
                {
                    new Dog();
                }

                else if (type[i].ToLower() == "frog")
                {
                    new Frog();
                }

                else if (type[i].ToLower() == "cat")
                {
                    new Cat();
                }

                else if (type[i].ToLower() == "tomcat")
                {
                    new Tomcat();
                }

                else if (type[i].ToLower() == "kitten")
                {
                    new Kitten();
                }

                Console.WriteLine("\n");
            }
        }
    }
}