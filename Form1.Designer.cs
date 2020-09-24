namespace IP_sorter
{
    partial class Form1
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
            this.ipbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ipbox.ForeColor = System.Drawing.Color.White;
            this.ipbox.Location = new System.Drawing.Point(12, 12);
            this.ipbox.Name = "ipbox";
            this.ipbox.ReadOnly = true;
            this.ipbox.Size = new System.Drawing.Size(1790, 240);
            this.ipbox.TabIndex = 0;
            this.ipbox.Text = "";
            this.ipbox.TextChanged += new System.EventHandler(this.ipbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 264);
            this.Controls.Add(this.ipbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "IP Sorter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ipbox;
    }
}

