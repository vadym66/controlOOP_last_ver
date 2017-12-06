using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlOOP_last_ver
{
    public class File
    {
        public string TypeOfFile { get; set; }
        public string NameOfFile { get; set; }
        public string ExtensionOfFile { get; set; }
        public string SizeOfFile { get; set; }
        protected String[] subLine; //  ???

        public File(string splitedLine) // ?? правильно ли я устонваливаю конструкторы 
        {
            String[] subLine = splitedLine.Split(new[] { ':', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            TypeOfFile = subLine[0].Trim();
            NameOfFile = subLine[1].TrimStart();
            ExtensionOfFile = GetExtension(splitedLine);
            SizeOfFile = subLine[2];

            this.subLine = subLine;
        }

        public string GetExtension(string temp)
        {
            Char charRange = '(';
            int startIndex = (temp.LastIndexOf(charRange) - 4);
            int endIndex = (temp.LastIndexOf(charRange) - 1);
            int length = endIndex - startIndex + 1;
            string ext = temp.Substring(startIndex, length);
            return ext;
        }

        public override String ToString()
        {
            return $"Type of File: {TypeOfFile}\nName of File: {NameOfFile}\nExtension Of File: {ExtensionOfFile}\nSize Of File: {SizeOfFile}\n";
        }
    }
}
