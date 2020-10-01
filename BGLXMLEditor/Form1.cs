using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BGLXMLEditor
{
    public partial class Form1 : Form
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * 
        *                                                  *
        *                  BGLXMLEditor                    *
        *                                                  *
        *        Tool zum Editieren der XML-Tabellen       *   
        *        des Programms Manuelle Fakturierung       *
        *                                                  *
        *                                                  *
        *            Erstellt von: Ivo Lehnberg            *
        *                                                  *
        *                  Firma: VRG-IT                   *
        *                                                  *
        * * * * * * * * * * * * * * * * * * * * * * * * *  */


        public Form1()
        {
            InitializeComponent();
        }
        
        //------------------------------------XMLFilename-------------------------------------//
        public static string FileName { get; set; }
        //---------------------------------Userlist/Grouplist---------------------------------//
        private List<User> Users { get; set; } = new List<User>();
        private List<Company> Companies { get; set; } = new List<Company>();
        //------------------------------------XMLDocument-------------------------------------//
        XDocument xDocument = new XDocument();
        //------------------------------------------------------------------------------------//


        //-----------------------------------Form Events--------------------------------------//
        private void Form1_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (System.Diagnostics.Process.GetProcessesByName("BGLXMLEditor").Count() <= 1)
            {
                TestEcht te = new TestEcht();
                te.ShowDialog();

                if (te.DialogResult == DialogResult.OK)
                {
                    xDocument = XDocument.Load(FileName);

                    if (FileName.ToLower().Contains("test"))
                    {
                        this.Text = "Testsystem";
                    }
                    else
                    {
                        this.Text = "Echtsystem";
                    }

                    ReloadTrees(true, true);
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show($"BGL XML Editor wird bereits von einem Nutzer ausgeführt. Bitte später probieren.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
        //------------------------------------------------------------------------------------//



        //------------------------------TreeViewEvents/Methods--------------------------------//
        private void ReloadTrees(bool loadUser, bool loadGroup)
        {
            xDocument = XDocument.Load(FileName);

            if (loadUser)
            {
                //Clear UserList
                Users.Clear();

                //Populate UserList
                foreach (var x in xDocument.Descendants("users").First().Descendants("user"))
                {
                    List<Group> xEsGroups = new List<Group>();

                    foreach (var g in x.Descendants("group"))
                    {
                        xEsGroups.Add(
                        new Group(g.Value.ToString())
                        );
                    }

                    bool expanded = false;

                    if (treeViewUser.Nodes.Find(x.Attributes("name").First().Value, false).Any())
                    {
                        expanded = treeViewUser.Nodes.Find(x.Attributes("name").First().Value, false).First().IsExpanded;
                    }

                    Users.Add(
                        new User(x.Attributes("name").First().Value, StringIntToBool(x.Attributes("FK").First().Value), xEsGroups, expanded)
                        );
                }

                //Clear TreeViewUser
                treeViewUser.Nodes.Clear();

                //Populate TreeViewUser
                foreach (User u in Users)
                {
                    var t = treeViewUser.Nodes.Add(u.Name, u.Name);
                    foreach (Group p in u.Groups)
                    {
                        t.Nodes.Add(p.Name, p.Name);
                        if (u.Expanded) t.Expand();
                    }
                }
            }

            if (loadGroup)
            {
                //Clear Company List
                Companies.Clear();

                //Populate Company List
                foreach (var x in xDocument.Descendants("firmen").First().Descendants("firma"))
                {
                    List<Group> xEsGroups = new List<Group>();

                    foreach (var g in x.Descendants("group"))
                    {
                        xEsGroups.Add(
                        new Group(g.Attributes("name").First().Value, g.Attributes("pfad").First().Value, StringIntToBool(g.Attributes("sachb").First().Value), g.Attributes("freigabepfad").First().Value, int.Parse(x.Attributes("nummer").First().Value))
                        );
                    }

                    bool expanded = false;

                    if (treeViewCompany.Nodes.Find(x.Attributes("nummer").First().Value, false).Any())
                    {
                        expanded = treeViewCompany.Nodes.Find(x.Attributes("nummer").First().Value, false).First().IsExpanded;
                    }

                    Companies.Add(
                        new Company(x.Attributes("name").First().Value, int.Parse(x.Attributes("nummer").First().Value), xEsGroups, expanded)
                        );
                }

                //Clear TreeViewCompany
                treeViewCompany.Nodes.Clear();

                //Populate TreeViewCompany
                foreach (Company c in Companies)
                {
                    var t = treeViewCompany.Nodes.Add(c.Number.ToString(), c.Name);

                    foreach (Group p in c.Groups)
                    {
                        t.Nodes.Add(p.Name, p.Name);
                        if (c.Expanded) t.Expand();
                    }
                }

            }
        }
        private void treeViewCompanyAndUser_AfterExpand(object sender, TreeViewEventArgs e)
        {
            (sender as TreeView).SelectedNode = e.Node;
        }
        //------------------------------------------------------------------------------------//



        //--------------------------------UserButtonMethods-----------------------------------//
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormUser fUser = new FormUser(string.Empty, false);
            fUser.ShowDialog();
            ReloadTrees(true, false);
        }
        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if (treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 0)
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
        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if(treeViewUser.SelectedNode != null && treeViewUser.SelectedNode.Level == 0)
            {
                string name = treeViewUser.SelectedNode.Name;
                bool fk = Users.Where(x => x.Name == name).First().FK;

                FormUser fUser = new FormUser(name, fk);
                fUser.ShowDialog();
                ReloadTrees(true, false);
            }
            else
            {
                MessageBox.Show("Bitte Benutzer auswählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //------------------------------------------------------------------------------------//



        //--------------------------------GroupButtonMethods----------------------------------//
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormGroup fGroup = new FormGroup();
            fGroup.ShowDialog();
            ReloadTrees(false, true);
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
        //------------------------------------------------------------------------------------//



        //-----------------------------Assing/RemoveGroupMethods------------------------------//
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(treeViewCompany.SelectedNode != null && treeViewCompany.SelectedNode.Level == 1 && treeViewUser.SelectedNode != null)
            {
                if (treeViewUser.SelectedNode.Level == 1) treeViewUser.SelectedNode = treeViewUser.SelectedNode.Parent;

                string selectedUserString = treeViewUser.SelectedNode.Name;
                string selectedGroupString = treeViewCompany.SelectedNode.Name;

                XElement selectedGroup = xDocument.Descendants("firmen").First().Descendants("firma").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Parent.Text).First().Descendants("group").Where(x => x.Attribute("name").Value == treeViewCompany.SelectedNode.Name).First();
                XElement selectedUser = xDocument.Descendants("users").First().Descendants("user").Where(x => x.Attribute("name").Value == treeViewUser.SelectedNode.Name).First();

                if(!selectedUser.Elements("group").Where(x => x.Value == selectedGroupString).Any())
                {
                    selectedUser.Add(new XElement("group", "") { Value = selectedGroup.Attribute("name").Value });

                    xDocument.Save(FileName);
                    ReloadTrees(true, false);

                    TreeNode node = treeViewUser.Nodes.Find(selectedUserString, false).First();
                    node.Expand();
                    treeViewUser.SelectedNode = node;
                }
                else
                {
                    MessageBox.Show($"{selectedUserString} besitzt bereits die Gruppe {selectedGroupString}", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
        //------------------------------------------------------------------------------------//



        //--------------------------------Auxillary Methods-----------------------------------//
        private bool StringIntToBool(string intValue)
        {
            if (intValue == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //------------------------------------------------------------------------------------//
    }
}
