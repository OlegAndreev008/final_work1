// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
int elementCount = 0;
while (elementCount <= 0)
{
    Console.Write("Сколько значений вам нужно ввести? ");
    elementCount = Convert.ToInt32(Console.ReadLine());
}
string[] massiv = new string[elementCount];
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите значение {i + 1}: ");
        arr[i] = Console.ReadLine();
    }
}
void PrintArray(string[] arr)
{
    Console.Write("Был создан массив: ");
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}
void CreateNewArray(string[] arr)
{
    Console.Write("Элементы с длиной 3 и менее символов: ");
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= 3)
        {
            Console.Write($"{arr[k]} ");
        }
    }
}
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine();
CreateNewArray(massiv);