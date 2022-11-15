/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

int numberM = EnterNumberNatural("Введите натуральное число M:   ", "Ошибка ввода!");
int numberN = EnterNumberNatural("Введите натуральное число N:   ", "Ошибка ввода!");

//==============================FUNCTIONS=====================================
// Функция возвращает пользовательское натуральное число
static int EnterNumberNatural(string message, string messageError)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0;
        if (isCorrect)
            return number;
        Console.WriteLine(messageError);
    }
}


// Функция принрмает 2 натуральных аргумента и возвращает результат вычисления функции Аккермана:
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM != 0 && numberN == 0) 
        return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) 
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));

    return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел {numberM} и {numberN} = {AckermannFunction(numberM, numberN)}");