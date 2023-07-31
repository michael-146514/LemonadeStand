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
        public int priceCost;

        public Customer(string weather)
        {
            priceChance(weather);
        
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

                if(priceCost <= 1)
                {
                    pricePercent = chance - 65;
                }
                else if(priceCost >= 1)
                {
                    pricePercent = chance + 65;
                }
            }
            else if(weather == "Cloudy Sky")
            {
                int chance = rand.Next(1, 13);

                if (priceCost <= .90)
                {
                    pricePercent = chance - 50;
                }
                else if (priceCost >= .90)
                {
                    pricePercent = chance + 50;
                }
            }
            else if(weather == "Raining")
            {
                int chance = rand.Next(1, 15);

                if (priceCost <= .75)
                {
                    pricePercent = chance - 40;
                }
                else if (priceCost >= .75)
                {
                    pricePercent = chance + 40;
                }
            }
            else if(weather == "Storming")
            {
                int chance = rand.Next(1, 15);

                if (priceCost <= .65)
                {
                    pricePercent = chance - 25;
                }
                else if (priceCost >= .65)
                {
                    pricePercent = chance + 25;
                }
            }
            else if(weather == "Heat Wave")
            {
                int chance = rand.Next(1, 10);

                if (priceCost <= 1.2)
                {
                    pricePercent = chance - 80;
                }
                else if (priceCost >= 1.2)
                {
                    pricePercent = chance + 80;
                }
            }
        }
    }
}
