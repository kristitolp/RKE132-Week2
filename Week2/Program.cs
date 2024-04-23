// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Rakendus küsib kasutaja sugu
//Ranekdus küsib kasutaja perekonnanime
// Rakendus tervitab kasutajat järgmiselt:
// "Welcome Mr. [kasutaja perekonnanimi]" / "welcome, Ms. [kasutaja perekonnanimi]"
Console.WriteLine("Please select your gender(m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb consoolist andmeid string ehk sõne formaadis

Console.WriteLine("Please Enter your lastname");

string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
}
else
{
    Console.WriteLine($"Welcome {userLastName} ! ");
}   