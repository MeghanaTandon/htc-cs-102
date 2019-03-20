using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        string AnimationStudio;
        string AnimationType;

        public AnimatedMovie(string title, int releaseYear, string animationStudio, string animationType)
        {
            Title = title;
            ReleaseYear = releaseYear;
            AnimationStudio = animationStudio;
            AnimationType = animationType;
        }
        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear + "\nAnimation Studio: " + this.AnimationStudio + "\nAnimation Type: " + this.AnimationType;
            //MessageBox.Show(infoString);
            System.Diagnostics.Process.Start("http://www.google.com");
        }
    }
}
