/*
 * Author: CyanCoding (Camden Mac Leod)
 * Date created: Oct 11, 2020
 * 
 * If you copy parts of this code into your program,
 * please provide credit!
 */

using System;
using System.IO;

class MainClass {
    static void Main(string[] args) {
        string[] quotesFile = File.ReadAllLines("quotes.json");

        Random random = new Random();
        string line = quotesFile[random.Next(quotesFile.Length)];

        string[] lineSplit = line.Split("\", \"");

        string quote = lineSplit[0].Substring(2);
        string author = lineSplit[1].Substring(0, lineSplit[1].Length - 2);

        Console.WriteLine(quote);
        Console.WriteLine(author);
    }
}
