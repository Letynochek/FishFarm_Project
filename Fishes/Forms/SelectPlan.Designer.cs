namespace Fishes.Forms
{
    partial class SelectPlan
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
            this.ReadyPlan = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.LoadPlan = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ReadyPlan
            // 
            this.ReadyPlan.Location = new System.Drawing.Point(344, 154);
            this.ReadyPlan.Name = "ReadyPlan";
            this.ReadyPlan.Size = new System.Drawing.Size(94, 29);
            this.ReadyPlan.TabIndex = 0;
            this.ReadyPlan.Text = "Ready plan";
            this.ReadyPlan.UseVisualStyleBackColor = true;
            this.ReadyPlan.Click += new System.EventHandler(this.ReadyPlan_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(344, 206);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(94, 29);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // LoadPlan
            // 
            this.LoadPlan.Location = new System.Drawing.Point(344, 262);
            this.LoadPlan.Name = "LoadPlan";
            this.LoadPlan.Size = new System.Drawing.Size(94, 29);
            this.LoadPlan.TabIndex = 2;
            this.LoadPlan.Text = "Load plan";
            this.LoadPlan.UseVisualStyleBackColor = true;
            this.LoadPlan.Click += new System.EventHandler(this.LoadPlan_Click);
            // 
            // Load
            // 
            this.Load.FileName = "openFileDialog1";
            // 
            // SelectPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadPlan);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.ReadyPlan);
            this.Name = "SelectPlan";
            this.Text = "SelectPlan";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ReadyPlan;
        private Button Settings;
        private Button LoadPlan;
        private OpenFileDialog Load;
    }
}