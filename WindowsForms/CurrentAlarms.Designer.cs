namespace WindowsForms
{
    partial class CurrentAlarms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCurrentAlarms = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listCurrentAlarms
            // 
            this.listCurrentAlarms.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listCurrentAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listCurrentAlarms.HideSelection = false;
            this.listCurrentAlarms.Location = new System.Drawing.Point(12, 12);
            this.listCurrentAlarms.Name = "listCurrentAlarms";
            this.listCurrentAlarms.Size = new System.Drawing.Size(708, 161);
            this.listCurrentAlarms.TabIndex = 0;
            this.listCurrentAlarms.UseCompatibleStateImageBehavior = false;
            // 
            // CurrentAlarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 185);
            this.Controls.Add(this.listCurrentAlarms);
            this.Name = "CurrentAlarms";
            this.Text = "CurrentAlarms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCurrentAlarms;
    }
}