//  Задайте значение N. Напишите программу, 
//   которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
void ShowNums (int num)
{
    Console.Write(num + " ");
    if(num>1) ShowNums(num-1);
}
ShowNums(num); 

*/

//   Задайте значения M и N. Напишите программу, 
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShoyDiff (int numA, int numB)
{
    if(numA < numB)
    {
        ShoyDiff(numA, numB - 1);
        Console.Write(numB + " ");
    }
    if(numA>numB)
    {
        Console.Write(numA+" ");
        ShoyDiff(numA-1,numB);
        return(numA + numB)*(numA - numB + 1)/2;
    }
    if(numA == numB) Console.Write(numA + " ");
    
}

Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

ShoyDiff(numM, numN);
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

/*
{
    {
		int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		Console.WriteLine(AkkermanFunc(3,2));
	}
}

*/