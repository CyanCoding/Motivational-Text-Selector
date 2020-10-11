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
        // Read from the file
        string[] quotesFile = File.ReadAllLines("quotes.json");

        // Randomly pick a quote (line from the file)
        Random random = new Random();
        string line = quotesFile[random.Next(quotesFile.Length)];

        // Split the line into the quote and author.
        string[] lineSplit = line.Split("\", \"");

        // Perform text splitting to remove excess leftover characters from split.
        string quote = lineSplit[0].Substring(2);
        string author = lineSplit[1].Substring(0, lineSplit[1].Length - 2);

        // Print output
        Console.WriteLine(quote);
        Console.WriteLine(author);
    }
}
