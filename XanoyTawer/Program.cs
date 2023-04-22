void Print(int[] arr, int[] arr2, int[] arr3)
{
   int counter = arr.Length * 3 + 6;
   int kol = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      kol = arr[i];
      for (int j = 0; j < kol + kol; j++)
      {
         Console.Write("*");
      }
      Console.WriteLine();
   }
}

int MaxKol(int max, int tmp, int min)
{
   return Math.Max(max, Math.Max(tmp, min));
}

int MinKol(int max, int tmp, int min)
{
   return Math.Min(max, Math.Min(tmp, min));
}
int size = 5;
int j = 3;
int tawerIn = 0;
int tawerOut = 0;
int[] Tawer1 = new int[size];
int[] Tawer2 = new int[size];
int[] Tawer3 = new int[size];
int[] Tmp = new int[size];

for (int i = 0; i < size; i++)
{
   Tawer1[i] = i + 3;
   Tmp[i] = Tawer1[i];
}
Tawer2[0] = 5;
Tawer3[0] = 10;
// Print(Tawer1);
int max = MaxKol(Tawer1[0], Tawer2[0], Tawer3[0]);
int min = MinKol(Tawer1[0], Tawer2[0], Tawer3[0]);

if (max == Tawer1[0]) { tawerIn = 1; }
if (max == Tawer2[0]) { tawerIn = 2; }
if (max == Tawer3[0]) { tawerIn = 3; }

if (min == Tawer1[0]) { tawerOut = 1; }
if (min == Tawer2[0]) { tawerOut = 2; }
if (min == Tawer3[0]) { tawerOut = 3; }