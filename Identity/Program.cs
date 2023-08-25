// See https://aka.ms/new-console-template for more information


using Creature.Human.Ahwal;

class APP
{



    public static void Main()
    {

        Console.WriteLine("Hey please type the number of the service:");
        Console.WriteLine("1. Ahwal");

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        int option;



        if (int.TryParse(keyInfo.KeyChar.ToString(), out option))
        {
            switch (option)
            {
                case 1:

                    Console.WriteLine("Welcome to Ahwal Program");
                    Console.WriteLine("please chose the service needed: ");
                    Console.WriteLine("1. register");
                    Console.WriteLine("2. Show current citizen");

                    keyInfo = Console.ReadKey();

                    Console.WriteLine(" ");

                    switch (keyInfo.KeyChar)
                    {
                        case '1':
                            Ahwal.register();
                            Main();
                            break;
                        case '2':
                            Ahwal.GetHumans();
                            Main();
                            break;
                        default:
                            Console.WriteLine("Invalid option selected");
                            break;
                    }
                    break;
                default:
                    // Invalid option
                    Console.WriteLine("Invalid option selected");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }



}