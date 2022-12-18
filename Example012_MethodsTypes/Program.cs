// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("текст", 4);
// Method21(msg:"текст", count: 4);
// Method21(count: 4, msg:"текст");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    // int i =0;
    // string result = string.Empty;
    // while (i<count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;

    string result = string.Empty;
    for( int i=0; i<count; i++)
    {
        result=result + text;
    }
    return result;
}

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Вывод таблицы умножения на экран

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }


//работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, вы бы " 
+ "взяли приступом согласие прусского короля. Вы так красноречивы. " 
+"Выдадите мне чаю?";

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for (int i=0; i<lenght; i++)
    {
        if (text[i] == oldValue) result =result + $"{newValue}";
        else result= result + $"{text[i]}";
    }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// string newText1 = Replace(text, 'к', 'К');
// Console.WriteLine(newText1);
// Console.WriteLine();
// string newText2 = Replace(text, 'С', 'с');
// Console.WriteLine(newText2);

// Сортировка массива
// как упорядочить массив от большего к меньшему

int []arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[]array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j<array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition=j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);