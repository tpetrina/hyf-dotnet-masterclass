// 4. Classical task

int n = 6;
int nthNumber = Fibonacci(n);

int Fibonacci(int n){
var Pre1= 0;
var Pre2= 1;
var Sum = 0;
for (int i = 2; i <= n; i++)
{
    Sum = Pre1 + Pre2;
    Pre1 = Pre2;
    Pre2 = Sum;
}
return Sum;
}
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

//int n = 6 => Nth fibonacci number is 8
