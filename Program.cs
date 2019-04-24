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
            // string foodItem = "Taco Salad";

            // Declare an integer variable to hold how many of them we have
            // int numberOfTacoSalads = 3;

            // Declare a double variable to hold the price
            // double priceOfTacoSalad = 3.50;

            // Print the sentence to the console.
            // Console.WriteLine($"We have {numberOfTacoSalads} {foodItem}s for ${priceOfTacoSalad}.");

            // // 1. In the `Main` method of your `Program.cs` file, create variables to hold the following data:
            // // - The name of the taco shop (a string)
            // string name = "Jordan's Taco Shop";

            // // - The address of the taco shop (a string)
            // string address = "123 Sesame Street";
            // // - The monthly operating budget (a double)
            // double budget = 100.00;
            // // - Whether the taco shop is currently open (a boolean)
            // bool isOpen= false;
            // // - The number of employees at the taco shop (an integer)
            // int numberOfEmployees = 5;
            // // - The number of items on the menu of the taco shop (an integer)
            // int itemsOnMenu = 15;
            // // 2. Create a sentence about the taco shop using at least three of the variables you just created.
            // string tacoShopSentence = $"{name} is at {address} and has a budget of {budget}.";
            // Console.WriteLine(tacoShopSentence);
            // // 3. Print your sentence to your terminal.
            // // 4. Example output: "Jordan's Awesome Taco Shop is located at 45 Taco Road and has 10 employees".



            // --------- CONDITIONALS ----------- //

            // If/else conditions work a lot like JavaScript. Let's check to see if the price is more than $10.
            // int costOfTaco = 11;


            // if(costOfTaco > 10){
            //     Console.WriteLine("Too expensive!");
            // } else if (costOfTaco >= 5 && costOfTaco <= 9){
            //     Console.WriteLine("Just the right price!");
            // } else {
            //     Console.WriteLine("Too cheap");
            // }

            // Fun fact: they also have ternary statements in C#

            // string howMuchIsTheTaco = costOfTaco > 10 ? "Too expensive!" : "So cheap let's buy it";

            // Console.WriteLine(howMuchIsTheTaco);

            // --------- COLLECTIONS AND LOOPS ----------- //


            // Define a list of strings. Each string should represent a food item at the grocery store
            // List<string> foodItems = new List<string>(){
            //     "Apples",
            //     "Ketchup",
            //     "Salt"
            // };

            // foodItems.Add("Watermelon");
            // foodItems.Add("Beef");
            // foodItems.Add("Meatloaf");



            // foreach(string singleFood in foodItems){
            //     if(singleFood == "Meatloaf"){
            //         Console.WriteLine("Shred it");
            //     } else {
            //         Console.WriteLine("Do not shred it.");
            //     }
            //     // Console.WriteLine(singleFood);
            // }

            //  Lightning Exercise Three: Loopin'
            // 1. Create a list of strings. Each string should represent an employee at the taco shop. Add your own name in there somewhere.
            List<string> employees = new List<string>(){
                "Charles",
                "Matt",
                "Nikki",
                "Sable",
                "Jordan"
            };
            // 2. Loop through the list of names and print each one to the console.
            foreach (string singleEmployee in employees)
            {
                if (singleEmployee == "Jordan")
                {
                    Console.WriteLine($"{singleEmployee} is a very good employee");
                }
                else
                {
                    Console.WriteLine($"{singleEmployee} is also a good employee!");
                }
                // Console.WriteLine(singleEmployee);
            }



            // ---------- LISTS AND LIST METHODS -------------------------//

            // Remove something from the list
            Console.WriteLine(employees.Count);
            employees.Remove("Jordan");
            Console.WriteLine(employees.Count);

            // Find something in the list
            string employeeOfTheMonth = employees.Find(employee => employee == "Taco");

            Console.WriteLine(employeeOfTheMonth);



            // Use .Contains
            if (employees.Contains("Benjamin"))
            {
                Console.WriteLine("This team has the employee of the month on it!");
            }
            else
            {
                Console.WriteLine("No employee of the month for you!");
            }


            // Print everything in our store's inventory to the console with a .ForEach loop
            employees.ForEach(e => Console.WriteLine(e));


            // -------------- DICTIONARIES ---------------------//

            // Create a new dictionary to represent foods at the grocery store. This time, we'll keep track of the food item's name and price
            // const groceryStore = {
            //     "kiwi": 1.99,
            //     "burrito": 4.99
            // }

            Dictionary<string, double> groceryStore = new Dictionary<string, double>(){
                {"Beef", 9.99},
                {"Ketchup", 2.99}
            };

            groceryStore.Add("kiwi", 1.99);
            groceryStore.Add("burrito", 4.99);


            Console.WriteLine(groceryStore["Beef"]);

            foreach (KeyValuePair<string, double> groceryItem in groceryStore)
            {
                Console.WriteLine($"{groceryItem.Key} costs {groceryItem.Value}");
            }


            //  Lightning Exercise Five: Dictionaries

            // 1. Create a dictionary to represent the menu at the taco shop. Each KeyValuePair in the dictionary should have a key of a string that represents the name of the menu item and a value that represents its price (double).
              Dictionary<string, double> menuItems = new Dictionary<string, double>(){
                {"Fish Tacos", 6.99},
                {"Chicken Tacos", 4.99},
                {"Beef Tacos", 8.99},
                {"Shrimp Tacos", 7.99}
            };
            // 2. Create a dictionary to represent the employees at the taco shop. Each KeyValuePair should have a key of a string that represents the employee's name and a value of a string that represents their favorite menu item.
               Dictionary<string, string> tacoShopEmployees = new Dictionary<string, string>(){
                {"Haley", "Fish Tacos"},
                {"James", "Chicken Tacos"},
                {"Sally", "Beef Tacos"},
                {"Kim", "Shrimp Tacos"}

            };
            // 3. Loop over the dictionary of employees. For each employee, print their favorite menu item and it's price. Example output: "Jenny's favorite dish is fish tacos for only $6.99"

            foreach(KeyValuePair<string, string> singleEmployee in tacoShopEmployees){
                string name = singleEmployee.Key;
                string favoriteFood = singleEmployee.Value;
                double price = menuItems[favoriteFood];
                Console.WriteLine($"{name}'s favorite food is {favoriteFood} and it costs {price}.");
            }


            // ----------------- SETS ----------------------//

            // A hashset is a collection of unique items. You use a HashSet when you want to store an unordered collection of items.
            List<int> testScores = new List<int>(){
                99,
                99,
                100,
                60,
                60,
                60,
                100
            };

            HashSet<int> uniqueScores = new HashSet<int>();

            Console.WriteLine("Here are allllll the scores:");
            foreach(int score in testScores){
                uniqueScores.Add(score);
            }

            Console.WriteLine("Here are the unique scores:");

            foreach(int score in uniqueScores){
                Console.WriteLine(score);
            }

            uniqueScores.Add(100);
            // Create a hashset to represent types of produce at the grocery store

            // Try to add the same type of produce twice. It won't work!

        }
    }
}
