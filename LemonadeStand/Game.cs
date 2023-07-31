﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class Game
    {
        public Player player;
        public Weather weather;
        public Store store;
        public Customer customer;

        public void game()
        {
            CreateObjects();
            DisplayWelcomeMessage();
            player.recipe.DisplayRecipe();
            days(7);
            
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Lemonade Stand :)");
            Console.WriteLine("Your goal is to make as much money you can in 7 days. \nBy selling lemonade! Buy Cups, Lemons, Sugar, and Ice Cubes \nThen set your recipe based on the weather and conditions.\nStart with the basic recipe, but try to vary the recipe and see if you can do better.\nLastly, set your price and sell your lemonade at the stand.");
            Console.WriteLine();
        }

        public void CreateObjects()
        {
            player = new Player();
            weather = new Weather();
            store = new Store();
        }

        public void days(int days)
        {

            for(int i = 1; i <= days; i++)
            {
                Console.WriteLine();
            player.inventory.displayInventory();
                Console.WriteLine();
            weather.PickWeather();
                createRecipe();
            shop();
            CreateCustomer();
            player.DisplayWallet();
            player.inventory.displayInventory();
                player.DisplayProfitOrLoss(store.pricePerLemon, store.pricePerSugarCube, store.pricePerIceCube, store.pricePerCup);
            }
            player.inTotalMade();
        }

        public void shop()
        {
            Console.WriteLine("Would You like to buy stuff from the shop? Enter Yes or No");
            string answer = Console.ReadLine();
            if(answer == "Yes" || answer == "yes")
            {
                Console.WriteLine($"Welcome to the Lemon Shop\n Lemons: ${store.pricePerLemon}\n SugarCubes: {store.pricePerSugarCube}\n IceCubes: {store.pricePerIceCube}\n Cups: {store.pricePerCup}");
               
                player.DisplayWallet();
                store.SellLemons(player);
                player.DisplayWallet();
                store.SellSugarCubes(player);
                player.DisplayWallet();
                store.SellIceCubes(player);
                player.DisplayWallet();
                store.SellCups(player);
            }
        }

        public void CreateCustomer()
        {
            for (int i = 0; i <= 20; i++)
            {
                player.inventory.checkIfSoldOut();
                customer = new Customer(weather.weather);
                customer.soldOut = player.inventory.soldOut;
                customer.CheckIfBuying(weather.weather);
            if(customer.buy == true && player.inventory.soldOut == false)
                  {
                    Console.WriteLine("Buying Lemonade");
                    player.wallet.AcceptMoney(player.recipe.price);
                player.recipeItems();
                    player.Daytotal++;
                  }
            }
        }

        public void createRecipe()
        {
            Console.WriteLine("Would you like to edit the Recipe? Enter Yes or no");
            string yesOrno = Console.ReadLine();

            if(yesOrno == "Yes" || yesOrno == "yes")
            {
                player.recipe.setRecipe();
            }
        }
    }
}
