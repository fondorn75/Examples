// Дан текст. В тексе нужно заменить все пробелы черточками, 
// Маленькие буквы "к" заменить большими "К"
// А большие "С" заменить на маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
              + "ежели бы вас послали вместо нашего милого Винцегероде,"
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";

string stringReplace(string text, char oldSymbol, char newSymbol)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldSymbol) result = result + $"{newSymbol}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newresult = stringReplace(text, ' ', '|');
Console.WriteLine(newresult);
Console.WriteLine();
newresult = stringReplace(newresult, 'к', 'К');
Console.WriteLine(newresult);
Console.WriteLine();
newresult = stringReplace(newresult, 'С', 'с');
Console.WriteLine(newresult);