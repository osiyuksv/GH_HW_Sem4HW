// написать метод, который возвотит
// число A в натуральную степень B
Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

double GetApowB()
{
  double numApowB = Math.Pow(numA, numB);
  return numApowB;
}
Console.WriteLine(GetApowB());

