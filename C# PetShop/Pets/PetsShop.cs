using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class PetsShop
    {
        public Cat[]? cats = new Cat[] { };
        public Dog[]? dogs = new Dog[] { };
        public Bird[]? birds = new Bird[] { };
        public Fish[]? fishes = new Fish[] { };
        public PetsShop(Cat[] cats, Dog[] dogs, Bird[] birds, Fish[] fishes)
        {
            this.cats = cats;
            this.dogs = dogs;
            this.birds = birds;
            this.fishes = fishes;
        }

        public void RemoveByNickName(string nickname)
        {
            for (int i = 0; i < cats?.Length; i++)
            {
                if (cats[i].Nickname == nickname)
                {
                    cats[i] = null;
                    return;
                }
            }
            for (int i = 0; i < dogs?.Length; i++)
            {
                if (dogs[i].Nickname == nickname)
                {
                    dogs[i] = null;
                    return;
                }
            }
            for (int i = 0; i < birds?.Length; i++)
            {
                if (birds[i].Nickname == nickname)
                {
                    birds[i] = null;
                    return;
                }
            }
            for (int i = 0; i < fishes?.Length; i++)
            {
                if (fishes[i].Nickname == nickname)
                {
                    fishes[i] = null;
                    return;
                }
            }
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            for (int i = 0; i < cats?.Length; i++)
            {
                if (cats[i] != null)
                {
                    totalCost += cats[i].Price;
                }
            }
            for (int i = 0; i < birds?.Length; i++)
            {
                if (birds[i] != null)
                {
                    totalCost += birds[i].Price;
                }
            }
            for (int i = 0; i < dogs?.Length; i++)
            {
                if (dogs[i] != null)
                {
                    totalCost += dogs[i].Price;
                }
            }
            for (int i = 0; i < fishes?.Length; i++)
            {
                if (fishes[i] != null)
                {
                    totalCost += fishes[i].Price;
                }
            }
            return totalCost;
        }

        public int CalculateTotalMealQuantity()
        {
            int totalQuantity = 0;
            for (int i = 0; i < cats?.Length; i++)
            {
                if (cats[i] != null)
                {
                    totalQuantity += cats[i].MealQuantity;
                }
            }
            for (int i = 0; i < dogs?.Length; i++)
            {
                if (dogs[i] != null)
                {
                    totalQuantity += dogs[i].MealQuantity;
                }
            }
            for (int i = 0; i < birds?.Length; i++)
            {
                if (birds[i] != null)
                {
                    totalQuantity += birds[i].MealQuantity;
                }
            }
            for (int i = 0; i < fishes?.Length; i++)
            {
                if (fishes[i] != null)
                {
                    totalQuantity += fishes[i].MealQuantity;
                }
            }
            return totalQuantity;
        }
    }
}
