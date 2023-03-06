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