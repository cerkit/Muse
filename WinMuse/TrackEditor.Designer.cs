
namespace WinMuse
{
    partial class TrackEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutPosition = new System.Windows.Forms.TextBox();
            this.txtInPosition = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.txtOctave = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.trackListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 206);
            this.panel1.TabIndex = 0;
            // 
            // trackListBox
            // 
            this.trackListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackListBox.FormattingEnabled = true;
            this.trackListBox.ItemHeight = 15;
            this.trackListBox.Location = new System.Drawing.Point(0, 0);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.Size = new System.Drawing.Size(200, 169);
            this.trackListBox.TabIndex = 1;
            this.trackListBox.Click += new System.EventHandler(this.trackListBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutPosition);
            this.panel2.Controls.Add(this.txtInPosition);
            this.panel2.Controls.Add(this.txtPeriod);
            this.panel2.Controls.Add(this.txtOffset);
            this.panel2.Controls.Add(this.txtOctave);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 206);
            this.panel2.TabIndex = 1;
            // 
            // txtOutPosition
            // 
            this.txtOutPosition.Location = new System.Drawing.Point(91, 151);
            this.txtOutPosition.Name = "txtOutPosition";
            this.txtOutPosition.Size = new System.Drawing.Size(190, 23);
            this.txtOutPosition.TabIndex = 13;
            // 
            // txtInPosition
            // 
            this.txtInPosition.Location = new System.Drawing.Point(91, 122);
            this.txtInPosition.Name = "txtInPosition";
            this.txtInPosition.Size = new System.Drawing.Size(190, 23);
            this.txtInPosition.TabIndex = 12;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(91, 93);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(190, 23);
            this.txtPeriod.TabIndex = 11;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(91, 64);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(190, 23);
            this.txtOffset.TabIndex = 10;
            // 
            // txtOctave
            // 
            this.txtOctave.Location = new System.Drawing.Point(91, 35);
            this.txtOctave.Name = "txtOctave";
            this.txtOctave.Size = new System.Drawing.Size(190, 23);
            this.txtOctave.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 23);
            this.txtName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Out Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "In Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Octave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveTrack);
            this.panel3.Controls.Add(this.btnAddTrack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 37);
            this.panel3.TabIndex = 2;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(10, 7);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrack.TabIndex = 0;
            this.btnAddTrack.Text = "+";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Location = new System.Drawing.Point(92, 6);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTrack.TabIndex = 1;
            this.btnRemoveTrack.Text = "X";
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // TrackEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TrackEditor";
            this.Size = new System.Drawing.Size(541, 206);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox trackListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutPosition;
        private System.Windows.Forms.TextBox txtInPosition;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.TextBox txtOctave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.Button btnAddTrack;
    }
}
