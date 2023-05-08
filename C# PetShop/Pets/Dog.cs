using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Pet
    {
        private string nickname;
        private string gender;
        private int age;
        private int energy;
        private double price;
        private int amount;
        public override string Nickname { get { return nickname; } set { if (nickname is not null) { nickname = value; } else { return; } } }
        public override int Age { get { return age; } set { if (age > 0) { age = value; } } }
        public override string Gender { get { return gender; } set { if (gender is not null) { gender = value; } else { return; } } }
        public override int Energy { get { return energy; } set { if (energy >= 0 && energy <= 100) { energy = value; } else { return; } } }
        public override double Price { get { return price; } set { if (price > 0) { price = value; } else { return; } } }
        public override int MealQuantity { get { return amount; } set { if (amount > 0) { amount = value; } else { return; } } }
        public Dog(string nickname, string gender, int age, int energy, double price, int amount) : base(nickname, gender, age, energy, price, amount)
        {
            Nickname = nickname;
            Gender = gender;
            Age = age;
            Energy = energy;
            Price = price;
            MealQuantity = amount;
        }
        public Dog()
        {
            MealQuantity = 0;
            Energy = 0;
            Price = 0;
        }

        public override void Sleep()
        {
            base.Sleep();
        }
        public override void Play()
        {
            base.Play();
        }
        public override void Eat()
        {
            base.Eat();
        }
    }
}
