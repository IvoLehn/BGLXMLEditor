﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BGLXMLEditor
{
    class Company
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Group> Groups { get; set; }

        public Company(string name, int num, List<Group> groups)
        {
            this.Name = name;
            this.Number = num;
            this.Groups = groups;
        }
    }
}
