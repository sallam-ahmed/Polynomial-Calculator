﻿namespace CalculatorUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LogPanel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.polynomial1Text = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.polynomial2Text = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resPolyText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.glassButton1 = new Glass.GlassButton();
            this.btnPoly2 = new Glass.GlassButton();
            this.btnPoly1 = new Glass.GlassButton();
            this.btnModulous = new Glass.GlassButton();
            this.btnDiv = new Glass.GlassButton();
            this.btnMultiply = new Glass.GlassButton();
            this.btnSubtract = new Glass.GlassButton();
            this.btnAdd = new Glass.GlassButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rootsTextBox = new System.Windows.Forms.TextBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusBar.Location = new System.Drawing.Point(0, 441);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusBar.Size = new System.Drawing.Size(786, 25);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel1.Text = "Date / Time";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel2.Text = "Loading history";
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(786, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearLogToolStripMenuItem,
            this.toolStripMenuItem2,
            this.customizeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.customizeToolStripMenuItem.Text = "Customize";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.licenseToolStripMenuItem.Text = "&License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.67123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.32877F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 413);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LogPanel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(525, 407);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LogPanel
            // 
            this.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPanel.Location = new System.Drawing.Point(3, 232);
            this.LogPanel.Multiline = true;
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.ReadOnly = true;
            this.LogPanel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogPanel.Size = new System.Drawing.Size(519, 172);
            this.LogPanel.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.polynomial1Text);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Polyonomial 1";
            // 
            // polynomial1Text
            // 
            this.polynomial1Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polynomial1Text.Location = new System.Drawing.Point(3, 18);
            this.polynomial1Text.Multiline = false;
            this.polynomial1Text.Name = "polynomial1Text";
            this.polynomial1Text.Size = new System.Drawing.Size(513, 45);
            this.polynomial1Text.TabIndex = 0;
            this.polynomial1Text.Tag = "Poly1";
            this.polynomial1Text.Text = "Polynomial1";
            this.polynomial1Text.TextChanged += new System.EventHandler(this.SuperScriptOnX);
            this.polynomial1Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseOnEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.polynomial2Text);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polynomial 2";
            // 
            // polynomial2Text
            // 
            this.polynomial2Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polynomial2Text.Location = new System.Drawing.Point(3, 18);
            this.polynomial2Text.Multiline = false;
            this.polynomial2Text.Name = "polynomial2Text";
            this.polynomial2Text.Size = new System.Drawing.Size(513, 45);
            this.polynomial2Text.TabIndex = 1;
            this.polynomial2Text.Tag = "Poly2";
            this.polynomial2Text.Text = "Polynomial2";
            this.polynomial2Text.TextChanged += new System.EventHandler(this.SuperScriptOnX);
            this.polynomial2Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseOnEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resPolyText);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result polynomial";
            // 
            // resPolyText
            // 
            this.resPolyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resPolyText.Location = new System.Drawing.Point(3, 18);
            this.resPolyText.Name = "resPolyText";
            this.resPolyText.ReadOnly = true;
            this.resPolyText.Size = new System.Drawing.Size(513, 58);
            this.resPolyText.TabIndex = 0;
            this.resPolyText.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.historyListBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(534, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 407);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.glassButton1);
            this.groupBox5.Controls.Add(this.btnPoly2);
            this.groupBox5.Controls.Add(this.btnPoly1);
            this.groupBox5.Controls.Add(this.btnModulous);
            this.groupBox5.Controls.Add(this.btnDiv);
            this.groupBox5.Controls.Add(this.btnMultiply);
            this.groupBox5.Controls.Add(this.btnSubtract);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 179);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operations";
            // 
            // glassButton1
            // 
            this.glassButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.glassButton1.Location = new System.Drawing.Point(115, 106);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(105, 31);
            this.glassButton1.TabIndex = 7;
            this.glassButton1.Tag = "GCD";
            this.glassButton1.Text = "GCD";
            this.glassButton1.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnPoly2
            // 
            this.btnPoly2.GlowColor = System.Drawing.Color.Purple;
            this.btnPoly2.Location = new System.Drawing.Point(115, 143);
            this.btnPoly2.Name = "btnPoly2";
            this.btnPoly2.Size = new System.Drawing.Size(105, 31);
            this.btnPoly2.TabIndex = 9;
            this.btnPoly2.Tag = "Find X2";
            this.btnPoly2.Text = "Poly2. roots";
            this.btnPoly2.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnPoly1
            // 
            this.btnPoly1.GlowColor = System.Drawing.Color.Purple;
            this.btnPoly1.Location = new System.Drawing.Point(4, 143);
            this.btnPoly1.Name = "btnPoly1";
            this.btnPoly1.Size = new System.Drawing.Size(105, 31);
            this.btnPoly1.TabIndex = 8;
            this.btnPoly1.Tag = "Find X1";
            this.btnPoly1.Text = "Poly.1 roots";
            this.btnPoly1.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnModulous
            // 
            this.btnModulous.GlowColor = System.Drawing.Color.Olive;
            this.btnModulous.Location = new System.Drawing.Point(4, 106);
            this.btnModulous.Name = "btnModulous";
            this.btnModulous.Size = new System.Drawing.Size(105, 31);
            this.btnModulous.TabIndex = 6;
            this.btnModulous.Tag = "Modulus";
            this.btnModulous.Text = "Modulus";
            this.btnModulous.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnDiv
            // 
            this.btnDiv.GlowColor = System.Drawing.Color.Lime;
            this.btnDiv.Location = new System.Drawing.Point(115, 69);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(105, 31);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Tag = "Division";
            this.btnDiv.Text = "Divide";
            this.btnDiv.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnMultiply
            // 
            this.btnMultiply.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMultiply.Location = new System.Drawing.Point(4, 69);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(105, 31);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Tag = "Multiply";
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnSubtract
            // 
            this.btnSubtract.GlowColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(115, 32);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(105, 31);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Tag = "Subtract";
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.Click += new System.EventHandler(this.PerformOperation);
            // 
            // btnAdd
            // 
            this.btnAdd.GlowColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(4, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.PerformOperation);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rootsTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 111);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Root finding";
            // 
            // rootsTextBox
            // 
            this.rootsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootsTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.rootsTextBox.Location = new System.Drawing.Point(3, 18);
            this.rootsTextBox.Multiline = true;
            this.rootsTextBox.Name = "rootsTextBox";
            this.rootsTextBox.ReadOnly = true;
            this.rootsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rootsTextBox.Size = new System.Drawing.Size(237, 90);
            this.rootsTextBox.TabIndex = 3;
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 22;
            this.historyListBox.Location = new System.Drawing.Point(3, 120);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.ScrollAlwaysVisible = true;
            this.historyListBox.Size = new System.Drawing.Size(243, 99);
            this.historyListBox.TabIndex = 1;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Polynomial Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox LogPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox polynomial1Text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox polynomial2Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox resPolyText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private Glass.GlassButton btnPoly2;
        private Glass.GlassButton btnPoly1;
        private Glass.GlassButton btnModulous;
        private Glass.GlassButton btnDiv;
        private Glass.GlassButton btnMultiply;
        private Glass.GlassButton btnSubtract;
        private Glass.GlassButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox rootsTextBox;
        private System.Windows.Forms.ListBox historyListBox;
        private Glass.GlassButton glassButton1;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
    }
}

