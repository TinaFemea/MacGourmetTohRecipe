using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacGourmetReader
{
    public class Recipe
    {
        public string recipeName;
        public int recipeID;

        public override string ToString()
        {
            return recipeName;
        }
    }
    
}
