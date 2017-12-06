using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlOOP_last_ver
{
    public static class AdditionalClass
    {
        public enum TypeFile { Text, Image, Movie };
        public enum SizeFile { B, KB, MB, GB }; //Sorted by Size  Doesn't implement yet

        public static string GetTypeFile(string c) // File, Image, Movie, etc..
        {
            Char charRange = ':';
            int startIndex = 0;
            int endIndex = (c.LastIndexOf(charRange) - 1);
            int length = endIndex - startIndex + 1;
            string ext = c.Substring(startIndex, length);
            return ext;
        }

        public static List<File> MakingAnObject(String[] temp) // From string to object
        {
            List<File> list = new List<File>();

            for (int i = 0; i < temp.Length; i++)
            {
                if (TypeFile.Text.ToString() == GetTypeFile(temp[i]))
                {
                    list.Add(new TextFile(temp[i]));
                }
                if (TypeFile.Movie.ToString() == GetTypeFile(temp[i]))
                {
                    list.Add(new MovieFile(temp[i]));
                }
                if (TypeFile.Image.ToString() == GetTypeFile(temp[i]))
                {
                    list.Add(new ImageFile(temp[i]));
                }
            }
            return list;
        }

        public static void PrintList(List<File> s)
        {
            //Console.WriteLine("The capacity is " + s.Count);
            foreach (File item in s)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
