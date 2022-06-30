
// ---
// Arrays
// ---
// Arrays are very rigid. They have fixed physical sizes and require more mental math to work with in most cases.

int[] myIntegerArray = new int[10];
int myIntergerArrayLogical = 0;

// Sets the next item in the arrays and updates logical size.
myIntegerArray[myIntergerArrayLogical++] = 10;
myIntegerArray[myIntergerArrayLogical++] = 15;
myIntegerArray[myIntergerArrayLogical++] = 25;

// Removes the last item in the array and updates logical size.
myIntegerArray[--myIntergerArrayLogical] = 0;


string[,] myTwoDArray = new string[5, 5];


// ---
// Lists
// ---
// Lists are more similar to JS arrays, with add/remove/etc methods to manage the math for you.

List<string> myList = new List<string>();

myList.Add("Hello");

// ---
// Dictionaries
// ---
// Dictionaries are like lists, but can be indexed by things other than integers.

Dictionary<string, string> myDictionary = new Dictionary<string, string>();

myDictionary.Add("first", "Hello, World!");

Console.WriteLine(myDictionary["first"]);

// ---
// HashSets
// ---
// HashSets are like lists, but everything in them must be unique. They function much faster than lists do in most cases.

HashSet<double> myHashset = new HashSet<double>();

myHashset.Add(3.14);
myHashset.Add(1.21);
myHashset.Add(10.12);
myHashset.Add(1.21); // Adds nothing, as it already exists.

// ---
// Queues and Stacks
// ---
// Queues function on a first in, first out basis (like a lineup at a grocery store).
// Stacks function on a first in, last out basis (like a stack of paper).

Queue<int> myQueue = new Queue<int>();
Stack<int> myStack = new Stack<int>();

myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);

myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

Console.WriteLine(myQueue.Dequeue()); // 1
Console.WriteLine(myStack.Pop()); // 3





Console.ReadLine();