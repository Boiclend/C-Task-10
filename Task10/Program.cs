int Message(string text) {
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void SubtractionSeconds() {
    int h = Message(">>часы: ");
    int m = Message(">>минуты: ");
    int s = Message(">>секунды: ");
    int ss = Message(">>Введите количество секунд для вычета: ");
    TimeOnly time = new TimeOnly(h,m,s);
    Console.WriteLine();
    Console.WriteLine($"Введенное время - {time}:{time.Second}"); 
    Console.WriteLine();
    TimeOnly result = time.Add(new TimeSpan(0,0,-ss));
    Console.WriteLine($"Время после вычета секунд - {result}:{result.Second}");
    Console.WriteLine();
}

void DifferenceSeconds() {
    int h = Message(">>часы: ");
    int m = Message(">>минуты: ");
    int s = Message(">>секунды: ");
    TimeOnly time = new TimeOnly(h,m,s);
    Console.WriteLine($"Введите второй момент времени!"); 
    int h2 = Message(">>часы: ");
    int m2 = Message(">>минуты: ");
    int s2 = Message(">>секунды: ");
    TimeOnly time2 = new TimeOnly(h2,m2,s2);


    if(time2 >= time) {
        Console.WriteLine($"Разница между {time2}:{time2.Second} и {time}:{time.Second} в секундах = {(time2 - time).TotalSeconds}");
    } 
    else
    {
        Console.WriteLine($"Разница между {time}:{time.Second} и {time2}:{time2.Second} в секундах = {(time - time2).TotalSeconds}");
    }
}

SubtractionSeconds();
Console.WriteLine("Для получения разницы в секундах между двумя моментами времени введите первый момент");
DifferenceSeconds();




