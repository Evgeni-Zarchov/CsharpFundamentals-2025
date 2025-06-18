string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double avgGrade = double.Parse(Console.ReadLine());

// avg  -> averageGrade
Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avgGrade:f2}");
