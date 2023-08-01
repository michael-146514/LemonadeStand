using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 5;
            price = 1.50;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per Cup\n{numberOfSugarCubes} sugar cubes per Cup\n{numberOfIceCubes} ice cubes per Cup");
        }

        public void setRecipe()
        {
            numberOfLemons = UserInterface.GetNumberOfRecipe("lemons");
            numberOfSugarCubes = UserInterface.GetNumberOfRecipe("Sugar Cubes");
            numberOfIceCubes = UserInterface.GetNumberOfRecipe("Ice Cubes");
        }

        public void setPrice()
        {
            price = UserInterface.GetNumberForPrice(price);
        }
    }
}
