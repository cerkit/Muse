﻿
namespace WinMuse
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
            this.museOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.museSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.midiSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtAlgorithm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // museOpenFileDialog
            // 
            this.museOpenFileDialog.FileName = "openFileDialog1";
            this.museOpenFileDialog.Filter = "Muse files|*.mus|All files|*.*";
            // 
            // museSaveFileDialog
            // 
            this.museSaveFileDialog.Filter = "Muse files|*.mus|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuExport});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(108, 22);
            this.menuFileNew.Text = "&New";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(108, 22);
            this.menuFileOpen.Tag = "Open";
            this.menuFileOpen.Text = "&Open";
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(108, 22);
            this.menuFileSave.Tag = "Save";
            this.menuFileSave.Text = "&Save";
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(108, 22);
            this.menuExport.Text = "E&xport";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAlgorithm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBaseNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSongName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 117);
            this.panel1.TabIndex = 2;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(75, 73);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(201, 23);
            this.txtDuration.TabIndex = 13;
            this.txtDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDuration_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duration";
            // 
            // txtBaseNote
            // 
            this.txtBaseNote.Location = new System.Drawing.Point(75, 44);
            this.txtBaseNote.Name = "txtBaseNote";
            this.txtBaseNote.Size = new System.Drawing.Size(201, 23);
            this.txtBaseNote.TabIndex = 11;
            this.txtBaseNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBaseNote_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Base Note";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(75, 15);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(201, 23);
            this.txtSongName.TabIndex = 9;
            this.txtSongName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSongName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 141);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 309);
            this.pnlMain.TabIndex = 3;
            // 
            // midiSaveFileDialog
            // 
            this.midiSaveFileDialog.Filter = "MIDI files|*.mid|All files|*.*";
            // 
            // txtAlgorithm
            // 
            this.txtAlgorithm.Location = new System.Drawing.Point(360, 18);
            this.txtAlgorithm.Name = "txtAlgorithm";
            this.txtAlgorithm.Size = new System.Drawing.Size(59, 23);
            this.txtAlgorithm.TabIndex = 15;
            this.txtAlgorithm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAlgorithm_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Algorithm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog museOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog museSaveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.SaveFileDialog midiSaveFileDialog;
        private System.Windows.Forms.TextBox txtAlgorithm;
        private System.Windows.Forms.Label label4;
    }
}