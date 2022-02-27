string input = "Intellectualization";
string inputToLowerCase = input.ToLower();

string Vowels= "aeiou";
char[] VowelsArray = Vowels.ToCharArray();

int GetVowelCount(string inputToLowerCase){
    int VowelsCount = 0;

    foreach (char letter in inputToLowerCase)
    {
        foreach (char vowel in VowelsArray)
        {
            if (letter == vowel) VowelsCount++;
        }
    }
    return VowelsCount;
}

int vowelCount = GetVowelCount(inputToLowerCase);
Console.WriteLine($"Number of vowels: {vowelCount}");