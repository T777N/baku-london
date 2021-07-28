
namespace WindowsFormsApp1
{
    partial class TIME
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(205, 83);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(236, 96);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "Time";
            // 
            // BakuBtn
            // 
            this.BakuBtn.BackColor = System.Drawing.Color.Transparent;
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakuBtn.Location = new System.Drawing.Point(179, 224);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(139, 51);
            this.BakuBtn.TabIndex = 1;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = false;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // LondonBtn
            // 
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonBtn.Location = new System.Drawing.Point(461, 224);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(139, 51);
            this.LondonBtn.TabIndex = 2;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // TIME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Controls.Add(this.timeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TIME";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

