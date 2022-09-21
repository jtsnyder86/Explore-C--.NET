// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is:" + DateTime.Now);
Console.WriteLine(5);


// working on strings
string message1 = "hello";

Console.WriteLine(message1);

// // working on numbers
// // int a = 3;
// // int b = 5;
// // int c = 34;
// // int d = a + b + c;

// // Console.WriteLine(d);

// // WorkWithIntegers();
// OrderPrecedence();

// // int a = 5;
// // int b = 4;
// // int c = 2;
// // int d = a + b * c;
// // Console.WriteLine(d);



// void WorkWithIntegers()
// {
//     int a = 18;
//     int b = 6;
//     int c = a + b;
//     Console.WriteLine(c);


//     // subtraction
//     c = a - b;
//     Console.WriteLine(c);

//     // multiplication
//     c = a * b;
//     Console.WriteLine(c);

//     // division
//     c = a / b;
//     Console.WriteLine(c);
// }

// void OrderPrecedence()
// {
//     int a = 5;
//     int b = 4;
//     int c = 2;
//     int d = a + b * c;
//     Console.WriteLine(d);

//     d = (a + b) * c;
//     Console.WriteLine(d);

//     d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
//     Console.WriteLine(d);

//     int e = 7;
//     int f = 4;
//     int g = 3;
//     int h = (e + f) / g;
//     Console.WriteLine(h);
// }

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

float price = 1.99F;

//arrays
int[] numberArray = {1,2,-4,3};

// numberArray.

string[] stringArray = {"Mitchison", "Ramirez"};

Console.WriteLine("here is my array " + numberArray);

// loop

foreach(string cohort in stringArray) {
    Console.WriteLine(cohort);
    //expressions
}

// .NET gives us a list

List<string> shoeList = new List<string>();
shoeList.Add("Nike");
shoeList.Add("Keds");
shoeList.Add("Crocs");
shoeList.Add("New Balance");
// shoeList[2];

Console.WriteLine(shoeList);
foreach(string shoe in shoeList) {
    Console.WriteLine(shoe);
}

// classes and objects

// make instances of markers (variables)

Marker redMarker = new Marker();
// redMarker.color = "red";
redMarker.changeColor("Red"); // .color is private


Console.WriteLine(redMarker.getColor());

public class Marker
{
    // properties/fields
    public string material;
    private string color {get; set;}
    public int inkLevel = 100;

    // methods/functions

    // allows us to change marker color
    //setter
    public void changeColor(string newColor) {
        if(newColor != null) {
            this.color = newColor;
        }
    }
    //getter
    public string getColor() {
        return this.color;
    }
}
 
