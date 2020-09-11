using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BGLXMLEditor
{
    public partial class FormGroup : Form
    {
        public string Path { get; set; }
        public string ReleasePath { get; set; }
        public string GroupName { get; set; }
        public string Company { get; set; }
        public bool SachB { get; set; }

        public FormGroup(string name, string path, string rPath, string comp, bool sachB)
        {
            this.Path = path;
            this.GroupName = name;
            this.Company = comp;
            this.ReleasePath = rPath;
            this.SachB = sachB;
            InitializeComponent();
        }

        public FormGroup()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(GroupName))
            {
                buttonAdd.Text = "Hinzufügen";
                this.Text = "Gruppe hinzufügen";
            }
            else
            {
                buttonAdd.Text = "Ändern";
                this.Text = "Gruppe Ändern";
                comboBoxCompany.Enabled = false;
            }

            List<string> comps = XDocument.Load(Form1.FileName).Descendants("firmen").First().Descendants("firma").Attributes("name").Select(x => x.Value).ToList();

            comboBoxCompany.DataSource = comps;

            if(string.IsNullOrEmpty(this.Company))
            {
                comboBoxCompany.SelectedIndex = 0;
            }
            else
            {
                comboBoxCompany.SelectedIndex = comboBoxCompany.FindStringExact(this.Company);
            }

            textBoxGroupName.Text = this.GroupName;
            textBoxPath.Text = this.Path;
            textBoxReleasePath.Text = this.ReleasePath;
            checkBoxSachb.Checked = SachB;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Form1.FileName);

            if(string.IsNullOrEmpty(this.GroupName))
            {
                if (!string.IsNullOrEmpty(comboBoxCompany.Text))
                {
                    doc.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == comboBoxCompany.Text).First().Add(new XElement("group", "", new XAttribute[] { new XAttribute("name", textBoxGroupName.Text), new XAttribute("pfad", textBoxPath.Text), new XAttribute("freigabepfad", textBoxReleasePath.Text), new XAttribute("sachb", StringBoolToInt(checkBoxSachb.Checked)) }));
                }
            }
            else
            {
                XElement xElement = doc.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == Company).First().Descendants("group").Where(x => x.Attribute("name").Value == this.GroupName).First();

                xElement.Attribute("name").Value = textBoxGroupName.Text;
                xElement.Attribute("pfad").Value = textBoxPath.Text;
                xElement.Attribute("freigabepfad").Value = textBoxReleasePath.Text;
                xElement.Attribute("sachb").Value = StringBoolToInt(checkBoxSachb.Checked).ToString();
            }

            doc.Save(Form1.FileName);
            this.Close();
        }

        private int StringBoolToInt(bool value)
        {
            if(value)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
