namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
          User user = new User();
            do
{
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                if (user.PasswordChecker(password))
                {
                    Console.WriteLine("girish ugurlu");
                    break;
                }
                else Console.WriteLine("yeniden yazin ");
            } while (true);
        }

    }

}
