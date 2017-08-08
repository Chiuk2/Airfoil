namespace Airfoil
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
            this.Start_Analysis = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nacas = new System.Windows.Forms.TextBox();
            this.MaxCamber = new System.Windows.Forms.TextBox();
            this.DisttoMaxCamb = new System.Windows.Forms.TextBox();
            this.MaxThick = new System.Windows.Forms.TextBox();
            this.LERadius = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x_loc = new System.Windows.Forms.Label();
            this.y_loc = new System.Windows.Forms.Label();
            this.num_slices = new System.Windows.Forms.TextBox();
            this.SliceLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.scalebox = new System.Windows.Forms.TextBox();
            this.leadingEdge = new System.Windows.Forms.RadioButton();
            this.Center = new System.Windows.Forms.RadioButton();
            this.trailingEdge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLengthLabel = new System.Windows.Forms.Label();
            this.CLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkWires = new System.Windows.Forms.CheckBox();
            this.checkSlices = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Analysis
            // 
            this.Start_Analysis.Location = new System.Drawing.Point(12, 12);
            this.Start_Analysis.Name = "Start_Analysis";
            this.Start_Analysis.Size = new System.Drawing.Size(90, 23);
            this.Start_Analysis.TabIndex = 0;
            this.Start_Analysis.Text = "Start Analysis";
            this.Start_Analysis.UseVisualStyleBackColor = true;
            this.Start_Analysis.Click += new System.EventHandler(this.Start_Analysis_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(108, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(88, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 822);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nacas
            // 
            this.nacas.Location = new System.Drawing.Point(108, 41);
            this.nacas.Name = "nacas";
            this.nacas.Size = new System.Drawing.Size(88, 20);
            this.nacas.TabIndex = 4;
            this.nacas.Text = "2412";
            // 
            // MaxCamber
            // 
            this.MaxCamber.Location = new System.Drawing.Point(108, 374);
            this.MaxCamber.Name = "MaxCamber";
            this.MaxCamber.Size = new System.Drawing.Size(88, 20);
            this.MaxCamber.TabIndex = 5;
            // 
            // DisttoMaxCamb
            // 
            this.DisttoMaxCamb.Location = new System.Drawing.Point(108, 401);
            this.DisttoMaxCamb.Name = "DisttoMaxCamb";
            this.DisttoMaxCamb.Size = new System.Drawing.Size(88, 20);
            this.DisttoMaxCamb.TabIndex = 6;
            // 
            // MaxThick
            // 
            this.MaxThick.Location = new System.Drawing.Point(108, 428);
            this.MaxThick.Name = "MaxThick";
            this.MaxThick.Size = new System.Drawing.Size(88, 20);
            this.MaxThick.TabIndex = 7;
            // 
            // LERadius
            // 
            this.LERadius.Location = new System.Drawing.Point(108, 455);
            this.LERadius.Name = "LERadius";
            this.LERadius.Size = new System.Drawing.Size(88, 20);
            this.LERadius.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 509);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 535);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NACA NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "MAX CAMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DISTTOMAXCAMB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "MAX THICKNESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CIRCLE RADIUS AT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "LEADING EDGE";
            // 
            // x_loc
            // 
            this.x_loc.AutoSize = true;
            this.x_loc.Location = new System.Drawing.Point(49, 412);
            this.x_loc.Name = "x_loc";
            this.x_loc.Size = new System.Drawing.Size(0, 13);
            this.x_loc.TabIndex = 18;
            // 
            // y_loc
            // 
            this.y_loc.AutoSize = true;
            this.y_loc.Location = new System.Drawing.Point(49, 436);
            this.y_loc.Name = "y_loc";
            this.y_loc.Size = new System.Drawing.Size(0, 13);
            this.y_loc.TabIndex = 19;
            // 
            // num_slices
            // 
            this.num_slices.Location = new System.Drawing.Point(108, 68);
            this.num_slices.Name = "num_slices";
            this.num_slices.Size = new System.Drawing.Size(88, 20);
            this.num_slices.TabIndex = 20;
            this.num_slices.Text = "25";
            // 
            // SliceLabel
            // 
            this.SliceLabel.AutoSize = true;
            this.SliceLabel.Location = new System.Drawing.Point(2, 68);
            this.SliceLabel.Name = "SliceLabel";
            this.SliceLabel.Size = new System.Drawing.Size(87, 13);
            this.SliceLabel.TabIndex = 22;
            this.SliceLabel.Text = "Number of Slices";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(2, 102);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(80, 13);
            this.ScaleLabel.TabIndex = 24;
            this.ScaleLabel.Text = "Scale (Percent)";
            // 
            // scalebox
            // 
            this.scalebox.Location = new System.Drawing.Point(108, 102);
            this.scalebox.Name = "scalebox";
            this.scalebox.Size = new System.Drawing.Size(88, 20);
            this.scalebox.TabIndex = 25;
            this.scalebox.Text = "97";
            // 
            // leadingEdge
            // 
            this.leadingEdge.AutoSize = true;
            this.leadingEdge.Checked = true;
            this.leadingEdge.Location = new System.Drawing.Point(12, 31);
            this.leadingEdge.Name = "leadingEdge";
            this.leadingEdge.Size = new System.Drawing.Size(91, 17);
            this.leadingEdge.TabIndex = 29;
            this.leadingEdge.TabStop = true;
            this.leadingEdge.Text = "Leading Edge";
            this.leadingEdge.UseVisualStyleBackColor = true;
            this.leadingEdge.CheckedChanged += new System.EventHandler(this.leadingEdge_CheckedChanged);
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Location = new System.Drawing.Point(12, 54);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(56, 17);
            this.Center.TabIndex = 30;
            this.Center.TabStop = true;
            this.Center.Text = "Center";
            this.Center.UseVisualStyleBackColor = true;
            this.Center.CheckedChanged += new System.EventHandler(this.Center_CheckedChanged);
            // 
            // trailingEdge
            // 
            this.trailingEdge.AutoSize = true;
            this.trailingEdge.Location = new System.Drawing.Point(12, 77);
            this.trailingEdge.Name = "trailingEdge";
            this.trailingEdge.Size = new System.Drawing.Size(87, 17);
            this.trailingEdge.TabIndex = 31;
            this.trailingEdge.TabStop = true;
            this.trailingEdge.Text = "Trailing Edge";
            this.trailingEdge.UseVisualStyleBackColor = true;
            this.trailingEdge.CheckedChanged += new System.EventHandler(this.trailingEdge_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.leadingEdge);
            this.groupBox1.Controls.Add(this.trailingEdge);
            this.groupBox1.Controls.Add(this.Center);
            this.groupBox1.Location = new System.Drawing.Point(4, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 121);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Positions of Airfoils";
            // 
            // cLengthLabel
            // 
            this.cLengthLabel.AutoSize = true;
            this.cLengthLabel.Location = new System.Drawing.Point(5, 138);
            this.cLengthLabel.Name = "cLengthLabel";
            this.cLengthLabel.Size = new System.Drawing.Size(71, 13);
            this.cLengthLabel.TabIndex = 34;
            this.cLengthLabel.Text = "Chord Length";
            // 
            // CLength
            // 
            this.CLength.Location = new System.Drawing.Point(107, 135);
            this.CLength.Name = "CLength";
            this.CLength.Size = new System.Drawing.Size(89, 20);
            this.CLength.TabIndex = 35;
            this.CLength.Text = "1.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "*Chord Length: Float";
            // 
            // tX
            // 
            this.tX.AutoSize = false;
            this.tX.Location = new System.Drawing.Point(27, 577);
            this.tX.Maximum = 360;
            this.tX.Minimum = -360;
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(288, 45);
            this.tX.TabIndex = 10;
            this.tX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // tY
            // 
            this.tY.AutoSize = false;
            this.tY.Location = new System.Drawing.Point(27, 628);
            this.tY.Maximum = 360;
            this.tY.Minimum = -360;
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(288, 45);
            this.tY.TabIndex = 11;
            this.tY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tZ
            // 
            this.tZ.AutoSize = false;
            this.tZ.Location = new System.Drawing.Point(27, 679);
            this.tZ.Maximum = 360;
            this.tZ.Minimum = -360;
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(288, 45);
            this.tZ.TabIndex = 12;
            this.tZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Z:";
            // 
            // checkWires
            // 
            this.checkWires.AutoSize = true;
            this.checkWires.Checked = true;
            this.checkWires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWires.Location = new System.Drawing.Point(232, 730);
            this.checkWires.Name = "checkWires";
            this.checkWires.Size = new System.Drawing.Size(83, 17);
            this.checkWires.TabIndex = 43;
            this.checkWires.Text = "Show Wires";
            this.checkWires.UseVisualStyleBackColor = true;
            this.checkWires.CheckedChanged += new System.EventHandler(this.checkWires_CheckedChanged);
            // 
            // checkSlices
            // 
            this.checkSlices.AutoSize = true;
            this.checkSlices.Checked = true;
            this.checkSlices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSlices.Location = new System.Drawing.Point(232, 753);
            this.checkSlices.Name = "checkSlices";
            this.checkSlices.Size = new System.Drawing.Size(84, 17);
            this.checkSlices.TabIndex = 44;
            this.checkSlices.Text = "Show Slices";
            this.checkSlices.UseVisualStyleBackColor = true;
            this.checkSlices.CheckedChanged += new System.EventHandler(this.checkSlices_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1171, 857);
            this.Controls.Add(this.checkSlices);
            this.Controls.Add(this.checkWires);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CLength);
            this.Controls.Add(this.cLengthLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scalebox);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.SliceLabel);
            this.Controls.Add(this.num_slices);
            this.Controls.Add(this.y_loc);
            this.Controls.Add(this.x_loc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LERadius);
            this.Controls.Add(this.MaxThick);
            this.Controls.Add(this.DisttoMaxCamb);
            this.Controls.Add(this.MaxCamber);
            this.Controls.Add(this.nacas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start_Analysis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Analysis;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nacas;
        private System.Windows.Forms.TextBox MaxCamber;
        private System.Windows.Forms.TextBox DisttoMaxCamb;
        private System.Windows.Forms.TextBox MaxThick;
        private System.Windows.Forms.TextBox LERadius;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label x_loc;
        private System.Windows.Forms.Label y_loc;
        private System.Windows.Forms.TextBox num_slices;
        private System.Windows.Forms.Label SliceLabel;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.TextBox scalebox;
        private System.Windows.Forms.RadioButton leadingEdge;
        private System.Windows.Forms.RadioButton Center;
        private System.Windows.Forms.RadioButton trailingEdge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cLengthLabel;
        private System.Windows.Forms.TextBox CLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkWires;
        private System.Windows.Forms.CheckBox checkSlices;
    }
}

