// 1. String manipulation

string input = "world";

string ReverseString(string input){
char[] charArray = input.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}

string reversed = ReverseString(input);
Console.WriteLine($"Reversed input value: {reversed}");