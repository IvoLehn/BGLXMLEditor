using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BGLXMLEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string FileName { get; set; }
        List<User> users = new List<User>();
        List<Company> companies = new List<Company>();
        XDocument xDocument = new XDocument();

        private void Form1_Load(object sender, EventArgs e)
        {
            TestEcht te = new TestEcht();
            te.ShowDialog();

            xDocument = XDocument.Load(FileName);

            if (FileName.ToLower().Contains("test"))
            {
                this.Text = "TestSystem";
            }
            else
            {
                this.Text = "EchtSystem";
            }

            ReloadTrees(true, true);
        }



        private bool StringIntToBool(string intValue)
        {
            if(intValue == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormUser fUser = new FormUser(string.Empty, false);
            fUser.ShowDialog();
            ReloadTrees(true, false);
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if(treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 0)
            {
                string name = treeViewUser.SelectedNode.Name;
                bool fk = users.Where(x => x.Name == name).First().FK;

                FormUser fUser = new FormUser(name, fk);
                fUser.ShowDialog();
                ReloadTrees(true, false);
            }
            else
            {
                MessageBox.Show("Bitte Benutzer auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if(treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 0)
            {
                string name = treeViewUser.SelectedNode.Name;
                XElement xel = xDocument.Descendants("users").First().Descendants("user").Where(x => x.Attribute("name").Value == name).First();
                xel.Remove();
                xDocument.Save(FileName);
                ReloadTrees(true, false);
            }
            else
            {
                MessageBox.Show("Bitte Benutzer auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReloadTrees(bool user, bool group)
        {
            xDocument = XDocument.Load(FileName);

            if(user)
            {
                treeViewUser.Nodes.Clear();
                users.Clear();

                foreach (var x in xDocument.Descendants("users").First().Descendants("user"))
                {
                    List<Group> xEsGroups = new List<Group>();

                    foreach (var g in x.Descendants("group"))
                    {
                        xEsGroups.Add(
                        new Group(g.Value.ToString())
                        );
                    }


                    users.Add(
                        new User(x.Attributes("name").First().Value, StringIntToBool(x.Attributes("FK").First().Value), xEsGroups)
                        );
                }


                foreach (User u in users)
                {
                    var t = treeViewUser.Nodes.Add(u.Name, u.Name);
                    foreach (Group p in u.Groups)
                    {
                        t.Nodes.Add(p.Name, p.Name);
                    }
                }
            }

            if(group)
            {
                treeViewCompany.Nodes.Clear();
                companies.Clear();

                foreach (var x in xDocument.Descendants("firmen").First().Descendants("firma"))
                {
                    List<Group> xEsGroups = new List<Group>();

                    foreach (var g in x.Descendants("group"))
                    {
                        xEsGroups.Add(
                        new Group(g.Attributes("name").First().Value, g.Attributes("pfad").First().Value, StringIntToBool(g.Attributes("sachb").First().Value), g.Attributes("freigabepfad").First().Value, int.Parse(x.Attributes("nummer").First().Value))
                        );
                    }

                    companies.Add(
                        new Company(x.Attributes("name").First().Value, int.Parse(x.Attributes("nummer").First().Value), xEsGroups)
                        );
                }

                foreach (Company c in companies)
                {
                    var t = treeViewCompany.Nodes.Add(c.Number.ToString(), c.Name);

                    foreach (Group p in c.Groups)
                    {
                        t.Nodes.Add(p.Name, p.Name);
                    }
                }

            }















        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            if(treeViewCompany.SelectedNode != null && treeViewCompany.SelectedNode.Level == 1)
            {
                string name = treeViewCompany.SelectedNode.Name;
                XElement xel = xDocument.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Parent.Text).First().Descendants("group").Where(x => x.Attribute("name").Value == name).First();
                xel.Remove();
                xDocument.Save(FileName);
                ReloadTrees(false, true);
            }
            else
            {
                MessageBox.Show("Bitte Gruppe auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            if(treeViewCompany.SelectedNode != null && treeViewCompany.SelectedNode.Level == 1)
            {
                XElement xel = xDocument.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Parent.Text).First().Descendants("group").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Name).First();

                FormGroup fGroup = new FormGroup(xel.Attribute("name").Value, xel.Attribute("pfad").Value, xel.Attribute("freigabepfad").Value, xel.Parent.Attribute("name").Value, StringIntToBool(xel.Attribute("sachb").Value));
                fGroup.ShowDialog();
                ReloadTrees(false, true);
            }
            else
            {
                MessageBox.Show("Bitte Gruppe auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormGroup fGroup = new FormGroup();
            fGroup.ShowDialog();
            ReloadTrees(false, true);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(treeViewCompany.SelectedNode != null && treeViewCompany.SelectedNode.Level == 1 && treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 0)
            {
                XElement selectedGroup = xDocument.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Parent.Text).First().Descendants("group").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Name).First();
                XElement selectedUser = xDocument.Descendants("users").First().Descendants("user").Where(x => x.Attribute("name").Value == treeViewUser.SelectedNode.Name).First();

                selectedUser.Add(new XElement("group", "") { Value = selectedGroup.Attribute("name").Value });

                xDocument.Save(FileName);
                ReloadTrees(true, false);
            }
            else
            {
                MessageBox.Show("Bitte links Benutzer und rechts Gruppe auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 1)
            {
                XElement selectedUser = xDocument.Descendants("users").First().Descendants("user").Where(x => x.Attribute("name").Value == treeViewUser.SelectedNode.Parent.Name).First();
                selectedUser.Descendants("group").Where(x => x.Value == treeViewUser.SelectedNode.Name).First().Remove();

                xDocument.Save(FileName);
                ReloadTrees(true, false);
            }
            else
            {
                MessageBox.Show("Bitte links Gruppe eines Benutzers auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
