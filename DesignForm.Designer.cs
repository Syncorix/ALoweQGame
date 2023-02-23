
namespace ALoweQGame
{
    partial class DesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.columnTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowTextbox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GreenBoxButton = new System.Windows.Forms.Button();
            this.RedBoxButton = new System.Windows.Forms.Button();
            this.GreenDoorButton = new System.Windows.Forms.Button();
            this.RedDoorButton = new System.Windows.Forms.Button();
            this.WallButton = new System.Windows.Forms.Button();
            this.NoneButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnTextbox
            // 
            this.columnTextbox.Location = new System.Drawing.Point(76, 29);
            this.columnTextbox.Name = "columnTextbox";
            this.columnTextbox.Size = new System.Drawing.Size(100, 20);
            this.columnTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rows:";
            // 
            // rowTextbox
            // 
            this.rowTextbox.Location = new System.Drawing.Point(241, 29);
            this.rowTextbox.Name = "rowTextbox";
            this.rowTextbox.Size = new System.Drawing.Size(100, 20);
            this.rowTextbox.TabIndex = 9;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(363, 24);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(118, 28);
            this.GenerateButton.TabIndex = 10;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GreenBoxButton);
            this.groupBox1.Controls.Add(this.RedBoxButton);
            this.groupBox1.Controls.Add(this.GreenDoorButton);
            this.groupBox1.Controls.Add(this.RedDoorButton);
            this.groupBox1.Controls.Add(this.WallButton);
            this.groupBox1.Controls.Add(this.NoneButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 351);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toolbox";
            // 
            // GreenBoxButton
            // 
            this.GreenBoxButton.Image = global::ALoweQGame.Properties.Resources.Green_Box;
            this.GreenBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GreenBoxButton.Location = new System.Drawing.Point(22, 293);
            this.GreenBoxButton.Name = "GreenBoxButton";
            this.GreenBoxButton.Size = new System.Drawing.Size(120, 50);
            this.GreenBoxButton.TabIndex = 5;
            this.GreenBoxButton.Tag = "5";
            this.GreenBoxButton.Text = "Green Box";
            this.GreenBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GreenBoxButton.UseVisualStyleBackColor = true;
            this.GreenBoxButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // RedBoxButton
            // 
            this.RedBoxButton.Image = global::ALoweQGame.Properties.Resources.Red_Box;
            this.RedBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RedBoxButton.Location = new System.Drawing.Point(22, 237);
            this.RedBoxButton.Name = "RedBoxButton";
            this.RedBoxButton.Size = new System.Drawing.Size(120, 50);
            this.RedBoxButton.TabIndex = 4;
            this.RedBoxButton.Tag = "4";
            this.RedBoxButton.Text = "Red Box";
            this.RedBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RedBoxButton.UseVisualStyleBackColor = true;
            this.RedBoxButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // GreenDoorButton
            // 
            this.GreenDoorButton.Image = global::ALoweQGame.Properties.Resources.Green_Door;
            this.GreenDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GreenDoorButton.Location = new System.Drawing.Point(22, 181);
            this.GreenDoorButton.Name = "GreenDoorButton";
            this.GreenDoorButton.Size = new System.Drawing.Size(120, 50);
            this.GreenDoorButton.TabIndex = 3;
            this.GreenDoorButton.Tag = "3";
            this.GreenDoorButton.Text = "Green Door";
            this.GreenDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GreenDoorButton.UseVisualStyleBackColor = true;
            this.GreenDoorButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // RedDoorButton
            // 
            this.RedDoorButton.Image = global::ALoweQGame.Properties.Resources.Red_Door;
            this.RedDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RedDoorButton.Location = new System.Drawing.Point(22, 125);
            this.RedDoorButton.Name = "RedDoorButton";
            this.RedDoorButton.Size = new System.Drawing.Size(120, 50);
            this.RedDoorButton.TabIndex = 2;
            this.RedDoorButton.Tag = "2";
            this.RedDoorButton.Text = "Red Door";
            this.RedDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RedDoorButton.UseVisualStyleBackColor = true;
            this.RedDoorButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // WallButton
            // 
            this.WallButton.Image = global::ALoweQGame.Properties.Resources.Wall;
            this.WallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WallButton.Location = new System.Drawing.Point(22, 69);
            this.WallButton.Name = "WallButton";
            this.WallButton.Size = new System.Drawing.Size(120, 50);
            this.WallButton.TabIndex = 1;
            this.WallButton.Tag = "1";
            this.WallButton.Text = "Wall";
            this.WallButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WallButton.UseVisualStyleBackColor = true;
            this.WallButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // NoneButton
            // 
            this.NoneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoneButton.Location = new System.Drawing.Point(22, 13);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoneButton.Size = new System.Drawing.Size(120, 50);
            this.NoneButton.TabIndex = 0;
            this.NoneButton.Tag = "0";
            this.NoneButton.Text = "None";
            this.NoneButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoneButton.UseVisualStyleBackColor = true;
            this.NoneButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.ToolTipText = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // boxPanel
            // 
            this.boxPanel.AutoScroll = true;
            this.boxPanel.Location = new System.Drawing.Point(180, 95);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(529, 338);
            this.boxPanel.TabIndex = 13;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.boxPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.rowTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnTextbox);
            this.MaximizeBox = false;
            this.Name = "DesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q Game Design";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoneButton;
        private System.Windows.Forms.Button RedDoorButton;
        private System.Windows.Forms.Button GreenDoorButton;
        private System.Windows.Forms.Button RedBoxButton;
        private System.Windows.Forms.Button GreenBoxButton;
        private System.Windows.Forms.Button WallButton;
        private System.Windows.Forms.TextBox columnTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowTextbox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel boxPanel;
    }
}