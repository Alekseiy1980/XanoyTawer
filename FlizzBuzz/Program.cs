//----------------------------
// Василенко Алексей Юрьевич
// игра FizzBuzz
//----------------------------
void FizzBuzz(int x)
{
   for (int i = 1; i <= x; i++)
   {
      if (i % 3 == 0)
      {
         Console.WriteLine("Fizz");
      }
      if (i % 5 == 0)
      {
         Console.WriteLine("Buzz");
      }
      if (i % 3 == 0 || i % 5 == 0)
      {
         Console.WriteLine("FizzBuzz");
      }
   }
}
Console.WriteLine("Игра FizzBuzz");
Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());
FizzBuzz(num);