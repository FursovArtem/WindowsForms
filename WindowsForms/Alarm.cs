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
        public DateTime[] alarmTime {  get; set; }
        public int alarmCount { get; set; }
        public SoundPlayer snd {  get; set; }
        public CurrentAlarms ca { get; set; }
        public Alarm()
        {
            InitializeComponent();
            dateTimePicker.CustomFormat = "HH:mm:ss";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Value = DateTime.Now;
            alarmCount = 0;
            alarmTime = new DateTime[10];
            for (int i = 0; i < 10; i++) alarmTime[i] = DateTime.Now;
            snd = new SoundPlayer(Properties.Resources.alarm);
            ca = new CurrentAlarms();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            alarmTime[alarmCount] = dateTimePicker.Value;
            if (alarmCount != 9) alarmCount++;
            else
            {
                alarmCount = 0;
                ca.lca.Items.Clear();
            }
            ca.lca.Items.Add(dateTimePicker.Value.ToString());
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
