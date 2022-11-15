/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int N = EnterNumberNatural("Введите натуральное число:  ", "Ошибка ввода!");

Console.WriteLine(CrearOrder(N, 1));

//==============================FUNCTIONS=====================================
// Функция возвращает пользовательское натуральное число
static int EnterNumberNatural(string message, string messageError)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int parametr) && parametr >0;
        if(isCorrect)
            return parametr;
        Console.WriteLine(messageError);
    }
}
//----------------------------------------------------------------------------
// Функция принимает натуральное число N  и возвращает сумму чисел от 1 до N
string CrearOrder(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + ", " + CrearOrder(start - 1, end));
}
//----------------------------------------------------------------------------
