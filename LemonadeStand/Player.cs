﻿using System;
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

    }
}
