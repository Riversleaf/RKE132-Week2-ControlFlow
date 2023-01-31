// See https://aka.ms/new-console-template for more information

//rakendus küsib kaasutajal siestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter Your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read Your age.");
}

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
//else //if (userAge < 13)
//{
//    Console.WriteLine("You are too young to use Instagram.");
//}