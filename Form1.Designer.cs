namespace Notepad
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åpneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 27);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(394, 318);
            this.tbInput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagreToolStripMenuItem,
            this.åpneToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // lagreToolStripMenuItem
            // 
            this.lagreToolStripMenuItem.Name = "lagreToolStripMenuItem";
            this.lagreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lagreToolStripMenuItem.Text = "Lagre";
            this.lagreToolStripMenuItem.Click += new System.EventHandler(this.lagreToolStripMenuItem_Click);
            // 
            // åpneToolStripMenuItem
            // 
            this.åpneToolStripMenuItem.Name = "åpneToolStripMenuItem";
            this.åpneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.åpneToolStripMenuItem.Text = "Åpne";
            this.åpneToolStripMenuItem.Click += new System.EventHandler(this.åpneToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 357);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad--";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem åpneToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

