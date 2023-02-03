// С клавиатуры вводится 2 вещественных числа, проверить является ли одного из них, квадратом другого

double a,b;
string s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);

if(a*a==b)
System.Console.WriteLine("b является квадратом a");
if(b*b==a)
System.Console.WriteLine("a является квадратом b");

