/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();

int numberM = EnterNumberNatural("Введите натуральное число M:   ", "Ошибка ввода!");
int numberN = EnterNumberNatural("Введите натуральное число N:   ", "Ошибка ввода!");

if(numberM > numberN) 
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
//int summ = 0;

int summNumbers = SummNumbersNaturals(numberM, numberN);

Console.WriteLine(summNumbers);
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
//----------------------------------------------------------------------------
// Функция принимает два натуральных числа M и N и возвращает сумму натуральных элементов в промежутке от M до N
static int SummNumbersNaturals(int start, int end)
{
    if (start > end)
        return 0;
    else 
        return(end + SummNumbersNaturals(start, end - 1));

}
