// ex 1

// Console.WriteLine("Enter num A: ");
// string a = Console.ReadLine();
// int num_1 = int.Parse(a);

// Console.WriteLine("Enter num B: ");
// string b = Console.ReadLine();
// int num_2 = int.Parse(b);

// if (num_1 > num_2)
// {
//     Console.WriteLine($"max number = {num_1}");
// }
// else
// {
//     Console.WriteLine($"max number = {num_2}");
// }


// ex 2

Console.WriteLine("Enter three number and I display U the bigest.");
Console.Write("Enter first number: ");
string a = Console.ReadLine();
int num_1 = int.Parse(a);

Console.Write("Enter second number: ");
string b = Console.ReadLine();
int num_2 = int.Parse(b);

Console.Write("Enter therd number: ");
string c = Console.ReadLine();
int num_3 = int.Parse(c);

if (num_1 > num_2 & num_1 > num_3)
{
    Console.WriteLine($"max num = {num_1}");
}

if (num_3 > num_1 & num_3 > num_2)
{
    Console.WriteLine($"max num = {num_3}");
}

if (num_2 > num_1 & num_2 > num_3)
{
    Console.WriteLine($"max num = {num_2}");
}