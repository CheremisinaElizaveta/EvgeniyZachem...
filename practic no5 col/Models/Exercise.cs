using practic_no5_col.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_no5_col
{
    
    public class Exercise
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public bool IsChecked { get; set; }

        public Exercise(string name, string image, bool isChecked)
        {
            Name = name;
            ImgPath = image;
            IsChecked = isChecked;
        }
        public string ImagePath
        {
            get
            {
                string path = $"D:\\ПРАКТОС УЖЕ ВОТ ПЯТЫЙ\\practic no5 col\\practic no5 col\\Resoucres\\{ImgPath}";
                return path;
            }
        }

    }
}
