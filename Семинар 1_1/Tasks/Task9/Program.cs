/* Задача 28: Напишите программу, 
которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
*/


int GetNumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int GetFactoRial (int num)

{
    int index = 1;
    int factorial = 1;
    while (index <= num)
    {
       factorial = factorial * index;
       index++;
    }
    return factorial;
}

int numberForfactorial = GetNumber ("Введите число для расчёта факториала:");
int multi = GetFactoRial (numberForfactorial);

Console.WriteLine($"Произведение чисел от 1 до N рвано: {multi}");
CD