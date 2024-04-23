// See https://aka.ms/new-console-template for more information
//Rakendus käsib kasutajal sisestada vanuse
//Kui kasutaja sisestab vanuse noorema kui 13, siis kuvatakse konsoolis:
//"You are too young to use Instagram"
//muul juhul
//Konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int userAgeNum = 0;
//boolean = true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); //"13"-heap,13-stack

Console.WriteLine($"Parse result{isAgeNumber} . User is {userAgeNum} years old.");


if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }

    else
    {
        Console.WriteLine("You are too young to use instagram!");
    }


}

else
{
    Console.WriteLine("Could not read your age");
}



//if (userAge >= 13)

// Console.WriteLine("Welcome to Instagram!");

//else //if (userAge<13)

//Console.WriteLine("You are too young to use instagram!");