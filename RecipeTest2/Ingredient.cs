using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTest2
{
    class Ingredient
    {
        string name;
        float weight;
        float calories;

        public string getName()
        {
            return name;
        }

        public float getWeight()
        {
            return weight;
        }

        public float getCalorie()
        {
            return calories;
        }

        public Ingredient(string name, float weight, float calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }



    }

  
}
