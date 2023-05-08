using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Pet
    {
        virtual public string Nickname { get; set; }
        virtual public int Age { get; set; }
        virtual public string Gender { get; set; }
        virtual public int Energy { get; set; }
        virtual public double Price { get; set; }
        virtual public int MealQuantity { get; set; }
        public Pet(string nickname, string gender, int age, int energy, double price, int amount)
        {
            Nickname = nickname;
            Gender = gender;
            Age = age;
            Energy = energy;
            Price = price;
            MealQuantity = amount;
        }
        public Pet()
        {
            MealQuantity = 0;
            Energy = 0;
            Price = 0;
        }
        virtual public void Eat()
        {
            Energy += 10;
            MealQuantity++;
            Price += 1.5;
        }
        virtual public void Sleep()
        {
            Energy += 30;
            if (Energy > 100)
            {
                Energy = 100;
                Console.WriteLine("Oyanir");
            }
        }

        virtual public void Play()
        {
            Energy -= 30;
            if (Energy < 0)
            {
                Energy = 0;
                Console.WriteLine("Yatdi");
            }
        }
    }
}
