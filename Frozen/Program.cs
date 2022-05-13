using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Presents
        {
            string character;
            string gift;

            public Presents(string _character, string _gift)
            {
                character = _character;
                gift = _gift;
            }


            public string Character
            {
                get { return character; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            List<Presents> myPresents = new List<Presents>();
            string[] presentsFromFile = GetDataFromFile();

            foreach (string line in presentsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Presents newPresent = new Presents(tempArray[0], tempArray[1]);
                myPresents.Add(newPresent);
            }

            foreach (Presents presentFromList in myPresents)
            {
                Console.WriteLine($"{presentFromList.Character} wants {presentFromList.Gift}. ");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\simso\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}