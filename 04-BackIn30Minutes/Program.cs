int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 30;

if (minutes > 59)
{
    hours += 1;
    minutes %= 60;
}

if (hours > 23)
{
    hours = 0;
}

// The format can be with d2, but i not want to copy
if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}


