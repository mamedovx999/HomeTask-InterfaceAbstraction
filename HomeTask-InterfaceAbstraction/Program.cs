namespace HomeTask_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1.Square Method");
                Console.WriteLine("2.Rectangular Method");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Enter Your Choose ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Square methodu");
                            int side = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square(side);
                            Console.WriteLine($"Sqaure:" + square.CalcArea());
                            break;
                        }
                    case 2:
                        Console.WriteLine("Enter Width method");
                      int width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Length method");
                        int lenght = Convert.ToInt32(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width, lenght);
                        Console.WriteLine($"Rectangular:" + rectangular.CalcArea());
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choose!=0);
            











                
        } 
    }
}