// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше или равна 3-м символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоватся коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Methods
// Методы
string[] CreateArrayString(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the value of {i} element: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write($"'{arr[i]}'; ");
    }
    Console.Write($"'{arr[arr.Length - 1]}'");
    Console.Write("]");
}

string[] CreateArrayElemLenUnderThree(string[] arr, int size)
{
    string[] resultArray = new string[arr.Length];    // создает новый массив с длиной, равной массиву, подающемуся на вход,
    int count = 0;                                    // ведь длина результирующего массива не может быть больше исходного
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= size)
        {
            resultArray[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref resultArray, count);             // убирает пустые элементы результирующего массива
    return resultArray;
}

// Body
Console.Clear();
int len;
do       // используем цикл для проверки пользовательского ввода, так как длина массива должна быть больше нуля.
{
    Console.WriteLine("Enter the value (positive integer number) of array's length or type '-1' to exit the programm: ");
    len = Convert.ToInt32(Console.ReadLine());
    if (len == -1) break;
} while (len < 1);
if (len == -1) return;

string[] array = CreateArrayString(len);
PrintArray(array);
string[] result = CreateArrayElemLenUnderThree(array, 3);
Console.Write(" -> ");
PrintArray(result);
