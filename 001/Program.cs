// С клавиатуры вводится целое число, вывести квадрат числа

string s;
int a; 

s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.WriteLine(a*a);
Console.WriteLine(Math.Pow(a,2));
