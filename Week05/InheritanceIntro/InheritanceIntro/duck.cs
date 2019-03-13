using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class duck
    {
        public int Height;
        public string Name;

        public void Quack()
        {
            MessageBox.Show("Quack");
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }

        public Duck() { }

        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }
    }
}
