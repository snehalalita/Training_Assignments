using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        public static object get_property(object obj,string propertyname)
        {
            PropertyInfo propertyInfo = obj.GetType().GetProperty(propertyname);

            return propertyInfo.GetValue(obj);
        }

        public static void set_property(object obj, string propertyname,object value)
        {
            PropertyInfo propertyInfo = obj.GetType().GetProperty(propertyname);
            propertyInfo.SetValue(obj, value);
        }

        public static object call_method(object obj, string methodname, object[] arg)
        {
            MethodInfo methodInfo = obj.GetType().GetMethod(methodname);

            return methodInfo.Invoke(obj,arg);
        }

        public static object access_enum(Type enumtype,string enumitemname)
        {
            return 1;
        }




        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Training\Training_Assignments\Assignment 2\ConsoleApp1\ChordFileGenerator\bin\Debug\ChordFileGenerator.dll");

            Type type = assembly.GetType("ChordFileGenerator.Class1");

            object obj=Activator.CreateInstance(type);
           
            Console.WriteLine("Enter song name:");
            string songname = Console.ReadLine();

            set_property(obj, "SongName", songname);

            Console.WriteLine("Enter Artist Name:");
            string artistname = Console.ReadLine();

            set_property(obj, "Artist", artistname);
            call_method(obj, "create_file", null);
            //Console.WriteLine("Enter file type:");
            //string filetype = Console.ReadLine();

            //Type fileenum = typeof(ChordFileGenerator.Class1.FileType);
            //object filevalue = access_enum(fileenum, filetype);

            //set_property(obj, "fileType", filevalue);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the type of line:");
                Console.WriteLine("1.Enter one lyric line:");
                Console.WriteLine("2.Enter chord and line:");
                Console.WriteLine("3.Exit");

                int line = Convert.ToInt32(Console.ReadLine());

                switch (line)
                {
                    case 1: Console.WriteLine("Enter a lyric line");
                        string lyrics = Console.ReadLine();
                        call_method(obj, "add_lyric", new object[] { lyrics });

                        break;
                    case 2:
                        Console.WriteLine("Enter chord and lyric line");
                        string chord = Console.ReadLine();
                        string lyric = Console.ReadLine();
                        call_method(obj, "add_chord", new object[] { chord,lyric });
                       

                        break;
                    case 3:
                        flag=false;
                        break;
                    default: Console.WriteLine("Wrong entry.");
                        break;
                }

            }

            call_method(obj, "save_file", new object[] { "test.txt" });

            Console.ReadLine();

        }
    }
}
