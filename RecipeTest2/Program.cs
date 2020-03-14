using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTest2
{
    class Program
    {
        static bool running = true;

        List<Recipe> recipeList = new List<Recipe>();

        public void showMenu()
        {
            
            Console.WriteLine("What would you like to do? 1.Add Recipe 2.View Recipes 3.Quit ? ");
      
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                addRecipe();
            }
            if (choice == "2")
            {
                printRecipes();
                
            }
            if (choice == "3")
            {
                running = false;
            }

        }

        public void printRecipes()
        {
            Console.WriteLine("The recipes stored are: ");
            for (int i =0; i < recipeList.Count(); i ++)
            {
                Console.WriteLine(recipeList[i].getRecName());
            }
        }

        public void addRecipe()
        {

            Recipe temp = new Recipe();

            Console.WriteLine("What is the recipe name?");

            string tempRecName = Console.ReadLine();
            temp.setRecName(tempRecName);

            Console.WriteLine("How many Ingredients are there? ");
            int num = 0;
            string tempnum = Console.ReadLine();

            num = int.Parse(tempnum);
            int count = 1;

            while (count <= num)
            {

                Console.WriteLine("Okay so what is the {0} ingredient of {1} ?", count, temp.getRecName());

                // Save name into a temp string
                string tempName = Console.ReadLine();

                Console.WriteLine("What is the weight of {0} ?", tempName);
                // Save weight into a temp string
                // Convert to number if you wanna, store that in a temp variable
                string tempweight = Console.ReadLine();

                float tWeight = float.Parse(tempweight);

                Console.WriteLine("How many calories in {0} ? ", tempName);
                // Save calories into a temp string
                // Convert to number if you wanna, store that in a temp variable
                string tempcalories = Console.ReadLine();
                float tCalories = float.Parse(tempcalories);

                Console.WriteLine("So far I have: \n{0} weighs {1} and has {2} calories \nCorrect Y/N ?", tempName, tWeight, tCalories);
                string answer = Console.ReadLine();

                string newanswer = answer.ToUpper();

                if (newanswer == "Y")
                {

                    // addToRecipe(Recipe recipe, Ingredient ingredient);
                    // addToRecipe(temp, new Ingredient(tempName,  tempWeight, tempCalories)
                    temp.addToRecipe(new Ingredient(tempName, tWeight, tCalories));

                    Console.WriteLine("So far your total calories are: ");
                    float total = temp.totCal();
                    Console.WriteLine(total);
                    Console.WriteLine("The recipe contains: \n");

                    temp.printRecipe();


                }
                if (newanswer == "N")
                {
                    Console.WriteLine("Let's start over");
                    count = 0;

                }

                count++;
            }

            recipeList.Add(temp);
            Console.Write("The Recipe {0} has been stored!", temp.getRecName());
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Program program = new Program();

            Console.WriteLine("Welcome to Recipe Calculator !");
            Console.ReadLine();

            while (running)
            {
                program.showMenu();
            }
       



        }
    }
}
