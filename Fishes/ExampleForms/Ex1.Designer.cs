namespace Fishes.ExampleForms
{
    partial class Ex1
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
            this.Phh = new System.Windows.Forms.TextBox();
            this.ligh = new System.Windows.Forms.TextBox();
            this.oxy = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timeShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Phh
            // 
            this.Phh.Location = new System.Drawing.Point(693, 100);
            this.Phh.Name = "Phh";
            this.Phh.Size = new System.Drawing.Size(81, 27);
            this.Phh.TabIndex = 43;
            // 
            // ligh
            // 
            this.ligh.Location = new System.Drawing.Point(573, 100);
            this.ligh.Name = "ligh";
            this.ligh.Size = new System.Drawing.Size(81, 27);
            this.ligh.TabIndex = 42;
            // 
            // oxy
            // 
            this.oxy.Location = new System.Drawing.Point(444, 100);
            this.oxy.Name = "oxy";
            this.oxy.Size = new System.Drawing.Size(81, 27);
            this.oxy.TabIndex = 41;
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(310, 100);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(81, 27);
            this.temp.TabIndex = 40;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(169, 100);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 27);
            this.time.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Оводнение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Освещение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Кислород";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Время";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Стадия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 44;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeShow
            // 
            this.timeShow.AutoSize = true;
            this.timeShow.Location = new System.Drawing.Point(201, 268);
            this.timeShow.Name = "timeShow";
            this.timeShow.Size = new System.Drawing.Size(51, 20);
            this.timeShow.TabIndex = 45;
            this.timeShow.Text = "label8";
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phh);
            this.Controls.Add(this.ligh);
            this.Controls.Add(this.oxy);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Phh;
        private TextBox ligh;
        private TextBox oxy;
        private TextBox temp;
        private TextBox time;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label timeShow;
    }
}