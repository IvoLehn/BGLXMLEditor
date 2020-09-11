using System;
using System.Windows.Forms;

namespace BGLXMLEditor
{
    public partial class TestEcht : Form
    {
        public TestEcht()
        {
            InitializeComponent();
        }

        private void buttonTestSystem_Click(object sender, EventArgs e)
        {
            Form1.FileName = @"C:\Program Files\Manuelle Fakturierung\TestSystem\xml\Xml_Erstellen_BGL-Datei_Verzeichnisse_GruppeNutzer_Test.xml";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonEchtSystem_Click(object sender, EventArgs e)
        {
            Form1.FileName = @"C:\Program Files\Manuelle Fakturierung\EchtSystem\xml\Xml_Erstellen_BGL-Datei_Verzeichnisse_GruppeNutzer.xml";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
