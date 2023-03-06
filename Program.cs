Console.Write("Enter your name: ");
string name =Console.ReadLine();
string greeting=$"Hello,{name}";
Console.WriteLine(greeting);

Console.Write("Enter your age : ");
string ageasString=Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageasString);
int KeschAge=2;
Console.WriteLine($"Difference year {age-KeschAge}");
// >,>=, <,<=,==,!=

Console.WriteLine($"Your age are older than Kescha {age>KeschAge}");
Console.WriteLine($"Your age are younger than Kescha {age<KeschAge}");
Console.WriteLine($"Your age are equal to Kescha {age==KeschAge}");
