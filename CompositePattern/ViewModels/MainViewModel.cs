using CompositePattern.Models;
using CompositePattern.RealCommand;
using CompositePattern.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace CompositePattern.ViewModels
{
    public class MainViewModel
    {
       

        public ISystem StartFolder { get; set; } = 
            new Folder($"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))}");


       
    }
}
