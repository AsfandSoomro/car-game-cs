
namespace CarGame_CS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbUserCar = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.randomCarsTimer = new System.Windows.Forms.Timer(this.components);
            this.pbFire = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsLblVersion = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(766, 716);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // pbUserCar
            // 
            this.pbUserCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.pbUserCar.Enabled = false;
            this.pbUserCar.Image = ((System.Drawing.Image)(resources.GetObject("pbUserCar.Image")));
            this.pbUserCar.Location = new System.Drawing.Point(239, 554);
            this.pbUserCar.Name = "pbUserCar";
            this.pbUserCar.Size = new System.Drawing.Size(76, 114);
            this.pbUserCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserCar.TabIndex = 1;
            this.pbUserCar.TabStop = false;
            this.pbUserCar.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // randomCarsTimer
            // 
            this.randomCarsTimer.Enabled = true;
            this.randomCarsTimer.Interval = 5000;
            this.randomCarsTimer.Tick += new System.EventHandler(this.randomCarsTimer_Tick);
            // 
            // pbFire
            // 
            this.pbFire.Enabled = false;
            this.pbFire.Image = ((System.Drawing.Image)(resources.GetObject("pbFire.Image")));
            this.pbFire.Location = new System.Drawing.Point(239, 491);
            this.pbFire.Name = "pbFire";
            this.pbFire.Size = new System.Drawing.Size(76, 66);
            this.pbFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire.TabIndex = 2;
            this.pbFire.TabStop = false;
            this.pbFire.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRestart.Enabled = false;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRestart.Location = new System.Drawing.Point(315, 309);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(157, 72);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblVersion});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(765, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "ToolBar";
            // 
            // tsLblVersion
            // 
            this.tsLblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsLblVersion.Name = "tsLblVersion";
            this.tsLblVersion.Size = new System.Drawing.Size(51, 22);
            this.tsLblVersion.Text = "v1.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(765, 713);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pbFire);
            this.Controls.Add(this.pbUserCar);
            this.Controls.Add(this.pbBackground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbUserCar;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer randomCarsTimer;
        private System.Windows.Forms.PictureBox pbFire;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tsLblVersion;
    }
}

