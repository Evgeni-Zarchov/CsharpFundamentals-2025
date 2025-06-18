int intergerN = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{intergerN} X {times} = {intergerN * times}");
    times++;

} while (times <= 10);