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
                            double side = Convert.ToDouble(Console.ReadLine());
                            Square square = new Square(side);
                            Console.WriteLine($"Sqaure:" + square.CalcArea);
                            break;
                        }
                    case 2:
                        Console.WriteLine("Enter Width method");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Length method");
                        double lenght = Convert.ToDouble(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width, lenght);
                        Console.WriteLine($"Rectangular:" + rectangular.CalcArea);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choose!=0);
            











                
        } 
    }
}