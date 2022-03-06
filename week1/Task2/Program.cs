string input = "Intellectualization";
string inputToLowerCase = input.ToLower();

string vowels= "aeiou";

int GetVowelCount(string inputToLowerCase){
    int vowelsCount = 0;

    foreach (char letter in inputToLowerCase)
    {
        if (vowels.Contains(letter)) vowelsCount++;
    }
    return vowelsCount;
}

int vowelCount = GetVowelCount(inputToLowerCase);
Console.WriteLine($"Number of vowels: {vowelCount}");