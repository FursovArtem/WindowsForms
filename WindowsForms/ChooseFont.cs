using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ChooseFont : Form
    {
        string[] allFonts;
        public System.Drawing.Font NewFont { get; set; }
        public ChooseFont()
        {
            InitializeComponent();
            allFonts = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.?tf", SearchOption.AllDirectories);
            foreach(string file in allFonts) cbFonts.Items.Add(file.Split('\\').Last());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string currentDir = Directory.GetCurrentDirectory();
            //MessageBox.Show(this, currentDir);
            NewFont = lblExample.Font;
            this.Close();
        }

        private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFullName.Text = allFonts[cbFonts.SelectedIndex];
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(allFonts[cbFonts.SelectedIndex]);
            NewFont = new Font(pfc.Families[0], 48);
            lblExample.Font = NewFont;
        }
    }
}
