
namespace Creature.Human.Ahwal
{
    public static class Ahwal
    {
        private static List<Human> humans = new List<Human>();
        public static bool inService = false;

        public static Human register()
        {
            Human human = new Human();

            Console.WriteLine("please type your first name:");
            human.firstName = Console.ReadLine()?.ToString();

            if (human.firstName.Length > 0)
            {
                Console.WriteLine("please type your last name:");
                human.lastName = Console.ReadLine().ToString();
            }
            if (human.lastName.Length > 0)
            {
                Console.WriteLine("please type your age:");
                human.age = int.Parse(Console.ReadLine().ToString());
            }
            if (human.age > 0)
            {
                Console.WriteLine("please type your birthdate:");
                human.birthDate = Console.ReadLine().ToString();
            }


            human.Id = long.Parse(DateTime.Now.Millisecond.ToString());
            Console.WriteLine($"your generated ID: {human.Id}");

            humans.Add(human);

            return human;
        }

        public static void GetHumans()
        {
            Human human = new Human();

            humans.Add(human);

            Console.WriteLine(humans);
        }
    }
}