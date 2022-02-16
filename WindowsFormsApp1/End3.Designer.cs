
namespace WindowsFormsApp1
{
    partial class End3
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
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(226, 249);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(330, 136);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "С баща ти се пребирате у дома и заживявате заедно с майка ти като едно време. :D";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // End3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fatherandson;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl6);
            this.Name = "End3";
            this.Text = "End3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl6;
    }
}