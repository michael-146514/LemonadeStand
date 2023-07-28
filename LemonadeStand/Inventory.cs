using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public bool soldOut;



        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            AddLemonsToInventory(0);
            AddSugarCubesToInventory(0);
            AddIceCubesToInventory(0);
            AddCupsToInventory(0);
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
               Cup cup = new Cup();
                cups.Add(cup);
            }
          
        }

        public void displayInventory()
        {
            Console.WriteLine("Inventory - ");
            Console.WriteLine($"Lemons: {lemons.Count}");
            Console.WriteLine($"Sugar Cubes: {sugarCubes.Count}");
            Console.WriteLine($"IceCubes: {iceCubes.Count}");
            Console.WriteLine($"Cups: {cups.Count}");
        }


        //Remove Items from Inventory
        public void RemoveCupToInventory(int numberOfCups)
        {
            try
            {
                for (int i = 0; i < numberOfCups; i++)
                 {

                cups.RemoveAt(cups.Count - 1);
                 }
            }
            catch
            {
                Console.WriteLine("Ran out of Cups, Sold Out");
                soldOut = true;
            }
           
        }

        public void RemoveIceCubesToInventory(int numberOfIceCubes)
        {
            try
            {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                // iceCubes.Remove(1);
                iceCubes.RemoveAt(iceCubes.Count - 1);
            }
            }
            catch
            {
                Console.WriteLine("Ran out of IceCubes, Sold Out");
                soldOut = true;
            }

           
        }

        public void RemoveSugarCubesToInventory(int numberOfSugarCubes)
        {
           
                try
                {
                  for (int i = 0; i < numberOfSugarCubes; i++)
                  {
                  sugarCubes.RemoveAt(sugarCubes.Count - 1);
                  }
        
                }
                catch
                {
                    Console.WriteLine("Ran out of ice, Sold Out");
                 soldOut = true;
            }
            }
       

        public void RemoveLemonsToInventory(int numberOfLemons)
        {
            try
            {
                for (int i = 0; i < numberOfLemons; i++)
                 {
                lemons.RemoveAt(lemons.Count - 1);
                 }
            }
            catch
            {
                Console.WriteLine("Sold out of Lemons, Sold Out");
                soldOut = true;
            }
            
        }

       public void checkIfSoldOut()
        {
            if (lemons.Count == 0 || sugarCubes.Count == 0 || iceCubes.Count == 0 || cups.Count == 0)
            {
                soldOut = true;
            }
            else
            {
                soldOut = false;
            }

        }
    }
}
