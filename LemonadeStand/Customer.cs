using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class Customer
    {
       
        public bool buy = false;
        public bool soldOut;
        public int pricePercent;
        public double priceCost;

        public Customer(string weather, double price)
        {
            priceChance(weather);

            priceCost = price;
        }


        public void CheckIfBuying(string weather)
        {
            Random rand = new Random();
          
            Console.WriteLine("Person is Walking by the Lemonade Stand");

            if (soldOut == true)
            {
                Console.WriteLine("Sold Out cant buy anything");
            }
            else if (weather == "Clear Sky")
            {
                int chance = rand.Next(1, 100);

                if (chance < pricePercent)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
            else if (weather == "Cloudy Sky")
            {
                int chance = rand.Next(1, 100);

                if (chance < pricePercent)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
            else if (weather == "Raining")
            {
                int chance = rand.Next(1, 100);

                if (chance < pricePercent)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
            else if (weather == "Storming")
            {
                int chance = rand.Next(1, 100);

                if (chance < pricePercent)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
            else if(weather == "Heat Wave")
            {
                int chance = rand.Next(1, 100);

                if (chance < pricePercent)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
        }


        public void priceChance(string weather)
        {
            Random rand = new Random();

            if (weather == "Clear Sky")
            {
                int chance = rand.Next(1, 15);

                if(priceCost <= 3.5)
                {
                    pricePercent = 65 - chance;
                }
                else if(priceCost >= 3.5)
                {
                    pricePercent = 65 + chance;
                }
            }
            else if(weather == "Cloudy Sky")
            {
                int chance = rand.Next(1, 13);

                if (priceCost <= 1.5)
                {
                    pricePercent = 50 - chance;
                }
                else if (priceCost >= 1.5)
                {
                    pricePercent = 50 + chance;
                }
            }
            else if(weather == "Raining")
            {
                int chance = rand.Next(1, 15);

                if (priceCost <= 1)
                {
                    pricePercent = 40 - chance;
                }
                else if (priceCost >= .75)
                {
                    pricePercent = 40 + chance;
                }
            }
            else if(weather == "Storming")
            {
                int chance = rand.Next(1, 10);

                if (priceCost <= 1)
                {
                    pricePercent = 25 - chance;
                }
                else if (priceCost >= .75)
                {
                    pricePercent = 25 + chance;
                }
            }
            else if(weather == "Heat Wave")
            {
                int chance = rand.Next(1, 15);

                if (priceCost <= 3.5)
                {
                    pricePercent = 80 - chance;
                }
                else if (priceCost >= 2)
                {
                    pricePercent = 80 + chance;
                }
            }
        }
    }
}
