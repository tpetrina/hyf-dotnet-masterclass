// 5. Arrays

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);
int[] result = AddArray(splitArray);

int[][] Split (int[] input){
 if(input.Length%2 ==0){

   var firstArray = input.Take(input.Length / 2).ToArray();
   var secondArray = input.Skip(input.Length / 2).ToArray();

    return new int[][]{firstArray, secondArray};
 }else{
    Console.WriteLine("Array must be even");
    return null;
 }
}

int[] AddArray (int[][] splitArray){
    var firstArray = splitArray[0];
    var secondArray = splitArray[1];
    var result = new int[firstArray.Length];
 for (int i = 0; i < firstArray.Length; i++)
 {
   result[i]= firstArray[i]+secondArray[i];
 }
return result;
}

void WriteResult(int[] result){
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
        Console.Write(" ");
    }
}

WriteResult(result);