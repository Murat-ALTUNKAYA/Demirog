using Intro.Business;
using Intro.Entities;



string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = false; 
Console.WriteLine(message1);

//condition

if (isAuthenticated)
{
    Console.WriteLine("Button => Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Button => Sisteme giriş yap");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length ; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");

