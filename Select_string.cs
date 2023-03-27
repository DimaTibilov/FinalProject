// See https://aka.ms/new-console-template for more information


//------------------------------------------------------------
//  объявление переменных

int numbers = 0;    //  кол-во элементов в массиве
string print = String.Empty;

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
        str = Console.ReadLine();
        array[i] = str;
    }

    return array;  //  возвращаем массив
}

//---------------------------------------------------------
//  вывод одномерного массива в консоль

string PrintArrayOneDim(string[] array)
{
    string result = String.Empty;
    int length = array.Length;

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

    int j = 0;
    int len = inArray.Length;
    string[] outArray = new string[len];

    for (int i = 0; i < len; i++)
    {
        if (inArray[i].Length <= 3)
        {
            outArray[j] = inArray[i];
            j = j + 1;
        }
    }
    return outArray;
}

//-----------------------------------------------------------
//  основная программа

numbers = GetNumber("Введите кол-во элементов массива ");

string[] inputMassiv = new string[numbers];  //  массив для ввода строк

string[] outputMassiv = new string[numbers];

Console.WriteLine("Заполнение массива");

inputMassiv = InputMassiv(numbers);

print = PrintArrayOneDim(inputMassiv);

Console.Write("Получаем входной массив :   ");

Console.WriteLine(print);

outputMassiv = FindInMassiv(inputMassiv);

Console.Write("Получаем выходной массив :   ");

print = PrintArrayOneDim(outputMassiv);

Console.WriteLine(print);