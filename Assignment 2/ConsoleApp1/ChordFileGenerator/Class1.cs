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
        }

        public void add_lyric(string lyrics)
        {
            lines.Add(lyrics);
            Console.WriteLine("added lyrics");
        }

        public void add_chord(string chords, string lyrics)
        {
            lines.Add(chords);
            lines.Add(lyrics);
            Console.WriteLine("added chords and lyrics");
        }

        public void save_file(string location)
        {
            //File.Create(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\" + location);
            File.WriteAllLines(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\" + location, lines);
            Console.WriteLine("File Saved.");
        }

        public string file_contents()
        {
            return "File Contents";
        }

        public enum FileType
        {
            Chords,
            Tab,
            Lyrics
        }

    }
}
