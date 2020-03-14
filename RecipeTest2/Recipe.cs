using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTest2
{
    class Recipe
    {
        string name;
        List<Ingredient> list = new List<Ingredient>();

        public string getRecName()
        {
            return name;
        }

        public void setRecName(string name)
        {
            this.name = name;
        }

        public List<Ingredient> GetIngredients()
        {
            return list;
        }

        //Calculate total number of calories for Recipe
        public float totCal()
        {
            float total = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                total += list[i].getCalorie();
            }

            return total;
        }

        public void addToRecipe ( Ingredient ing)
        {
            list.Add(ing);

        }

        // print recipe
        public void printRecipe()
        {
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i].getName() + "\n");
            }
        }


    }

    
}
