// метод, который создаёт массив из 8 двухзначных (1-99)
// рандомных элементов и выводит на экран эелемнты через ", "

int[] arr00 = new int[8];

int[] GetArrRand00()
{
  for (int i = 0; i < arr00.Length; i++)
  {
    arr00[i] = new Random().Next(1, 100);
  }
  return arr00;
}
Console.Write(String.Join((", "), GetArrRand00()));
