// C клавиатуры вводятся 2 числа. Найти и вывести на экран их сумму.
//string s;
int a,b,sum;
System.Console.WriteLine("Введите а:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите б:");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
// 1. Конкатенация (склеивание) строк
System.Console.WriteLine(a+"+"+b+"="+sum);
//2. Форматированный вывод 
System.Console.WriteLine("{1}+{2}+{3}",a,b,sum);
//3. Интерполяция строк 
System.Console.WriteLine($"{a}+{b}+{sum}");

// C клавиатуры вводятся 2 числа. Найти и вывести на экран максимальное из них

int max;
if (a>b)
{max=a;
}
else 
{
max=b;
}
System.Console.WriteLine($"max={max}");
