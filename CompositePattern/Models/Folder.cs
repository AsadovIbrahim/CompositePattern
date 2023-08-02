using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    public class Folder : ISystem, INotifyPropertyChanged
    {
        private string? path;
        private double size;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<ISystem> Systems { get; set; } = new ObservableCollection<ISystem>();

        public Folder(string? path)
        {
            Path = path;
        }
        public string? Path
        {
            get { return path; }
            set
            {
                path = value;
                if (!string.IsNullOrEmpty(path))
                {

                    DirectoryInfo directory = new DirectoryInfo(path);
                    Systems.Clear();
                    IterateItems(directory);

                }
                OnPropertyChanged(nameof(Path));
            }

        }
        public double Size
        {
            set { size = value; OnPropertyChanged(nameof(Size)); }
            get
            {
                return size;
            }
        }

        public void IterateItems(DirectoryInfo directory)
        {

            foreach (var dir in directory.GetDirectories())
            {
                Folder subFolder = new Folder(dir.FullName);
                Systems.Add(subFolder);
            }

            foreach (var file in directory.GetFiles())
            {
                File fileItem = new File(file.FullName, file.Length);
                Systems.Add(fileItem);
            }
            Size = Systems.Sum(item => item.Size);

        }
    }
}
