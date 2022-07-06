using System.Linq;

//1D Array
//Arrays should be used when sequence matters
/*string[] myFavoriteAnimals = new string[] { "Cat", "Dog", "Pony", "Zebra" };

foreach (string favoriteAnimal in myFavoriteAnimals)
{
    Console.WriteLine(favoriteAnimal);
}*/

//2D Array

/*string[,] students = new string[,] { { "Joe", "25", "Hockey" }, { "Jane", "30" }, { "Ming" } };

Console.WriteLine(students[2,2]);*/

//Lists
//Lists are easier to sort and manipulate versus arrays
/*List<string> favoriteColors = new List<string>();
favoriteColors.Add("Red");
favoriteColors.Add("Blue");
favoriteColors.Add("Green");
favoriteColors.Add("Grey");
favoriteColors.Remove("Grey");

foreach (string item in favoriteColors)
{
    Console.WriteLine(item);
}

Console.WriteLine(favoriteColors[0]);*/

//Dictionaries
//Key-Value pairs
/*Dictionary<string, string> animalSounds = new Dictionary<string, string>();
animalSounds.Add("Dog", "Bark");
animalSounds.Add("Cat", "Meow");
animalSounds.Add("Frog", "Ribbit");
animalSounds.Add("Horse", "Neigh");
animalSounds.Remove("Horse");

foreach (KeyValuePair<string, string> pair in animalSounds)
{
    Console.WriteLine("A " + pair.Key + " makes the sound " + pair.Value);
}*/

//Hashsets
//Unique values only, repeated values are ignored and discarded
/*HashSet<int> uniqueIDs = new HashSet<int>();
uniqueIDs.Add(0);
uniqueIDs.Add(1);
uniqueIDs.Add(2);
uniqueIDs.Add(0);

foreach (int id in uniqueIDs)
{
    Console.WriteLine(id);
}*/

//Queues (First in, First out)
//Enqueue adds to the queue, dequeue removes from the queue, peek looks at the top of the queue
/*Queue<int> orderIDQueue = new Queue<int>();
orderIDQueue.Enqueue(1);
orderIDQueue.Enqueue(2);
orderIDQueue.Enqueue(3);
orderIDQueue.Enqueue(4);
orderIDQueue.Dequeue();
Console.WriteLine(orderIDQueue.Peek());*/

//Stacks (Last in, First out)
//Push adds to the stack, pop removes from the stack, peek looks at the top of the stack
/*Stack<string> pancake = new Stack<string>();
pancake.Push("first pancake");
pancake.Push("second pancake");
pancake.Push("third pancake");
pancake.Push("fourth pancake");
pancake.Pop();
Console.WriteLine(pancake.Peek());*/

//LINQ Method Syntax
//var greaterThanThree = favoriteColors.Where(color => color.Length > 3);
//In the above commented out code, Where is the extension method, (color => color.Length > 3) is the lambda expression

List<string> favoriteColors = new List<string>();
favoriteColors.Add("Red");
favoriteColors.Add("Blue");
favoriteColors.Add("Green");
favoriteColors.Add("Grey");

//LINQ Where
//Returns all values which matches lambda expression
/*var greaterThanThree = favoriteColors.Where(color => color.Length > 3);

foreach (string color in greaterThanThree)
{
    Console.WriteLine(color);
}*/

//LINQ Count
//Returns the number of elements in a data-structure
/*Console.WriteLine(favoriteColors.Count());*/

double[] myNumbers = new double[] { 1, 2, 3.25, 4.5, 500, 0.25, 1000 };

//LINQ Aggregate
//Applies lambda expression to all values in a data-structure
/*int total = myNumbers.Aggregate((current, next) => current + next);
Console.WriteLine(total);*/

//LINQ Average
//Finds the average value over values in a data-structure, returns a double type value. 
/*double average = myNumbers.Average();
Console.WriteLine(average);*/

//LINQ Max
//Finds the highest value number in a data-structure
/*double max = myNumbers.Max();
Console.WriteLine(max);*/

//LINQ Min
//Finds the lowest value number in a data-structure
/*double min = myNumbers.Min();
Console.WriteLine(min);*/

//LINQ Sum
//Finds sum of all elements in a data-structure
/*double sum = myNumbers.Sum();
Console.WriteLine(sum);*/

//LINQ First
//Finds first element in data-structure which matches lambda expression, will cause error if element does not exist
/*double first = myNumbers.First(number => number > 2);
Console.WriteLine(first);*/

//LINQ Last
//Finds last element in data-structure which matches lambda expression, will cause error if element does not exist
/*double last = myNumbers.Last(number => number > 2);
Console.WriteLine(last);*/

int[] myNumbers2 = new int[] { 1 };

//LINQ FirstOrDefault
//Finds first element in data-structure which matches lambda expression, returns default value of 0 or null if element does not exist
/*int firstDefault = myNumbers2.FirstOrDefault(number => number > 2);
Console.WriteLine(firstDefault);*/

//LINQ LastOrDefault
//Finds last element in data-structure which matches lambda expression, returns default value of 0 or null if element does not exist
/*int lastDefault = myNumbers2.LastOrDefault(number => number > 2);
Console.WriteLine(lastDefault);*/

//LINQ ElementAt
//Checks element at index in data-structure, will cause error if element does not exist
/*double elementAt = myNumbers.ElementAt(0);
Console.WriteLine(elementAt);*/

//LINQ ElementAtOrDefault
//Checks element at index in data-structure, returns default value of 0 or null if element does not exist
/*double elementAtDefault = myNumbers.ElementAtOrDefault(100);
Console.WriteLine(elementAtDefault);*/

string[] groceryList = new string[] { "Kraft Dinner", "Steaks", "Pierogies", "Corn", "Beer", "Bread", "Beer", "Butter Chicken" };

//LINQ Distinct
//Effectively turns data-structure into hashset
/*var newGroceryList = groceryList.Distinct();

foreach (string item in newGroceryList)
{
    Console.WriteLine(item);
}*/

//LINQ Any
//Checks if one or more elements in a data-structure matches lambda expression
/*var groceryChecker = groceryList.Any(item => item == "Beer");
Console.WriteLine(groceryChecker);*/

//LINQ All
//Checks if all elements in a data-structure matches lambda expression
var groceryChecker = groceryList.All(item => item == "Beer");
Console.WriteLine(groceryChecker);




