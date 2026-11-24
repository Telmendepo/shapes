using System.Drawing;
using System.Windows.Forms;

namespace shapes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new MenuStrip();
            this.toolsToolStripMenuItem = new ToolStripMenuItem();
            this.customizeToolStripMenuItem = new ToolStripMenuItem();
            this.optionsToolStripMenuItem = new ToolStripMenuItem();
            this.lineToolStripMenuItem = new ToolStripMenuItem();
            this.circleToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.өнгөToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripComboBox1 = new ToolStripComboBox();
            this.colorDialog1 = new ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new Size(20, 20);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // toolsToolStripMenuItem
            //
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.customizeToolStripMenuItem,
                this.optionsToolStripMenuItem,
                this.lineToolStripMenuItem,
                this.circleToolStripMenuItem,
                this.toolStripSeparator1,
                this.өнгөToolStripMenuItem,
                this.toolStripComboBox1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new Size(59, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            //
            // customizeToolStripMenuItem (Харандаа)
            //
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new Size(180, 26);
            this.customizeToolStripMenuItem.Text = "Харандаа";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            //
            // optionsToolStripMenuItem (Тэгш өнцөг)
            //
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new Size(180, 26);
            this.optionsToolStripMenuItem.Text = "Тэгш өнцөг";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            //
            // lineToolStripMenuItem (Шулуун)
            //
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new Size(180, 26);
            this.lineToolStripMenuItem.Text = "Шулуун";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            //
            // circleToolStripMenuItem (Дугуй)
            //
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new Size(180, 26);
            this.circleToolStripMenuItem.Text = "Дугуй";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(177, 6);
            //
            // өнгөToolStripMenuItem (Өнгө)
            //
            this.өнгөToolStripMenuItem.Name = "өнгөToolStripMenuItem";
            this.өнгөToolStripMenuItem.Size = new Size(180, 26);
            this.өнгөToolStripMenuItem.Text = "Өнгө";
            this.өнгөToolStripMenuItem.Click += new System.EventHandler(this.өнгөToolStripMenuItem_Click);
            //
            // toolStripComboBox1 (өргөн сонгох)
            //
            this.toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            //
            // colorDialog1
            //
            this.colorDialog1.FullOpen = true;
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem lineToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem өнгөToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ColorDialog colorDialog1;
    }
}