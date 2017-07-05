namespace MarcoFont
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
            this.bProcess = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.chkIntyBasic = new System.Windows.Forms.CheckBox();
            this.lZoom = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.lZoomtxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bOutline = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bBackground = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tResult = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bProcess
            // 
            this.bProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bProcess.Location = new System.Drawing.Point(650, 6);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(108, 42);
            this.bProcess.TabIndex = 0;
            this.bProcess.Text = "Process";
            this.bProcess.UseVisualStyleBackColor = true;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 519);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.bOpen);
            this.tabPage1.Controls.Add(this.chkIntyBasic);
            this.tabPage1.Controls.Add(this.lZoom);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.pbX);
            this.tabPage1.Controls.Add(this.lZoomtxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bOutline);
            this.tabPage1.Controls.Add(this.bProcess);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bBackground);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grid Scanner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Source:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 23);
            this.textBox1.TabIndex = 16;
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(650, 57);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(108, 23);
            this.bOpen.TabIndex = 15;
            this.bOpen.Text = "&Open Bitmap...";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click_1);
            // 
            // chkIntyBasic
            // 
            this.chkIntyBasic.AutoSize = true;
            this.chkIntyBasic.Checked = true;
            this.chkIntyBasic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntyBasic.Enabled = false;
            this.chkIntyBasic.Location = new System.Drawing.Point(542, 6);
            this.chkIntyBasic.Name = "chkIntyBasic";
            this.chkIntyBasic.Size = new System.Drawing.Size(70, 17);
            this.chkIntyBasic.TabIndex = 14;
            this.chkIntyBasic.Text = "IntyBasic";
            this.chkIntyBasic.UseVisualStyleBackColor = true;
            // 
            // lZoom
            // 
            this.lZoom.AutoSize = true;
            this.lZoom.Location = new System.Drawing.Point(147, 21);
            this.lZoom.Name = "lZoom";
            this.lZoom.Size = new System.Drawing.Size(36, 13);
            this.lZoom.TabIndex = 13;
            this.lZoom.Text = "100%";
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleDescription = "";
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(189, 6);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 45);
            this.trackBar1.SmallChange = 50;
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pbX
            // 
            this.pbX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbX.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.pbX.Location = new System.Drawing.Point(3, 86);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(755, 401);
            this.pbX.TabIndex = 11;
            this.pbX.TabStop = false;
            this.pbX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbX_MouseClick);
            // 
            // lZoomtxt
            // 
            this.lZoomtxt.AutoSize = true;
            this.lZoomtxt.Location = new System.Drawing.Point(150, 6);
            this.lZoomtxt.Name = "lZoomtxt";
            this.lZoomtxt.Size = new System.Drawing.Size(33, 13);
            this.lZoomtxt.TabIndex = 8;
            this.lZoomtxt.Text = "Zoom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Outline color\r\n(Left Click)";
            // 
            // bOutline
            // 
            this.bOutline.BackColor = System.Drawing.Color.Magenta;
            this.bOutline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bOutline.Location = new System.Drawing.Point(74, 3);
            this.bOutline.Name = "bOutline";
            this.bOutline.Size = new System.Drawing.Size(67, 19);
            this.bOutline.TabIndex = 4;
            this.bOutline.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Background\r\n(right click)";
            // 
            // bBackground
            // 
            this.bBackground.BackColor = System.Drawing.Color.Black;
            this.bBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bBackground.Location = new System.Drawing.Point(6, 3);
            this.bBackground.Name = "bBackground";
            this.bBackground.Size = new System.Drawing.Size(62, 19);
            this.bBackground.TabIndex = 0;
            this.bBackground.UseVisualStyleBackColor = false;
            this.bBackground.Click += new System.EventHandler(this.bBackground_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Result (Bitmap data)";
            // 
            // tResult
            // 
            this.tResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tResult.Location = new System.Drawing.Point(6, 6);
            this.tResult.Multiline = true;
            this.tResult.Name = "tResult";
            this.tResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tResult.Size = new System.Drawing.Size(755, 481);
            this.tResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 543);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "MarcoFont v0.1.2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bProcess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bOutline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBackground;
        private System.Windows.Forms.Label lZoomtxt;
        private System.Windows.Forms.PictureBox pbX;
        private System.Windows.Forms.Label lZoom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tResult;
        private System.Windows.Forms.CheckBox chkIntyBasic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bOpen;
    }
}

