using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ: ");
        char charPro = Convert.ToChar(Console.ReadLine());

        if (Char.IsDigit(charPro))
        {
            Console.WriteLine("true");
            Console.WriteLine($"Код символа: {(int)charPro}");
        }
        else if (Char.IsWhiteSpace(charPro))
        {
            Console.WriteLine("Это символ из категории пробелов");
        }
        else if (Char.IsLetter(charPro))
        {
            if (Char.IsLower(charPro))
            {
                Console.WriteLine("Это символ из категории букв в нижнем регистре");
            }
            else if (Char.IsUpper(charPro))
            {
                Console.WriteLine("Это символ из категории букв в верхнем регистре");
            }
        }
        else if (Char.IsPunctuation(charPro))
        {
            Console.WriteLine("Это символ из категории знаков препинания");
        }
        else if (Char.IsControl(charPro))
        {
            Console.WriteLine("Это символ из категории управляющих символов");
        }
        else
        {
            Console.WriteLine("Не удалось определить категорию символа");
        }
    }
}
