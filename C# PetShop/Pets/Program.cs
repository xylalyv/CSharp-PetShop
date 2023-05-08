namespace Pets
{
    public class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Tom", "male", 20, 2, 25.6, 1);
            Dog dog = new Dog("Ben", "male", 4, 21, 19.3, 1);
            Bird bird = new Bird("Tutu", "male", 32, 0, 10.2, 0);
            Fish fish = new Fish("Nemo", "male", 18, 0, 8.9, 0);
            List<Pet> pets = new List<Pet>() { cat ,dog, bird , fish};
            Dog[] dogs = new Dog[]{ new Dog("Ben", "male", 4, 21, 19.3, 1) };
            Cat[] cats = new Cat[] { new Cat("Tom", "male", 20, 2, 25.6, 1) };
            Bird[] birds = new Bird[] { new Bird("Tutu", "male", 32, 0, 10.2, 0) };
            Fish[] fishes = new Fish[] { new Fish("Nemo", "male", 18, 0, 8.9, 0) };
            PetsShop ps = new PetsShop(cats, dogs, birds, fishes);
            string[] menuOptionsForPets = { "Tom", "Ben", "Tutu", "Nemo" };
            string[] menuOptionsForPetsActivity = { "Eat", "Sleep", "Play", "Remove by nickname", "Calculate total cost", "Calculate total meal quantity"};
            int selectedIndexForPets = 0;
            int selectedIndexForPetsActivity = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
                    PetsShop
                
                ");
                Console.ResetColor();
                for (int i = 0; i < menuOptionsForPets.Length; i++)
                {
                    if (i == selectedIndexForPets)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"--> {menuOptionsForPets[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {menuOptionsForPets[i]}");
                    }
                }
                var opKeyForPets = Console.ReadKey(true);
                if (opKeyForPets.Key == ConsoleKey.UpArrow)
                {
                    selectedIndexForPets = Math.Max(selectedIndexForPets - 1, 0);
                }
                else if (opKeyForPets.Key == ConsoleKey.DownArrow)
                {
                    selectedIndexForPets = Math.Min(selectedIndexForPets + 1, menuOptionsForPets.Length - 1);
                }
                else if (opKeyForPets.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    for (int i = 0; i < menuOptionsForPetsActivity.Length; i++)
                    {
                        if (i == selectedIndexForPetsActivity)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"--> {menuOptionsForPetsActivity[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {menuOptionsForPetsActivity[i]}");
                        }
                    }
                    var opKeyForPetsActivity = Console.ReadKey(true);
                    if (opKeyForPetsActivity.Key == ConsoleKey.UpArrow)
                    {
                        selectedIndexForPetsActivity = Math.Max(selectedIndexForPetsActivity - 1, 0);
                    }
                    else if (opKeyForPetsActivity.Key == ConsoleKey.DownArrow)
                    {
                        selectedIndexForPetsActivity = Math.Min(selectedIndexForPetsActivity + 1, menuOptionsForPetsActivity.Length - 1);
                    }
                    switch (selectedIndexForPets)
                    {
                        case 0:
                            if (opKeyForPetsActivity.Key == ConsoleKey.Enter)
                            {
                                switch (selectedIndexForPetsActivity)
                                {
                                    case 0:
                                        pets[0].Eat();
                                        Console.WriteLine("Tom yeyir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 1:
                                        pets[0].Sleep();
                                        Console.WriteLine("Tom yatir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 2:
                                        pets[0].Play();
                                        Console.WriteLine("Tom oynayir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 3:
                                        ps.RemoveByNickName("b");
                                        Thread.Sleep(1000);
                                        break;
                                    case 4:
                                        Console.WriteLine(ps.CalculateTotalCost());
                                        Thread.Sleep(1000);
                                        break;
                                    case 5:
                                        Console.WriteLine(ps.CalculateTotalMealQuantity());
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            break;
                        case 1:
                            if (opKeyForPetsActivity.Key == ConsoleKey.Enter)
                            {
                                switch (selectedIndexForPetsActivity)
                                {
                                    case 0:
                                        pets[1].Eat();
                                        Console.WriteLine("Tom yeyir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 1:
                                        pets[1].Sleep();
                                        Console.WriteLine("Tom yatir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 2:
                                        pets[1].Play();
                                        Console.WriteLine("Tom oynayir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 3:
                                        ps.RemoveByNickName("Tom");    
                                        Thread.Sleep(1000);
                                        break;
                                    case 4:
                                        Console.WriteLine(ps.CalculateTotalCost());
                                        Thread.Sleep(1000);
                                        break;
                                    case 5:
                                        Console.WriteLine(ps.CalculateTotalMealQuantity());   
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            break;
                        case 2:
                            if (opKeyForPetsActivity.Key == ConsoleKey.Enter)
                            {
                                switch (selectedIndexForPetsActivity)
                                {
                                    case 0:
                                        pets[2].Eat();
                                        Console.WriteLine("Tutu yeyir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 1:
                                        pets[2].Sleep();
                                        Console.WriteLine("Tutu yatir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 2:
                                        pets[2].Play();
                                        Console.WriteLine("Tutu oynayir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 3:
                                        ps.RemoveByNickName("Tutu");
                                        Thread.Sleep(1000);
                                        break;
                                    case 4:
                                        Console.WriteLine(ps.CalculateTotalCost());
                                        Thread.Sleep(1000);
                                        break;
                                    case 5:
                                        Console.WriteLine(ps.CalculateTotalMealQuantity());
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            break;
                         case 3:
                            if (opKeyForPetsActivity.Key == ConsoleKey.Enter)
                            {
                                switch (selectedIndexForPetsActivity)
                                {
                                    case 0:
                                        pets[3].Eat();
                                        Console.WriteLine("Nemo yeyir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 1:
                                        pets[3].Sleep();
                                        Console.WriteLine("Nemo yatir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 2:
                                        pets[3].Play();
                                        Console.WriteLine("Nemo oynayir");
                                        Thread.Sleep(1000);
                                        break;
                                    case 3:
                                        ps.RemoveByNickName("Nemo");
                                        Thread.Sleep(1000);
                                        break;
                                    case 4:
                                        Console.WriteLine(ps.CalculateTotalCost());
                                        Thread.Sleep(1000);
                                        break;
                                    case 5:
                                        Console.WriteLine(ps.CalculateTotalMealQuantity());
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                }
                };
            }
        }

}