﻿namespace WindowsFormsApp4
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГлавнуюФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посланиеОтРазработчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(655, 239);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Данная программа была создана в конце мая 2020 года и предназначена для работы с " +
    "одномерными массивами";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГлавнуюФормуToolStripMenuItem,
            this.посланиеОтРазработчикаToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // наГлавнуюФормуToolStripMenuItem
            // 
            this.наГлавнуюФормуToolStripMenuItem.Name = "наГлавнуюФормуToolStripMenuItem";
            this.наГлавнуюФормуToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.наГлавнуюФормуToolStripMenuItem.Text = "На главную форму";
            this.наГлавнуюФормуToolStripMenuItem.Click += new System.EventHandler(this.наГлавнуюФормуToolStripMenuItem_Click);
            // 
            // посланиеОтРазработчикаToolStripMenuItem
            // 
            this.посланиеОтРазработчикаToolStripMenuItem.Name = "посланиеОтРазработчикаToolStripMenuItem";
            this.посланиеОтРазработчикаToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.посланиеОтРазработчикаToolStripMenuItem.Text = "Послание от разработчика";
            this.посланиеОтРазработчикаToolStripMenuItem.Click += new System.EventHandler(this.посланиеОтРазработчикаToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 291);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Справка";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГлавнуюФормуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посланиеОтРазработчикаToolStripMenuItem;
    }
}