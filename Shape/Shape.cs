namespace Shape
{
    public abstract class Shape
    {
        public int noOfSides { get; set; }

        public abstract decimal CalculateSurface(decimal width,decimal height);

        public static void Main()
        {
            int[] shapes;
            decimal[] areas;
            Console.Write("How many shapes do you want in your array: ");
            int length=int.Parse(Console.ReadLine());
            shapes=new int[length];
            areas=new decimal[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write("\nHow many sides does this shape have: ");
                int sides=int.Parse(Console.ReadLine());
                shapes[i] = sides;

                if (sides == 4)
                {
                    Console.Write("Enter the width: ");
                    decimal width=decimal.Parse(Console.ReadLine());
                    Console.Write("Enter the heigth: ");
                    decimal heigth = decimal.Parse(Console.ReadLine());
                    new Rectangle(width, heigth);
                }

                else if (sides == 3)
                {
                    Console.Write("Enter the width: ");
                    decimal width = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter the heigth: ");
                    decimal heigth = decimal.Parse(Console.ReadLine());
                    new Triangle(width, heigth);
                }

                else if (sides == 0)
                {
                    Console.Write("Enter the radius: ");
                    decimal radius = decimal.Parse(Console.ReadLine());
                    new Circle(radius);
                }

                else { Console.WriteLine("The number of sides entered do not match the shapes provided"); }
            }

        }
    }
}