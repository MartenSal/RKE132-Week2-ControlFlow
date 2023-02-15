// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young too use Instagram"
//Muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age:");


string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);


Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} Years old.");

if(isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}
//int userAge = Int32.Parse(Console.ReadLine());
//if(userAge >= 13)
//{
    //Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
   // Console.WriteLine("You are too young to use instagram.");
//}