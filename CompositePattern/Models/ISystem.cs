using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    public interface ISystem
    {
        string ?Path { get; set; }
        double Size { get;}
    }
}
