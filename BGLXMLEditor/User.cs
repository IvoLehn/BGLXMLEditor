using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLXMLEditor
{
    class User
    {
        public string Name { get; set; }
        public bool FK { get; set; }
        public List<Group> Groups { get; set; }
        public bool Expanded { get; set; }

        public User(string name, bool fk, List<Group> groups, bool exp)
        {
            this.Name = name;
            this.FK = fk;
            this.Groups = groups;
            this.Expanded = exp;
        }
    }
}
