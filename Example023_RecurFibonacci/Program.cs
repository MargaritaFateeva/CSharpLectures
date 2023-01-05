// Задача 10 Числа Фибоначчи

decimal fRec = 0; // переменная для подсчета вызовов рекурсии
decimal fIte = 0; // переменная для подсчета вызовов итеративного метода

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n==0||n==1 ? 1:FibonacciRecursion(n-1)+FibonacciRecursion(n-2);
}

decimal FibonacciIteraton(int n)
{
    fIte++;
    decimal result=1;
    decimal f0=1;
    decimal f1=1;
    for (int i=2; i<=n; i++)
    {
        result = f0+f1;
        f0=f1;
        f1=result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5 6 
//V 1 1 2 3 5 8
Console.ReadLine();
DateTime dt = DateTime.Now; 
Console.ReadLine();
for(int n =1; n<40; n++)
{
    Console.WriteLine($"FibonacciIteraton({n}) = {FibonacciIteraton(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte=0; // количество операций обнуляем для слудующего числа
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // вывод времени оперции
Console.WriteLine();
Console.ReadLine();

DateTime rt = DateTime.Now;
for(int n =1; n<40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec=0; // количество операций обнуляем для следующего числа
}

System.Console.WriteLine((DateTime.Now - rt).TotalMilliseconds);
