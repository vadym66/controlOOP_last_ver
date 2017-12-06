using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlOOP_last_ver
{
    class MovieFile : ImageFile
    {
        public string LengthOfFile { get; set; }

        public MovieFile(string splitedLine) : base(splitedLine)
        {
            LengthOfFile = subLine[4].TrimStart();
        }

        public override String ToString()
        {
            return base.ToString() + $"Duartion: {LengthOfFile}";
        }
    }
}
