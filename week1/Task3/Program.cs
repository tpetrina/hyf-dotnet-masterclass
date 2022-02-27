// 3. Math/Array

int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 };
int[] result = GetResult(arr); //TODO: Implement GetResult

int[] GetResult(int[] arr){
    var PositiveNumbersSum = 0;
    var NegativeNumbersSum = 0;

    foreach (int number in arr)
    {
        if(number >= 0){
            PositiveNumbersSum += number;
        }else{
            NegativeNumbersSum += number;        
        }
    }

    var Result = new int[] {NegativeNumbersSum, PositiveNumbersSum};
    return Result;
}
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");