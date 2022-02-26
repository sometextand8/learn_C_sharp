Console.WriteLine("Enter num A: ");
string a = Console.ReadLine();
int num_1 = int.Parse(a);

Console.WriteLine("Enter num B: ");
string b = Console.ReadLine();
int num_2 = int.Parse(b);

if (num_1 > num_2)
{
    Console.WriteLine($"max number = {num_1}");
}
else
{
    Console.WriteLine($"max number = {num_2}");
}
