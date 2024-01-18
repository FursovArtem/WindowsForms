using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public ContextMenu contextMenu = new ContextMenu();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int startX = Screen.PrimaryScreen.Bounds.Width - this.Width - 25;
            int startY = 25;
            this.SetDesktopLocation(startX, startY);
            ControlsVisibility(false);
            cbShowDate.Checked = true;

            contextMenu.MenuItems.Add("Show controls");
            contextMenu.MenuItems.Add("Show date");
            contextMenu.MenuItems.Add("Exit");
            contextMenu.MenuItems[0].Click += new EventHandler(showControls_Click);
            contextMenu.MenuItems[1].Click += new EventHandler(showDate_Click);
            contextMenu.MenuItems[2].Click += new EventHandler(exit_Click);
            trayIcon.ContextMenu = contextMenu;
        }
        void ControlsVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            btnExit.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.TransparencyKey = !visible ? SystemColors.Control : SystemColors.Window;
            this.FormBorderStyle = !visible ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            //label2.Text = DateTime.Now.ToString("d.MM.yyy ddd");
            //label2.Visible = cbShowDate.Checked;
            if(cbShowDate.Checked)
            {
                string date = DateTime.Now.ToString("d.MM.yyy ddd");
                label1.Text = $"{label1.Text}\n{date}";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            ControlsVisibility(false);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            //ControlsVisibility(true);
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ControlsVisibility(true);
        }

        private void showControls_Click(object sender, EventArgs e)
        {
            ControlsVisibility(true);
        }

        private void showDate_Click(object sender, EventArgs e)
        {
            cbShowDate.Checked = cbShowDate.Checked ? false : true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
