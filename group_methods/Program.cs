// 1. Метод: ничего не возвращает и не принимает

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();



// 2 Метод: принимают, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count) // явное указание аргумента - поименнованное
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
// Method21("Текст", 4); // 4 раза выводит слово Текст
// Method21(count: 4, msg: "Новый текст"); // 4 раза выводит слово Новый текст




//3. Метод: что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);