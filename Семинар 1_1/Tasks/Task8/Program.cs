/* Задача 26: Напишите программу,
 которая принимает на вход число 
 и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
// Метод для ввода числа
int GetNumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

                if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число");
        }
    }

    return result;

}

// Метод подсчёта числа цифр в числе
void PrintDigitNumber(number)
{
    int i = 0; 
    while(number >= 1)
    {
         number = GetNumber / 10; 
         i++;
    }
    Console.WriteLine($"{i}");
}

int number = GetNumber("Введите число:");
PrintDigitNumber();