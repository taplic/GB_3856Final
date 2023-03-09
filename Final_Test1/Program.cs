/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

string[] arrayA = new string[7] { "777", "44", "hello", "world", "no", "yes", "16" };
string[] arrayB = new string[arrayA.Length];
FormSecondArrayFrom(arrayA, arrayB);
Console.WriteLine("Первоначальный массив: ");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Финальный массив: ");
PrintArray(arrayB);

void FormSecondArrayFrom(string[] array1, string[] array2)
{
  int count = 0;
  int n = 3;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= n)
    {
      array2[count] = array1[i];
      count++;
    }
  }
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}









