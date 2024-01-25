using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Alarm : Form
    {
        public DateTime alarmTime {  get; set; }
        public SoundPlayer snd {  get; set; }
        public Alarm()
        {
            InitializeComponent();
            dateTimePicker.CustomFormat = "HH:mm:ss";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Value = new DateTime(2024, 1, 25, 0, 0, 0);
            alarmTime = DateTime.MaxValue;
            snd = new SoundPlayer(Properties.Resources.alarm);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            alarmTime = dateTimePicker.Value;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
