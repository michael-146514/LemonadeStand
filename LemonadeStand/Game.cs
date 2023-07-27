using System;
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
        public Recipe recipe;

        public void game()
        {
            CreateObjects();
            DisplayWelcomeMessage();
            player.DisplayWallet();
            days();
            
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
            recipe = new Recipe();
        }

        public void days()
        {
            weather.PickWeather();
            player.inventory.displayInventory();
            shop();
            CreateCustomer();
            player.DisplayWallet();
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
            customer = new Customer(weather.weather);
            if(customer.buy == true)
            {
                player.wallet.AcceptMoney(player.recipe.price);
                
            }
        }
    }
}
