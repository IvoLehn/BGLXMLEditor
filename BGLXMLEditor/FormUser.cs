using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BGLXMLEditor
{
    public partial class FormUser : Form
    {
        public string Username { get; set; }
        public bool FK { get; set; }
        public FormUser(string name, bool fk)
        {
            this.Username = name;
            this.FK = fk;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Form1.FileName);

            if(string.IsNullOrEmpty(Username))
            {
                doc.Descendants("users").First().Add(new XElement("user", "", new XAttribute[] { new XAttribute("name", textBox1.Text), new XAttribute("FK", BoolToIntString(checkBoxFK.Checked)) }));
            }
            else
            {
                XElement xel = doc.Descendants("users").First().Descendants("user").Where(x => x.Attribute("name").Value == Username).First();

                xel.Attribute("name").Value = textBox1.Text;
                xel.Attribute("FK").Value = BoolToIntString(checkBoxFK.Checked);
            }

            doc.Save(Form1.FileName);
            this.Close();
        }

        private string BoolToIntString(bool value)
        {
            if(value)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            textBox1.Text = Username;
            checkBoxFK.Checked = FK;
            if(!string.IsNullOrEmpty(Username))
            {
                buttonAdd.Text = "Ändern";
                this.Text = "Benutzer Ändern";
            }
            else
            {
                buttonAdd.Text = "Hinzufügen";
                this.Text = "Benutzer Hinzufügen";
            }
        }
    }
}
