// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal sisestada tema vanust
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this App." muul juhul "Welcome to the App!"

Console.WriteLine("Please enter your age, to use this App:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge  = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old."); //userAgeNum");

if(isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome, to the App!");
    }
    else
    {
        Console.WriteLine("You are too young to use this App.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}