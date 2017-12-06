using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlOOP_last_ver
{
    class ImageFile : File
    {
        public string ResolutionOfFile { get; set; }

        public ImageFile(string splitedLine) : base(splitedLine)
        {
            ResolutionOfFile = subLine[3].TrimStart();
        }

        public override String ToString()
        {
            return base.ToString() + $"Content: {ResolutionOfFile}\n";
        }





    }
}
