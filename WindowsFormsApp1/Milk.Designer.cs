
namespace WindowsFormsApp1
{
    partial class Milk
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(196, 290);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(374, 106);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Отиваш до рафтовете за млякото което ти поръча майка ти. Но чуваш странен глас.";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(418, 162);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(152, 95);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "Отиваш да провериш.";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(199, 162);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 95);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "Оставяш го намира и си купуваш млякото.";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2540431589_48451a4d5b_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.lbl3);
            this.Name = "Milk";
            this.Text = "Milk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
    }
}