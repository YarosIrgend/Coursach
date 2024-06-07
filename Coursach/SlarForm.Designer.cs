namespace Coursach
{
    partial class SlarForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matrix_method = new System.Windows.Forms.RadioButton();
            this.jordan_gausse_method = new System.Windows.Forms.RadioButton();
            this.gausse_method = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.size6 = new System.Windows.Forms.RadioButton();
            this.size5 = new System.Windows.Forms.RadioButton();
            this.size4 = new System.Windows.Forms.RadioButton();
            this.size3 = new System.Windows.Forms.RadioButton();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WriteInFileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(224)))), ((int)(((byte)(11)))));
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(766, 384);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(106, 42);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Порахувати";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.matrix_method);
            this.panel1.Controls.Add(this.jordan_gausse_method);
            this.panel1.Controls.Add(this.gausse_method);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(796, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 114);
            this.panel1.TabIndex = 1;
            // 
            // matrix_method
            // 
            this.matrix_method.AutoSize = true;
            this.matrix_method.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix_method.Location = new System.Drawing.Point(12, 86);
            this.matrix_method.Name = "matrix_method";
            this.matrix_method.Size = new System.Drawing.Size(109, 24);
            this.matrix_method.TabIndex = 3;
            this.matrix_method.TabStop = true;
            this.matrix_method.Text = "Матричний";
            this.matrix_method.UseVisualStyleBackColor = true;
            // 
            // jordan_gausse_method
            // 
            this.jordan_gausse_method.AutoSize = true;
            this.jordan_gausse_method.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jordan_gausse_method.Location = new System.Drawing.Point(12, 56);
            this.jordan_gausse_method.Name = "jordan_gausse_method";
            this.jordan_gausse_method.Size = new System.Drawing.Size(136, 24);
            this.jordan_gausse_method.TabIndex = 2;
            this.jordan_gausse_method.TabStop = true;
            this.jordan_gausse_method.Text = "Жордана-Гауса";
            this.jordan_gausse_method.UseVisualStyleBackColor = true;
            // 
            // gausse_method
            // 
            this.gausse_method.AutoSize = true;
            this.gausse_method.Checked = true;
            this.gausse_method.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gausse_method.Location = new System.Drawing.Point(12, 26);
            this.gausse_method.Name = "gausse_method";
            this.gausse_method.Size = new System.Drawing.Size(64, 24);
            this.gausse_method.TabIndex = 1;
            this.gausse_method.TabStop = true;
            this.gausse_method.Text = "Гауса";
            this.gausse_method.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Методи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.size6);
            this.panel2.Controls.Add(this.size5);
            this.panel2.Controls.Add(this.size4);
            this.panel2.Controls.Add(this.size3);
            this.panel2.Controls.Add(this.size2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(795, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 120);
            this.panel2.TabIndex = 2;
            // 
            // size6
            // 
            this.size6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size6.Location = new System.Drawing.Point(101, 50);
            this.size6.Name = "size6";
            this.size6.Size = new System.Drawing.Size(33, 27);
            this.size6.TabIndex = 4;
            this.size6.Text = "6";
            this.size6.CheckedChanged += new System.EventHandler(this.Size6_CheckedChanged);
            // 
            // size5
            // 
            this.size5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size5.Location = new System.Drawing.Point(101, 26);
            this.size5.Name = "size5";
            this.size5.Size = new System.Drawing.Size(33, 27);
            this.size5.TabIndex = 3;
            this.size5.Text = "5";
            this.size5.CheckedChanged += new System.EventHandler(this.Size5_CheckedChanged);
            // 
            // size4
            // 
            this.size4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size4.Location = new System.Drawing.Point(13, 74);
            this.size4.Name = "size4";
            this.size4.Size = new System.Drawing.Size(33, 28);
            this.size4.TabIndex = 2;
            this.size4.Text = "4";
            this.size4.CheckedChanged += new System.EventHandler(this.Size4_CheckedChanged);
            // 
            // size3
            // 
            this.size3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size3.Location = new System.Drawing.Point(13, 50);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(33, 27);
            this.size3.TabIndex = 1;
            this.size3.Text = "3";
            this.size3.CheckedChanged += new System.EventHandler(this.Size3_CheckedChanged);
            // 
            // size2
            // 
            this.size2.Checked = true;
            this.size2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size2.Location = new System.Drawing.Point(13, 26);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(33, 27);
            this.size2.TabIndex = 0;
            this.size2.TabStop = true;
            this.size2.Text = "2";
            this.size2.CheckedChanged += new System.EventHandler(this.Size2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Розмірність";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "coeffsA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Tag = "coeffsA";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Tag = "coeffsA";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Tag = "coeffsA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 7;
            this.label3.Tag = "xs_label";
            this.label3.Text = "x1 +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(96, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 8;
            this.label4.Tag = "xs_label";
            this.label4.Text = "x1 +";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(206, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Tag = "xs_label";
            this.label5.Text = "x2 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 10;
            this.label6.Tag = "xs_label";
            this.label6.Text = "x2 =";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(250, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Tag = "coeffsB";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(250, 100);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.Tag = "coeffsB";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 126);
            this.panel3.TabIndex = 13;
            // 
            // WriteInFileButton
            // 
            this.WriteInFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(229)))), ((int)(((byte)(23)))));
            this.WriteInFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteInFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteInFileButton.Location = new System.Drawing.Point(878, 384);
            this.WriteInFileButton.Name = "WriteInFileButton";
            this.WriteInFileButton.Size = new System.Drawing.Size(106, 42);
            this.WriteInFileButton.TabIndex = 14;
            this.WriteInFileButton.Text = "Записати рез-ти у файл";
            this.WriteInFileButton.UseVisualStyleBackColor = false;
            this.WriteInFileButton.Click += new System.EventHandler(this.WriteInFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(878, 432);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 37);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Tag = "exit";
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(235)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(766, 431);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 38);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Tag = "clearing";
            this.ClearButton.Text = "Очистити";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 509);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WriteInFileButton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.panel3);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SlarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton gausse_method;
        private System.Windows.Forms.RadioButton jordan_gausse_method;
        private System.Windows.Forms.RadioButton matrix_method;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size6;
        private System.Windows.Forms.RadioButton size5;
        private System.Windows.Forms.RadioButton size4;
        private System.Windows.Forms.RadioButton size3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button WriteInFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

