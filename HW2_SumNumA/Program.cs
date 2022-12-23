// написать метод, который вычисляет
// сумму цифр в числе A
Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());

int GetSunNumA()
{
  int SunNumA = 0;
  while (num > 0)
  {
    SunNumA = SunNumA + num % 10;
    num /= 10;
  }
  return SunNumA;
}
Console.WriteLine(GetSunNumA());
