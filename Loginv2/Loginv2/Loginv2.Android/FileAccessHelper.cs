using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Loginv2.Droid
{
    class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename) 
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //adroid/data/algumacoisa/  esse argumento trás o caminho do repositório

            return System.IO.Path.Combine(path, filename);
        }
    }
}