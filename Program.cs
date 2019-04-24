// The using directives give us access to .NET's pre-defined types, like strings and integers 
using System;
using System.Collections.Generic;


// Namespaces organize and provide a levels of seperation in your C# apps. They're like containers that can have other namespaces, classes, etc inside them.
namespace intro
{
    // In C#, a class is like a blueprint of specific object.
    // This specific class doesn't have to be called Program- that's just convention
    // Classes can have properties and methods, just like JS Objects
    class Program
    {

        // Every console app is going to have one and only one method called Main, which will the the entry point for the app. The Main method can call other methods and/ or execute its own logic
        static void Main(string[] args)
        {

            // --------- DATA TYPES ----------- // 
            // We're going to build a sentence about a grocery store

            // Declare a string variable to hold the name of a food item

            // Declare an integer variable to hold how many of them we have

            // Declare a double variable to hold the price


            // Print the sentence to the console. 



            // --------- CONDITIONALS ----------- // 

            // If/else conditions work a lot like JavaScript. Let's check to see if the price is more than $10.
          

            // Fun fact: they also have ternary statements in C# 
         
            // --------- COLLECTIONS AND LOOPS ----------- // 

           
            // Define a list of strings. Each string should represent a food item at the grocery store
            List<string> foodItems = new List<string>();

            // Print one food item by its index (just like arrays in JS!)

            // Print each food item to the console with a loop

            // Add a conditional to the loop- if the item is "taco", print "HECK YEAH" to the console. If not, print "this would be better if it were a taco" to the console. 
    

            // ---------- LISTS AND LIST METHODS -------------------------//
       
            // Remove something from the list

            // Find something in the list

            // Check to see if the list contains both "hot dogs" and "ketchup". If so, print "all set for our cookout!" to the console. If not, print "no cookout for you". 

            // Use .Count figure out how many items are in the store's inventory. 

            // Print everything in our store's inventory to the console with a .ForEach loop 


            // -------------- DICTIONARIES ---------------------//

            // Create a new dictionary to represent foods at the grocery store. This time, we'll keep track of the food item's name and price

            // Add something to the dictionary

            // Iterate over the dictionary 

            // Use bracket notation to access something inside a dictionary by its key 

            
            // ----------------- SETS ----------------------//

        // A hashset is a collection of unique items. You use a HashSet when you want to store an unordered collection of items. 

        // Create a hashset to represent types of produce at the grocery store

        // Try to add the same type of produce twice. It won't work!
            Console.WriteLine("Hello world!");
        }
    }
}
