namespace HR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnCloseMF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottomPanel.Controls.Add(this.label2);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 714);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1302, 32);
            this.bottomPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wykonano przez: ŁM i SC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zalogowany użytkownik: Łukasz Magierowicz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftPanel.Controls.Add(this.btnPosition);
            this.leftPanel.Controls.Add(this.btnContracts);
            this.leftPanel.Controls.Add(this.btnSalary);
            this.leftPanel.Controls.Add(this.slidePanel);
            this.leftPanel.Controls.Add(this.btnWorkers);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 714);
            this.leftPanel.TabIndex = 1;
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPosition.FlatAppearance.BorderSize = 0;
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnPosition.Image")));
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.Location = new System.Drawing.Point(12, 478);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(238, 80);
            this.btnPosition.TabIndex = 2;
            this.btnPosition.Text = "Stanowiska";
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContracts.Image = ((System.Drawing.Image)(resources.GetObject("btnContracts.Image")));
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(12, 286);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(238, 80);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalary.Image = ((System.Drawing.Image)(resources.GetObject("btnSalary.Image")));
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(12, 382);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(238, 80);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Wynagrodzenia";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.slidePanel.Location = new System.Drawing.Point(0, 190);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(10, 80);
            this.slidePanel.TabIndex = 3;
            this.slidePanel.Visible = false;
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWorkers.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkers.Image")));
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(12, 190);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(238, 80);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Pracownicy";
            this.btnWorkers.UseVisualStyleBackColor = false;
            this.btnWorkers.Click += new System.EventHandler(this.BtnWorkers_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.btnCloseMF);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(250, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1052, 61);
            this.topPanel.TabIndex = 2;
            // 
            // btnCloseMF
            // 
            this.btnCloseMF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCloseMF.FlatAppearance.BorderSize = 0;
            this.btnCloseMF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMF.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseMF.Location = new System.Drawing.Point(998, 11);
            this.btnCloseMF.Name = "btnCloseMF";
            this.btnCloseMF.Size = new System.Drawing.Size(32, 33);
            this.btnCloseMF.TabIndex = 3;
            this.btnCloseMF.Text = "X";
            this.btnCloseMF.UseVisualStyleBackColor = false;
            this.btnCloseMF.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(293, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "System kadrowo-płacowy HR";
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(250, 61);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1052, 653);
            this.centerPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 746);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnCloseMF;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel centerPanel;
    }
}