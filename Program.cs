/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab6
 * 	Project name: Programs
 *--------------------------------------------------------------------
 * Author’s name and email:	 Kelsey Blevins; blevinskl2@etsu.edu			
 *          Course-Section: CSCI 1250-002
 *           Creation Date:	 March 24, 2022		
 * -------------------------------------------------------------------
 */


////////////////////////////
/// Calling the Methods ///
////////////////////////////

///Show Character///
Console.WriteLine("Enter a word: \n");
var word = Console.ReadLine();

Console.WriteLine("Enter a the position you want to find the character: \n");
int character = Convert.ToInt32(Console.ReadLine());

//*
///Retail Price///
Console.WriteLine("Enter your item's wholesale cost: \n");
double wholesaleCost = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter its markup percentage (in decimal form): \n");
double markupPercentage = Convert.ToDouble(Console.ReadLine());

CalculateRetail(wholesaleCost, markupPercentage);

///Temperature Table///
Console.WriteLine("Enter your Fahrenheit degree: \n");
double fahrenheitDegree = Convert.ToDouble(Console.ReadLine());

Celcius(fahrenheitDegree);

///Prime Numbers///
System.Console.WriteLine("How many iterations do you want?: \n");
int num = Convert.ToInt32(Console.ReadLine());

IsPrime(num);

/////////////////////
///Method Writing///
/////////////////////

///Show Character///
ShowCharacter(word, character);

static void ShowCharacter(string str, int character)
{

    Console.WriteLine($"The character in the word {str} is {str.ToUpper()[character-1]}");
}

///Retail Price///
static void CalculateRetail(double cost, double percentage)
{
    
    
    // 10
    // 50%
    // rp = 10 + (10 * 50%)
    //      = 10 + (10 * .50)
    //      = 10 + 5
    //      = 15
    double retailPrice = cost + (cost * (percentage/100));

    Console.WriteLine($"The retail price is ${retailPrice}!");
}

///Temperature Table///
static void Celcius(double farhenheit, double celcius = 0.0)
{
    ///equation c = 5/9 (F-32)///
     celcius = 5 * (farhenheit - 32) / 9;

Console.WriteLine($"Celcius: \t {celcius}°C");
}

///Prime Numbers///

static void IsPrime(int num)
{  
    for(num = 1; num <= 50; num++)
    {
        if(IsPrime2(num))
        {
            System.Console.WriteLine($"{num} is prime.");
        }else
        {
            System.Console.WriteLine($"{num} is not a prime.");
        }
    }
}  

static bool IsPrime2(int num)
{
    for(int i = 2; i < num; i++)
    {
        if(num % i == 0)
        {
            return false;
        
        }
    }
    return true;
}
