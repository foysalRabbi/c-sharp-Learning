
using System.Formats.Asn1;
using OOP;

Console.WriteLine("Hello, World!");

//Constructor

var person = new Person(953, "Rabbi");
Console.WriteLine(person.Id);
Console.WriteLine(person.Name);

person.DisplayPersonInfo();

// Method Overloading
var point = new Point(15, 25);
Console.WriteLine($"Initial coordinates: ({point.X}, {point.Y})"); 
point.Move(30, 40);
// Move to new coordinates using another Point object
var newPoint = new Point(50, 60);
point.Move(newPoint);
try
{
	point.Move(null);
}
catch(Exception ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}



////Class Coupling

//var car = new Car();
//car.Name = "BMW";
//car.Move();


// Method overriding in Polymorphism
Drawing circle = new Circle();
Console.WriteLine("Area of Cirecle is : " + circle.Area());

Drawing rectangle = new Rectangle();
Console.WriteLine("Area of Rectangle is : " + rectangle.Area());


// Interface and Polymorphism

// Creating instances of notification channels
var channels = new List<INotificationChannel>
{
	new MailNotification(),
	new SMSNotification()
};

// Injecting the list into the VideoEncoder
var encoder = new VideoEncoder(channels);

// Encoding the video
encoder.Encode();

// Generics: // Creating a Box instance for integers
var intBox = new Box<int>();
intBox.Add(89);
Console.WriteLine("Integar Box contains: " + intBox.GetItem());

var stringBox = new Box<string>();
stringBox.Add("This is foysal rabbi");
Console.WriteLine("Strign Box contains: " + stringBox.GetItem());

var doubleBox = new Box<double>();
doubleBox.Add(78.456);
Console.WriteLine("Double Box contains: " + doubleBox.GetItem());

// List 

var objList = new ListCollection();
objList.Output();

Func<int,int> addition = x => x * x;

Func<int,int, int,int> add = (x, y,z) => x + y + z;
Func<int, int, int> subtract = (x, y) => x - y;
Func<int, int, int> multiply = (x, y) => x * y;
Func<int, int, double> divide = (x, y) => y != 0 ? (double)x / y : double.NaN; // Handling division by zero

// Define two numbers
int num1 = 10;
int num2 = 5;
int num3 = 10;

// Perform operations and display results
Console.WriteLine($"Addition of {num1} = {addition(num1)}");
Console.WriteLine($"Addition of {num1} and {num2} = {add(num1, num2, num3)}");
Console.WriteLine($"Subtraction of {num1} and {num2} = {subtract(num1, num2)}");
Console.WriteLine($"Multiplication of {num1} and {num2} = {multiply(num1, num2)}");
Console.WriteLine($"Division of {num1} by {num2} = {divide(num1, num2)}");

//Linq
//var repository = new BookRepository();
//var books = repository.GetBooks();
var books = new BookRepository().GetBooks();

//var cheapBooks = books.Where(b => b.Price < 20);
//var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);
var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Price);

foreach (var book in cheapBooks)
{
	//Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
	Console.WriteLine(book);
}




