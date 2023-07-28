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


        public Customer()
        {
            
        
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

                if (chance < 65)
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

                if (chance < 50)
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

                if (chance < 40)
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

                if (chance < 25)
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

                if (chance < 80)
                {
                    buy = true;
                }
                else
                {
                    Console.WriteLine("Walked passed");
                }
            }
        }


        public void priceChance()
        {

        }
    }
}
