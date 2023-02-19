// Вид 1
// void Method1() Метод ничего не выводит и ничего не возвращает
// {
//     Console.WriteLine("Автор....");
// }
// Method1();

//Вид 2

// void Method2(string msg) //Метод ничего не возвращает, но принимает
// {
//     Console.WriteLine(msg);
// }
// //Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "текст", count: 4);

//Вид 3

// int Method3() //Метод чтото возвращает но не принимает
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4  метод чтото принимает и чтото возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "rtrtrt");
// Console.WriteLine(res);

// Вид через цикл for
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Вид цикл в цикле
for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}