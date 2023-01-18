// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);


// INT and LONG are both whole numbers
// int
int myNum = 10000; // Stores whole numbers from -2,147,483,648 to 2,147,483,647
Console.WriteLine(myNum);

// long
long myLong = 9999999999999999; // Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
Console.WriteLine(myLong);


// FLOAT and DOUBLE are both used for fractions (DOUBLE is better used for calculations due to number of digits)
// float
float myFloat = 99.1132F; //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
Console.WriteLine(myFloat);

// double
double myDouble = 76E7D; //Stores fractional numbers. Sufficient for storing 15 decimal digits
Console.WriteLine(myDouble);

// boolean
bool myBool = true;
Console.WriteLine(myBool);

// single character
char myChar = 'A'; // Stores a single character/letter, surrounded by single quotes
Console.WriteLine(myChar);

string myString = "Word up home slice";
Console.WriteLine(myString);

if (!myBool) {
    Console.WriteLine("myBool if is true");
} else {
    Console.WriteLine("in else of myBool");
};

// ternary, notice the parenthesis around the condition being evaluated only
string result = (myBool) ? "my bool true" : "myBool false";
Console.WriteLine(result);

//  switch statement
switch (myNum) {
    case (< 100000):
        Console.WriteLine("Number is less than 100,000");
        break;
    case (> 100000):
        Console.WriteLine("Number is greater than 100,000");
        break;
    default:
        Console.WriteLine("Number is exactly 100,000");
        break;
};


// array of strings
string[] cars = {"ford", "honda", "chevy", "chrysler"};
Console.WriteLine(cars[0]);

// loop through array and log each, standard for loop
for (int i = 0; i < cars.Length; i++) {
    Console.WriteLine("in for loop: " + cars[i]);
};

// foreach loop on same array
foreach (string car in cars ) {
    Console.Write("foreach: " + car + ", ");
};

// using Lists, must declare List than type List<T>
List<int> primeNumbers = new List<int>() {1, 2, 3, 3, 3, 4, 5};
primeNumbers.ForEach(num => Console.Write(num + ", "));



// loops through a list and checks for a particular value, then returns it to results
var resultTwo = from num in primeNumbers
                    where num == 3
                    select num;

// Console writes each found value
foreach (var num in resultTwo) Console.WriteLine("number selected: " + num);


// grabbing this from the BankAccount class

var account = new BankAccount("Josh", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner}");

account.MakeDeposit(500, DateTime.Now, "Sold stuff");
Console.WriteLine(account.Balance);