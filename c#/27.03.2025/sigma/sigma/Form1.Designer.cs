namespace sigma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(575, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "opc.tcp://192.168.15.99:4840";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(575, 154);
            button1.Name = "button1";
            button1.Size = new Size(245, 43);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(885, 154);
            button2.Name = "button2";
            button2.Size = new Size(246, 43);
            button2.TabIndex = 2;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(575, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 43);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(407, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(562, 43);
            textBox2.TabIndex = 4;
            textBox2.Text = "ns=4;i=2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(407, 160);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 5;
            label1.Text = "NodelID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(423, 289);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 7;
            label2.Text = "Value:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(407, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(562, 43);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(992, 222);
            button3.Name = "button3";
            button3.Size = new Size(139, 43);
            button3.TabIndex = 8;
            button3.Text = "Read Value";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(992, 341);
            button4.Name = "button4";
            button4.Size = new Size(139, 43);
            button4.TabIndex = 9;
            button4.Text = "Daj suba";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = SystemColors.InactiveBorder;
            cartesianChart1.Location = new Point(29, 409);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1102, 211);
            cartesianChart1.TabIndex = 10;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(29, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(346, 364);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1143, 632);
            Controls.Add(pictureBox2);
            Controls.Add(cartesianChart1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private PictureBox pictureBox2;
    }
}
