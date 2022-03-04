ex_1

Console.Write("enter num: ");
string num1 = Console.ReadLine();
int result = int.Parse(num1);

int lastNum(int num)
{
    int q = num % 10;
    return q;
}

Console.WriteLine(lastNum(result));

ex_2

Random rnd = new Random();

int value = rnd.Next(99, 999);
Console.WriteLine(value);

int a = value / 100;
int b = value % 10;

Console.Write(a);
Console.Write(b);

ex_3

Console.WriteLine("enetr num: ");
string some = Console.ReadLine();

int len = some.Length;
int min = 3;

if (len >= min)
{
    char ans = some[2];
    Console.WriteLine($"you enter - {some}, last digit - {ans}"); 
}

else
{
    Console.WriteLine("Третей цифры нет.");
}


ex_4

Console.Write("Введите цифру дня недели: ");
string temp = Console.ReadLine();
int fromUser = int.Parse(temp);

if (fromUser == 6 | fromUser == 7)
{
  Console.WriteLine("yes");
}
else
{
  if (fromUser <= 5)
  {
    Console.WriteLine("no");
  }
  else
  {
    Console.WriteLine("In a week are 6 days");
  }
}
