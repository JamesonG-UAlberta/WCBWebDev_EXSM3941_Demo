using System.Linq;

List<string> toSearch = new List<string>()
{
    "Hello, world!",
    "Once upon a time...",
    "Lorem ipsum",
    "Testing testing 123",
    "Some more random data",
    "Execute order 66",
    "42",
    "LINQ is fun, really..."
};

Console.WriteLine(toSearch.Count(theThing => theThing.Length > 15));

OutputList(
    toSearch.Where(x => 
        x.Any(y => 
            char.IsNumber(y)
        )
    ).ToList()
);


void OutputList(List<string> list)
{
    foreach (string thing in list) Console.WriteLine(thing);
}