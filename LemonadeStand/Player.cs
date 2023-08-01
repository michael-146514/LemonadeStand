using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public double profitOrLoss;
        public double totalMade;
        public double Daytotal;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        public void DisplayWallet()
        {
            Console.WriteLine($"You have ${wallet.Money}");
           
        }

      
        public void recipeItems()
        {
            inventory.RemoveCupToInventory(1);
            inventory.RemoveIceCubesToInventory(recipe.numberOfIceCubes);
            inventory.RemoveLemonsToInventory(recipe.numberOfLemons);
            inventory.RemoveSugarCubesToInventory(recipe.numberOfSugarCubes);
        }

        public void DisplayProfitOrLoss(double lemon, double sugarCube, double icecube, double cup)
        {
            lemon = lemon * recipe.numberOfLemons;
            sugarCube = sugarCube * recipe.numberOfSugarCubes;
            icecube = icecube * recipe.numberOfIceCubes;
            cup = cup * 1;

            double total = lemon + sugarCube + icecube + cup;
            profitOrLoss = recipe.price - total;
            Daytotal = profitOrLoss * Daytotal;
            totalMade = profitOrLoss * Daytotal;

            Console.WriteLine($"Profit of selling one Cup of lemonade is ${profitOrLoss}, In total you made ${Daytotal} in a day");
            Daytotal = 0;
        }

        public void inTotalMade()
        {
            Console.WriteLine($"You made ${totalMade} in 7 days!!!");
        }
    }
}
