// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы через пробел: ");
bool number = int.TryParse(Console.ReadLine(), out int num);

int[] arr = GetArray();
int count = GetValuesGreaterThanZero();
Console.WriteLine($"Кол-во элементов элементов в массиве {arr}, которые больше нуля = {count}");

int[] GetArray()
{
    int[] arr = new int[num];
    return arr;
}

int GetValuesGreaterThanZero()
{
    int count = 0;
    for (int i = 0; i <= arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}