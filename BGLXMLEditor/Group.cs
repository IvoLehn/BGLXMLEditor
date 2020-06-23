using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLXMLEditor
{
    class Group
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool Sachb { get; set; }
        public string ReleasePath { get; set; }
        public int CompNum { get; set; }

        public Group(string name, string path, bool sachb, string releasepath, int compNum)
        {
            this.Name = name;
            this.Path = path;
            this.Sachb = sachb;
            this.ReleasePath = releasepath;
            this.CompNum = compNum;
        }

        public Group(string name)
        {
            this.Name = name;
        }
    }
}
