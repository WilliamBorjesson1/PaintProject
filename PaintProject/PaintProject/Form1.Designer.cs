namespace PaintProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.purpleBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.brownBox = new System.Windows.Forms.PictureBox();
            this.whiteBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1714, 1025);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.whiteBox);
            this.panel1.Controls.Add(this.brownBox);
            this.panel1.Controls.Add(this.yellowBox);
            this.panel1.Controls.Add(this.blueBox);
            this.panel1.Controls.Add(this.greenBox);
            this.panel1.Controls.Add(this.redBox);
            this.panel1.Controls.Add(this.orangeBox);
            this.panel1.Controls.Add(this.blackBox);
            this.panel1.Controls.Add(this.purpleBox);
            this.panel1.Controls.Add(this.pinkBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 113);
            this.panel1.TabIndex = 0;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(11, 9);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(40, 42);
            this.redBox.TabIndex = 0;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(57, 9);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(40, 42);
            this.blueBox.TabIndex = 1;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(149, 57);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(40, 42);
            this.blackBox.TabIndex = 2;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.BackColor = System.Drawing.Color.Pink;
            this.pinkBox.Location = new System.Drawing.Point(103, 57);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(40, 42);
            this.pinkBox.TabIndex = 3;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // purpleBox
            // 
            this.purpleBox.BackColor = System.Drawing.Color.Purple;
            this.purpleBox.Location = new System.Drawing.Point(57, 57);
            this.purpleBox.Name = "purpleBox";
            this.purpleBox.Size = new System.Drawing.Size(40, 42);
            this.purpleBox.TabIndex = 4;
            this.purpleBox.TabStop = false;
            this.purpleBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.DarkOrange;
            this.orangeBox.Location = new System.Drawing.Point(11, 57);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(40, 42);
            this.orangeBox.TabIndex = 5;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Green;
            this.greenBox.Location = new System.Drawing.Point(149, 9);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(40, 42);
            this.greenBox.TabIndex = 6;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(103, 9);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(40, 42);
            this.yellowBox.TabIndex = 7;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // brownBox
            // 
            this.brownBox.BackColor = System.Drawing.Color.Brown;
            this.brownBox.Location = new System.Drawing.Point(195, 9);
            this.brownBox.Name = "brownBox";
            this.brownBox.Size = new System.Drawing.Size(40, 42);
            this.brownBox.TabIndex = 8;
            this.brownBox.TabStop = false;
            this.brownBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // whiteBox
            // 
            this.whiteBox.BackColor = System.Drawing.Color.White;
            this.whiteBox.Location = new System.Drawing.Point(195, 57);
            this.whiteBox.Name = "whiteBox";
            this.whiteBox.Size = new System.Drawing.Size(40, 42);
            this.whiteBox.TabIndex = 9;
            this.whiteBox.TabStop = false;
            this.whiteBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1025);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvas;
        private Panel panel1;
        private PictureBox whiteBox;
        private PictureBox brownBox;
        private PictureBox yellowBox;
        private PictureBox blueBox;
        private PictureBox greenBox;
        private PictureBox redBox;
        private PictureBox orangeBox;
        private PictureBox blackBox;
        private PictureBox purpleBox;
        private PictureBox pinkBox;
    }
}