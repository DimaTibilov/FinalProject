// See https://aka.ms/new-console-template for more information

//  Задача

//  Написать программу, которая из имеющегося массива строк
//  формирует массив из строк, длина которых меньше или равна 3-м символам.
//  Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

//------------------------------------------------------------
//  объявление переменных

int numbers = 0;    //  кол-во элементов в массиве
string print = String.Empty;    //  используем для вывода массива в консоль

//------------------------------------------------
//  ввод числа элементов массива

int GetNumber(string text)
{
    int number = 0;
    System.Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//------------------------------------------------
//  ввод элементов массива - строк

string[] InputMassiv(int numbers)
{
    string[] array = new string[numbers];
    string str = String.Empty;
    for (int i = 0; i < numbers; i++) //  цикл - заполняем массив
    {
        Console.WriteLine("Введите строку");
        str = Console.ReadLine();   //  вводим строку с клавиатуры
        array[i] = str; //  записываем введенную строку в массив
    }

    return array;  //  возвращаем массив
}

//---------------------------------------------------------
//  вывод одномерного массива в консоль

string PrintArrayOneDim(string[] array)
{
    string result = String.Empty;
    int length = array.Length;  //  длина массива

    for (int i = 0; i < length; i++)
    {
        result = ($"{result}   {array[i]}");   //  формируем строку с результатами средних значений
    }

    return result;
}

//-------------------------------------------------------
//  поиск во входном массиве строк с длиной <=3 символа

string[] FindInMassiv(string[] inArray)
{

    int j = 0;  //  индекс элементов выходного массива
    int len = inArray.Length;   //  длина входного массива
    string[] outArray = new string[len];

    for (int i = 0; i < len; i++)
    {
        if (inArray[i].Length <= 3) //  если элемент - строка входного массива размером <= 3
        {                           //  записываем его в массив выходных данных
            outArray[j] = inArray[i];
            j = j + 1;
        }
    }
    return outArray;
}

//-----------------------------------------------------------
//  основная программа

numbers = GetNumber("Введите кол-во элементов массива ");

string[] inputMassiv = new string[numbers]; //  массив для ввода строк

string[] outputMassiv = new string[numbers];    // массив выходных данных

Console.WriteLine("Заполнение массива");

inputMassiv = InputMassiv(numbers); //  вызов метода заполнения массива строками

print = PrintArrayOneDim(inputMassiv);  //  вызов метода печати входного массива

Console.Write("Получаем входной массив :   ");

Console.WriteLine(print);

outputMassiv = FindInMassiv(inputMassiv);   //  вызов метода поиска элементов массива - строк размером <= 3 символов

Console.Write("Получаем выходной массив :   ");

print = PrintArrayOneDim(outputMassiv); //  вызов метода печати массива выходных данных

Console.WriteLine(print);