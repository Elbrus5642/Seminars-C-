/* Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
//получение числа с консоли
//получение числа с консоли

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        /*
        2 типа данных: reference types(ссылочные) и value types(значимые)
        */

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1 && result <=4)
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

string GetQurter (int number)
{
    if (number ==1)
    {
      return "Первая четверть x > 0, y > 0";
    }
    if (number == 2)
    {
      return "Первая четверть x < 0, y > 0";
    }
if (number == 3)
    {
      return "Первая четверть x < 0, y < 0";
    }
    
      return "Первая четверть x > 0, y < 0";
  
}

int number = GetNumber ("Введите номер четверти: ");
string quater = GetQurter (number); 
Console.WriteLine(quater);