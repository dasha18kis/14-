// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Меняет порядок следования цифр числа на обратный
//Входные данные: k - Число
//Выходные данные: kinv - Обратное число
static int InvertDigits(int k)
{
    int kinv = 0;
    do
    {
        kinv = (kinv * 10) + (k % 10); //обращение числа
        k = k / 10;
    }
    while (k != 0);
    return kinv;
}
//основная программа
{
    int i, k;
    for (i = 0; i < 5; i++)
    {
        Console.WriteLine("Введите число");
        k = Convert.ToInt32(Console.ReadLine());// ввод числа
        k = InvertDigits(k);// Обращение числа
        Console.WriteLine("Число с обратным порядком следования цифр:" + k);
        Console.WriteLine("");
    }
    Console.ReadLine();  // пауза
}
