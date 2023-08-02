using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    public class File:ISystem
    {
        public string? Path { get; set; }
        public double Size { get;}

        public File(string path,double size)
        {
            Path = path;
            Size = size;
        }
        public override string ToString()
        {
            return Path!;
        }
    }
}
