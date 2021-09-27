using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordFileGenerator
{
    public class Class1
    {
        public string SongName { get; set; }

        public string Artist { get; set; }

        public FileType fileType { get; set; }

        private List<string> lines;

        public void create_file()
        {
            lines = new List<string>();
            lines.Add("Song Name:" + SongName);
            lines.Add("Artist Name:" + Artist);
            lines.Add("File Type:" + fileType);
        }

        public void add_lyric(string lyrics)
        {
            lines.Add(lyrics);
            Console.WriteLine("Lyrics added");
        }

        public void add_chord(string chords, string lyrics)
        {
            lines.Add(chords);
            lines.Add(lyrics);
            Console.WriteLine("Chords and lyrics added");
        }

        public void save_file(string location)
        {
            //File.Create(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\" + location);
            File.WriteAllLines(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\" + location, lines);
            Console.WriteLine("\nFile Saved.");
        }

        public void file_contents(string location)
        {
            string contents=File.ReadAllText(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\" + location);
            Console.WriteLine("File contents\n **************************");
            Console.WriteLine(contents);
        }

        public enum FileType
        {
            Chords,
            Tab,
            Lyrics,
        }

    }
}
