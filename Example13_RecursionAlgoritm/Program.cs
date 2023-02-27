// Пример 1
// string[,] table = new string[2, 5];
// string.Empty
// table[0,0] table[0,1] table[0,2] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,4]

// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



// Пример 2
// int[,] matrix = new int[3, 4];

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLongLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLongLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);  // [1; 10)
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// Пример 3
// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
//  Console.WriteLine(Factorial(3)); //1*2*3 = 6

// Пример 4

// f(1) = 1
// f(2) = 1
// f(n) = false(n-1) + (n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
} 