//  Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string inputStr = "HeLLoNEWyeaR";
string resultStr = "";

for (int i = 0; i < inputStr.Length; i++)
{
    if (Char.IsUpper(inputStr[i]))
    {
        resultStr += Char.ToLower(inputStr[i]);
    }
    else
    {
        resultStr += inputStr[i];
    }
}

Console.WriteLine(resultStr); // Output: "helloWorld"