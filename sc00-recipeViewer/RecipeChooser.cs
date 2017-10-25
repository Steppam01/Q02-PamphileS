using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;

namespace sc00_recipeViewer
{
    class RecipeChooser
    {
        //Dictionary to store recipe instructions
        private Dictionary<string, string> instructions = new Dictionary<string, string>()
        {
            {"Pancakes", "1. Combine milk with vinegar in a medium bowl and set aside for 5 minutes to \"sour\". \n" + 
                         "2. Combine flour, sugar, baking powder, baking soda, and salt in a large mixing bowl. Whisk egg and butter into " +
                         "\"soured\" milk. Pour the flour mixture into the wet ingredients and whisk until lumps are gone. \n" +
                         "3. Heat a large skillet over medium heat, and coat with cooking spray. Pour 1/4 cupfuls of batter onto the " +
                         "skillet, and cook until bubbles appear on the surface. Flip with a spatula, and cook until browned on the other " +
                "        side."},
            {"Chicken Fingers", "1. Preheat oven to 400 degrees F (200 degrees C). \n" +
                                "2. Mix egg beat and milk in a shallow dish or bowl; place crushed chips in a separate shallow dish or " +
                                "bowl.Dip chicken first in egg mixture, then in crushed chips to coat. Place coated chicken on an " +
                                "ungreased cookie sheet. \n" + 
                                "3. Bake in preheated oven for 10 minutes; turn sides and bake for another 10 minutes."},
            {"Oreo Cake", "1. Heat oven to 350 degrees F. \n" + 
                          "2. Prepare cake batter and bake in 2 (9-inch) round pans as directed on package. Cool cakes in pans 10 min. " +
                          "Invert onto wire racks; gently remove pans.Cool cakes completely. \n" +
                          "3. Microwave chocolate and butter in small microwaveable bowl on HIGH 2 min.or until butter is melted.Stir " +
                          "until chocolate is completely melted.Cool 5 min.Meanwhile, beat cream cheese and sugar in large bowl with mixer " +
                          "until blended. Gently stir in COOL WHIP and crushed cookies."}
        };

        //Retrieving recipes
        public String getInstructions(string dish)
        {
            return instructions[dish];
        }
    }
}