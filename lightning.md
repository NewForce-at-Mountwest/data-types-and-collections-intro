Lightning Exercise One: Data Types

In your console application, we're going to keep track of some information about a taco shop.

1. In the `Main` method of your `Program.cs` file, create variables to hold the following data:
- The name of the taco shop (a string)
- The address of the taco shop (a string)
- The monthly operating budget (a double)
- Whether the taco shop is currently open (a boolean)
- The number of employees at the taco shop (an integer)
- The number of items on the menu of the taco shop (an integer)
2. Create a sentence about the taco shop using at least three of the variables you just created.
3. Print your sentence to your terminal.
4. Example output: "Jordan's Awesome Taco Shop is located at 45 Taco Road and has 10 employees".


Lightning Exercise Two: Conditionals
1. Use an if /else statement to check to see if the taco restaurant is open. If so, print "Let's gooooo" to the console. If not, print "gosh darn".
2. Write a conditional to check the number of employees at the taco shop.
- If the number is between 0 and 4, print "This business is very tiny".
- If the number is betwene 5 and 9, print "This business is still pretty small"
- If the number is between 10 and 14, print "This is a small business"
- If the number is between 15 and 19, print "This is a medium sized business"
- If the number is over 20, print "THIS BUSINESS IS HUGE"


Lightning Exercise Three: Loopin'
1. Create a list of strings. Each string should represent an employee at the taco shop. Add your own name in there somewhere.
2. Loop through the list of names and print each one to the console.
3. Add a conditional to your loop that checks to see if the current name is your name. If so, print "[Your name here] is the best employee ever!!!" If not, print "[Someone else's name] is a so-so employee."

Lightning Exercise Four: Lists Methods

1. Use .Add() to add another employee to your list of employees
2. Use .Insert() to add a new employee to the end of the list.
3. Create a new list of strings to represent the names of customers at the taco shop.
4. Use .Find() to extract a customer named "Kim", if one exists, from your list of customers.
5. Kim was a customer at the taco shop, but they've decided to hire her. Use .Remove() to remove her from the customers list and add her to the employees list.
6. How many customers does the taco shop have?
7. The taco shop would like to see a list of everyone who's in the store regularly, both customers and employees. Use .AddRange() to combine the list of customers and employees and then use a .ForEach() loop print the newly combined list to the console.


Lightning Exercise Five: Dictionaries
1. Create a dictionary to represent the menu at the taco shop. Each KeyValuePair in the dictionary should have a key of a string that represents the name of the menu item and a value that represents its price (double).
2. Create a dictionary to represent the employees at the taco shop. Each KeyValuePair should have a key of a string that represents the employee's name and a value of a string that represents their favorite menu item.
3. Loop over the dictionary of employees. For each employee, print their favorite menu item and it's price. Example output: "Jenny's favorite dish is fish tacos for only $6.99"

Lightning Exercise Six: HashSets
1. The taco shop has generated a report of their top selling menu items. Unfortunately, the report gives them a line item for every time they've sold that item, when they really just want a consolidated list of their top sellers. They don't care what order it's in. The following list represents the individual sales for their top selling menu items:

```C#

List<string> salesReport = new List<string>(){
    "Fish Tacos",
    "Buffalo Chicken Tacos",
    "Bean and Cheese Tacos",
    "Fish Tacos",
    "Spciy Beef Tacos",
    "Buffalo Chicken Tacos",
    "Buffalo Chicken Tacos",
    "Fish Tacos",
    "Bean and Cheese Tacos",
    "Fish Tacos",
    "Spciy Beef Tacos",
    "Bean and Cheese Tacos",
    "Spicy Beef Tacos"
}
```
2. Create a new HashSet called `topSellers`
3. Loop over the `salesReport` list and add each item to `topSellers`.
4. Print each item in the `topSellers` HashSet to the console.


```C#


```


