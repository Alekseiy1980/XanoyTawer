
Console.WriteLine("Калькулятор v 1.0");
double number;
double result;
double number2;
char znak;
bool flag = true;

number = Convert.ToDouble(Console.Read());

while (flag)
{

   znak = Convert.ToChar(Console.Read());
   if (znak == '+')
   {
      number2 = Convert.ToDouble(Console.Read());
      number += number2;
   }
   else if (znak == '-')
   {
      number2 = Convert.ToDouble(Console.Read());
      number -= number2;
   }
   else if (znak == '*')
   {
      number2 = Convert.ToDouble(Console.Read());
      number *= number2;
   }
   else if (znak == '/')
   {
      number2 = Convert.ToDouble(Console.Read());
      number /= number2;
   }
   else if (znak == '=')
   {
      flag = false;
   }
}
Console.WriteLine(number);