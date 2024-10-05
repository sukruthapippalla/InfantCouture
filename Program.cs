using System.Reflection.Metadata;

namespace InfantCouture
{
    internal class Program
    {
        public static List<BabyDress> DressesCart = new List<BabyDress>();

        static void Main(string[] args)
        {
            BabyDressUtility babyDressUtility = new BabyDressUtility();

            bool bl = false;
            while (!bl)
            {
                Console.WriteLine("1.Add dress to cart");
                Console.WriteLine("2.Remove dress from cart");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            BabyDress dress = new BabyDress();

                            Console.WriteLine("Enter the dress size");
                            dress.Size = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the dress color");
                            dress.Color = Console.ReadLine();

                            Console.WriteLine("Enter the dress brand");
                            dress.Brand = Console.ReadLine();

                            Console.WriteLine("Enter the dress price");
                            dress.Price = int.Parse(Console.ReadLine());

                            babyDressUtility.AddDressToCart(dress);
                            Console.WriteLine("Successfully added to the cart");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the dress brand to remove the dress from the cart");
                            string br = Console.ReadLine();

                            if (babyDressUtility.RemoveDressFromCart(br))
                            {
                                Console.WriteLine("Successfully removed from the cart");
                            }
                            else
                            {
                                Console.WriteLine("Dress not found");
                            }

                            break;
                        }
                    case 3:
                        {
                            bl = true;

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");

                            break;
                        }
                }
            }

        }
    }
}
