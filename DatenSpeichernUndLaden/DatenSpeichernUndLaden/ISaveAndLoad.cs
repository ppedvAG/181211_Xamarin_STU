using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    public interface ISaveAndLoad
    {
        void Save(string filename, string content);
        string Load(string filename);
    }
}
