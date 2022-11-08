
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых маньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте через выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры: ["hello", "2", "world", ":-)" ] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science" ] -> ["-2"]
//["Russia", "Denmark", "Kazan" ] -> []

Console.Write("Введите длинну массива: ");
int numLenght = Convert.ToInt32(Console.ReadLine());
string[] array = new string[numLenght];
int length = 3;
void FillingStringArray(string[] array)//Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите значение массива: " );
        array[i] = Console.ReadLine();
    }
}
int CountNewArray(string[] arr, int lenghtNum)//Нахождение длинны нового массива
{
    int counter = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lenghtNum) counter++;
    }
    return counter;
}
void FillingNewStringArray(string[] oldArray, string[] newArray, int newLenght)//Заполненение нового массива
{
    int newArrayIndex = default;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= newLenght)
        {
            newArray[newArrayIndex] = oldArray[i];
            newArrayIndex++;
        }
    }
}
FillingStringArray(array);//Заполняю массив
int count = CountNewArray(array, length);// узнаю длинну нового массива
Console.Write("[" + string.Join(", ", array) + "]");//Вывожу заданный массив
Console.WriteLine();
if (count <= 0) Console.Write("[ ]");//Вывожу пустой массив
else//Создаю новый массив и вывожу его
{
    string[] newArray = new string[count];
    FillingNewStringArray(array, newArray, count);
    Console.Write("[" + string.Join(", ", newArray) + "]");
    Console.WriteLine();
}
