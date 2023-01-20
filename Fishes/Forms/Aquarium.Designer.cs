namespace Fishes.Forms
{
    partial class Aquarium
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
            this.temp = new System.Windows.Forms.Label();
            this.oxy = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.ViewUpdate = new System.Windows.Forms.Timer(this.components);
            this.Nature = new System.Windows.Forms.Timer(this.components);
            this.AquariumWork = new System.Windows.Forms.Timer(this.components);
            this.SystemTime = new System.Windows.Forms.Timer(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.SavePlan = new System.Windows.Forms.SaveFileDialog();
            this.Stage = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelOxy = new System.Windows.Forms.Label();
            this.labelPh = new System.Windows.Forms.Label();
            this.TMode = new System.Windows.Forms.Label();
            this.OMode = new System.Windows.Forms.Label();
            this.PMode = new System.Windows.Forms.Label();
            this.LMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LightTime = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.StageTime = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(244, 148);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(18, 20);
            this.temp.TabIndex = 0;
            this.temp.Text = "0";
            // 
            // oxy
            // 
            this.oxy.AutoSize = true;
            this.oxy.Location = new System.Drawing.Point(219, 279);
            this.oxy.Name = "oxy";
            this.oxy.Size = new System.Drawing.Size(18, 20);
            this.oxy.TabIndex = 1;
            this.oxy.Text = "0";
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Location = new System.Drawing.Point(585, 148);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(18, 20);
            this.ph.TabIndex = 2;
            this.ph.Text = "0";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(347, 373);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(94, 37);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // ViewUpdate
            // 
            this.ViewUpdate.Interval = 1000;
            this.ViewUpdate.Tick += new System.EventHandler(this.ViewUpdate_Tick);
            // 
            // Nature
            // 
            this.Nature.Interval = 4000;
            this.Nature.Tick += new System.EventHandler(this.Nature_Tick);
            // 
            // AquariumWork
            // 
            this.AquariumWork.Interval = 1000;
            this.AquariumWork.Tick += new System.EventHandler(this.AquariumWork_Tick);
            // 
            // SystemTime
            // 
            this.SystemTime.Interval = 1000;
            this.SystemTime.Tick += new System.EventHandler(this.SystemTime_Tick);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(694, 409);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 29);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Stage
            // 
            this.Stage.AutoSize = true;
            this.Stage.Location = new System.Drawing.Point(403, 45);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(18, 20);
            this.Stage.TabIndex = 5;
            this.Stage.Text = "0";
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Location = new System.Drawing.Point(335, 45);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(52, 20);
            this.labelStage.TabIndex = 6;
            this.labelStage.Text = "Stage:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(139, 148);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(99, 20);
            this.labelTemp.TabIndex = 7;
            this.labelTemp.Text = "Temperature";
            // 
            // labelOxy
            // 
            this.labelOxy.AutoSize = true;
            this.labelOxy.Location = new System.Drawing.Point(151, 279);
            this.labelOxy.Name = "labelOxy";
            this.labelOxy.Size = new System.Drawing.Size(62, 20);
            this.labelOxy.TabIndex = 8;
            this.labelOxy.Text = "Oxygen";
            // 
            // labelPh
            // 
            this.labelPh.AutoSize = true;
            this.labelPh.Location = new System.Drawing.Point(552, 148);
            this.labelPh.Name = "labelPh";
            this.labelPh.Size = new System.Drawing.Size(27, 20);
            this.labelPh.TabIndex = 9;
            this.labelPh.Text = "Ph";
            // 
            // TMode
            // 
            this.TMode.AutoSize = true;
            this.TMode.Location = new System.Drawing.Point(181, 185);
            this.TMode.Name = "TMode";
            this.TMode.Size = new System.Drawing.Size(32, 20);
            this.TMode.TabIndex = 10;
            this.TMode.Text = "Off";
            // 
            // OMode
            // 
            this.OMode.AutoSize = true;
            this.OMode.Location = new System.Drawing.Point(181, 321);
            this.OMode.Name = "OMode";
            this.OMode.Size = new System.Drawing.Size(32, 20);
            this.OMode.TabIndex = 11;
            this.OMode.Text = "Off";
            // 
            // PMode
            // 
            this.PMode.AutoSize = true;
            this.PMode.Location = new System.Drawing.Point(561, 185);
            this.PMode.Name = "PMode";
            this.PMode.Size = new System.Drawing.Size(32, 20);
            this.PMode.TabIndex = 12;
            this.PMode.Text = "Off";
            // 
            // LMode
            // 
            this.LMode.AutoSize = true;
            this.LMode.Location = new System.Drawing.Point(561, 321);
            this.LMode.Name = "LMode";
            this.LMode.Size = new System.Drawing.Size(32, 20);
            this.LMode.TabIndex = 13;
            this.LMode.Text = "Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Light";
            // 
            // LightTime
            // 
            this.LightTime.AutoSize = true;
            this.LightTime.Location = new System.Drawing.Point(585, 279);
            this.LightTime.Name = "LightTime";
            this.LightTime.Size = new System.Drawing.Size(18, 20);
            this.LightTime.TabIndex = 15;
            this.LightTime.Text = "0";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(339, 76);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(48, 20);
            this.Time.TabIndex = 16;
            this.Time.Text = "Time:";
            // 
            // StageTime
            // 
            this.StageTime.AutoSize = true;
            this.StageTime.Location = new System.Drawing.Point(403, 76);
            this.StageTime.Name = "StageTime";
            this.StageTime.Size = new System.Drawing.Size(18, 20);
            this.StageTime.TabIndex = 17;
            this.StageTime.Text = "0";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(110, 20);
            this.Status.TabIndex = 18;
            this.Status.Text = "Ready to work";
            // 
            // Aquarium
            // 
            this.BackgroundImage = global::Fishes.Properties.Resources.Рыбки;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StageTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.LightTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LMode);
            this.Controls.Add(this.PMode);
            this.Controls.Add(this.OMode);
            this.Controls.Add(this.TMode);
            this.Controls.Add(this.labelPh);
            this.Controls.Add(this.labelOxy);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.oxy);
            this.Controls.Add(this.temp);
            this.Name = "Aquarium";
            this.Text = "Aquarium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label temp;
        private Label oxy;
        private Label ph;
        private Button start;
        private System.Windows.Forms.Timer ViewUpdate;
        private System.Windows.Forms.Timer Nature;
        private System.Windows.Forms.Timer AquariumWork;
        private System.Windows.Forms.Timer SystemTime;
        private Button Save;
        private SaveFileDialog SavePlan;
        private Label Stage;
        private Label labelStage;
        private Label labelTemp;
        private Label labelOxy;
        private Label labelPh;
        private Label TMode;
        private Label OMode;
        private Label PMode;
        private Label LMode;
        private Label label4;
        private Label LightTime;
        private Label Time;
        private Label StageTime;
        private Label Status;
    }
}