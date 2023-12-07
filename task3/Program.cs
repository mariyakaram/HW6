// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// Палиндром -Слово или фраза, которые одинаково читаются слева направо 
//и справа налево. "Палиндром «Я иду с мечем судия»"

string inputStr = "racecar";
bool isPalindrome = true;

for (int i = 0; i < inputStr.Length / 2; i++)
{
    if (inputStr[i] != inputStr[inputStr.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}
