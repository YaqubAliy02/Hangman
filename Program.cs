
using System;

class Hangman
{
    static void Main(string[] args)
    {
        string words = "water";

        char[] guessedWord = new char[words.Length];
        PrintHiddenSign(words, guessedWord);

        int attemptsLeft = 5;
        bool printHiddenLine = false;

        PrintMessage("Hangman o'yiniga xo'sh kelibsiz!!!\n");
        PrintMessage("Siz (-----) ostida yarilgan so'zni topishga harakt qiling!\n");
        Console.WriteLine();
        PrintMessage("Suv so'zini ingliz tili ma'nosidagi harflarni ketma ketligda kiriting!\n");

        Hangmen(printHiddenLine, attemptsLeft, words, guessedWord);
        PrintResult(words, printHiddenLine);

    }
    static void Hangmen(bool printHiddenLine, int attemptsLeft, string words, char[] guessedWord)
    {
        while (!printHiddenLine && attemptsLeft > 0)
        {
            PrintMessage($"Sizda {attemptsLeft} ta jon mavjud \n");
            PrintMessage($"Tartibdagi harfni kiriting:");

            char letter = Console.ReadLine()[0];

            if (words.Contains(letter))
            {
                PrintMessage("Correct!\n");
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == letter)
                    {
                        guessedWord[i] = letter;
                    }
                }
                Console.WriteLine(guessedWord);
                if (!guessedWord.Contains('-'))
                {
                    printHiddenLine = true;
                }
            }
            else
            {
                PrintMessage("Incorrect!");
                attemptsLeft--;
            }
        }
    }

    static char[] PrintHiddenSign(string words, char[] guessedWord)
    {
        for (int i = 0; i < words.Length; i++)
        {
            guessedWord[i] = '-';
        }
        return guessedWord;
    }

    static void PrintResult(string words, bool printHiddenLine)
    {
        if (printHiddenLine)
        {
            PrintMessage("Siz men o'ylagan so'zni topdingiz:" + words);
        }
        else
        {
            PrintMessage("Sizning joningiz to'gadi, Men o'ylagan so'z " + words + " edi");
        }
    }

    static void PrintMessage(string message)
    {
        Console.Write(message);
    }
}