// Время задается в формате час, минута, секунда. Реализовать:

// 1) вычитание из времени указанного пользователем количества секунд;

// 2) подсчёт числа секунд между двумя моментами времени, лежащими в пределах одних суток.


int Message(string text) {
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void SubtractionSeconds() { // вычитание из времени указанного пользователем количества секунд указанных пользователем
    int h = Message(">>часы: ");
    int m = Message(">>минуты: ");
    int s = Message(">>секунды: ");
    int ss = Message(">>Введите количество секунд для вычета: ");
    TimeOnly time = new TimeOnly(h,m,s); // Инициализация структуры TimeOnly с пользовательскими данными h - часы, m - минуты, s - секунды.
    Console.WriteLine();
    Console.WriteLine($"Введенное время - {time}:{time.Second}");  // при простом выводе time время будет указано без секунд, поэтому отдельно просим вывести нам и секунды тоже
    Console.WriteLine();
    TimeOnly result = time.Add(new TimeSpan(0,0,-ss)); // вычитаем количество секунд ss введенных пользователем из time с помощью TimeSpan структуры. 
    Console.WriteLine($"Время после вычета секунд - {result}:{result.Second}");
    Console.WriteLine();
}

void DifferenceSeconds() { // разница между двумя введенными пользователем моментами времени в секундах
    int h = Message(">>часы: ");
    int m = Message(">>минуты: ");
    int s = Message(">>секунды: ");
    TimeOnly time = new TimeOnly(h,m,s); // Инициализация структуры TimeOnly с пользовательскими данными h - часы, m - минуты, s - секунды.
    Console.WriteLine($"Введите второй момент времени!"); 
    int h2 = Message(">>часы: ");
    int m2 = Message(">>минуты: ");
    int s2 = Message(">>секунды: ");
    TimeOnly time2 = new TimeOnly(h2,m2,s2); // Инициализация структуры TimeOnly с пользовательскими данными h - часы, m - минуты, s - секунды.


    if(time2 >= time) {
        Console.WriteLine($"Разница между {time2}:{time2.Second} и {time}:{time.Second} в секундах = {(time2 - time).TotalSeconds}"); // .TotalSeconds показывает нам сколько СЕКУНД в получившемся моменте времени time2 - time
    } 
    else
    {
        Console.WriteLine($"Разница между {time}:{time.Second} и {time2}:{time2.Second} в секундах = {(time - time2).TotalSeconds}"); 
    }
}

SubtractionSeconds();
Console.WriteLine("Для получения разницы в секундах между двумя моментами времени введите первый момент");
DifferenceSeconds();




