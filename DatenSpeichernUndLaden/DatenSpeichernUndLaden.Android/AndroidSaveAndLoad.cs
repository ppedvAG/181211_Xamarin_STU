using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidSaveAndLoad))]
namespace DatenSpeichernUndLaden.Droid
{
    public class AndroidSaveAndLoad : ISaveAndLoad
    {
        public string Load(string filename)
        {

            // string fullPath = Path.Combine(Android.OS.Environment.DataDirectory.AbsolutePath);
            string fullpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), filename);
            return File.ReadAllText(fullpath);
        }

        public void Save(string filename, string content)
        {
            //string fullPath = Path.Combine(
            //    Android.OS.Environment.ExternalStorageDirectory.AbsolutePath,
            //    Android.OS.Environment.DirectoryPictures,
            //    filename);

            // /data/data/[applikationsname]/files
            string fullpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), filename);
            File.WriteAllText(fullpath, content);
        }
    }
}