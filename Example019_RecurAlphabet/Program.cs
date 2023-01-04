﻿// Задача 6 Перебор слов В некотором машинном алфавите имеются четыре буквы 
// «а», «и», «с» и «в». Покажите все слова, состоящие из T букв, 
// которые можно построить из букв этого алфавита

// char[] s = { 'а', 'и', 'с','в'}; //выборка слов из 1 буквы
// int count = s.Length; 
// int n = 1; 
// for (int i = 0; i < count; i++) 
// {    
//     Console.WriteLine($"{n++,-5}{s[i]}"); 
// }

// char[] s = { 'а', 'и', 'с','в'}; //выборка слов из 2 букв
// int count = s.Length; 
// int n = 1; 
// for (int i = 0; i < count; i++) 
// {   
//     for (int j = 0; j < count; j++)   
//     {       
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");   
//     } 
// }

// char[] s = { 'а', 'и', 'с','в'}; //выборка слов из 3 букв
// int count = s.Length; 
// int n = 1; 
// for (int i = 0; i < count; i++) 
// {   
//     for (int j = 0; j < count; j++)   
//     {       
//         for (int k = 0; k < count; k++)       
//         {           
//             Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");       
//         }   
//     } 
// }

// char[] s = { 'а', 'и', 'с','в'}; //выборка слов из 4 букв
// int count = s.Length; 
// int n = 1; 
// for (int i = 0; i < count; i++) 
// {   
//     for (int j = 0; j < count; j++)   
//     {       
//         for (int k = 0; k < count; k++)       
//         {           
//             for (int l = 0; l < count; l++)           
//             {               
//                 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");           
//             }       
//         }   
//     } 
// }

// char[] s = { 'а', 'и', 'с','в'}; //выборка слов из 5 букв
// int count = s.Length; 
// int n = 1; 
// for (int i = 0; i < count; i++) 
// {   
//     for (int j = 0; j < count; j++)   
//     {       
//         for (int k = 0; k < count; k++)       
//         {           
//             for (int l = 0; l < count; l++)           
//             {               
//                 for (int m = 0; m < count; m++)               
//                 {                   
//                     Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");               
//                 }           
//             }       
//         }   
//     } 
// }

int n=1; // рекурсия
void FindWords(string alphabet, char[] word, int length = 0) 
{   
    if (length == word.Length)   
    {       
        Console.WriteLine($"{n++} {new String(word)}");  
        return;   
    }   
    for (int i = 0; i < alphabet.Length; i++)  
    {       
        word[length] = alphabet[i];       
        FindWords(alphabet, word, length + 1);   
    } 
}

FindWords("аисв", new char[2]);