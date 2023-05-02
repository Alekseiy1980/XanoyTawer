decimal Vklad(decimal x, int m)
{
   decimal vklad = 0;
   for (int i = 0; i < m; i++)
   {
      vklad += x / 100 * 7;
   }
   return vklad;
}

Console.WriteLine("Программа считает ежемесячно проценты от суммы вклада");
decimal vklad = 0;
int message = 0;
do
{
   Console.Write("Введите сумму вклада -> ");
   vklad = Convert.ToDecimal(Console.ReadLine());
} while (vklad <= 0);
do
{
   Console.Write("Введите колличество месяцев -> ");
   message = Convert.ToInt32(Console.ReadLine());
} while (message <= 0);
decimal pro_vklad = Vklad(vklad, message);
Console.WriteLine($"Вы внесли {vklad} руб. на {message} мес. и по истечению срока вы получили средств {pro_vklad + vklad} руб. и тем самым заработали {pro_vklad} руб. ");