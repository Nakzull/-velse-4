using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread printer = new Thread(pg.PrinterFunction);
        printer.Start();

        Thread reader = new Thread(pg.ReaderFunction);
        reader.Start();
    }
}

class program
{
    char ch = '*';
    public void PrinterFunction()
    {
        while (true)
        {
            Console.Write(ch);
            Thread.Sleep(100);
        }
    }

    public void ReaderFunction()
    {
        char temp = '*';
        ConsoleKeyInfo input;
        while (true)
        {
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                ch = temp;
                Console.WriteLine();
            }
            else
            {
                temp = input.KeyChar;
            }
        }
    }
}