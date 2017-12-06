using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlOOP_last_ver
{
    class TextFile : File
    {
        public string ContentOfFile { get; set; }

        public TextFile(string splitedLine) : base(splitedLine)
        {
            ContentOfFile = subLine[3];
        }

        public override String ToString()
        {
            return base.ToString() + $"Content: {ContentOfFile}\n";
        }







    }
}
