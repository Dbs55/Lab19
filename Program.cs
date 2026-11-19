
Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

Console.WriteLine(">>> Анализ строки <<<");
Console.WriteLine();
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");

Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());
int index = FindCharacterIndex(text, target);

if (index == -1)
{
    Console.WriteLine("Символ не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}

//подсчет символов
int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}
//подсчет цифр
int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}
//подсчет букв
int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }

    return count;
}

//первое вхождение символа
int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            index = i;
            return index;
        }
    }

    return -1;
}

// в список с удалением пустот
int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}
int FindLastCharacterIndex(string text, char target)
{
    for (int i = text.Length - 1; i > 0; i--)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return -1;
}
int FindLastCharacterIndex(string text, char target)
{
    for (int i = text.Length; i < 0; i--)
    {
        if (text[i] == target) { return i; }
    }
    return -1;
}
Console.WriteLine($" {FindLastCharacterIndex("banana", 'a')}"); 
Console.WriteLine($"{FindLastCharacterIndex("banana", 'z')}"); 
Console.WriteLine($"{FindLastCharacterIndex("", 'a')}");            

