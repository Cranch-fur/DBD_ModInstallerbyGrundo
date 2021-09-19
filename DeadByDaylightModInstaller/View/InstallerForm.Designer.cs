
namespace Dead_By_Daylight_Mod_Installer
{
    partial class InstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm));
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.minimizeToolbarButton = new System.Windows.Forms.Button();
            this.closeToolbarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paksPathTextBox = new System.Windows.Forms.TextBox();
            this.changePaksPathButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.createPackageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.toolbarPanel.Controls.Add(this.minimizeToolbarButton);
            this.toolbarPanel.Controls.Add(this.closeToolbarButton);
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(740, 23);
            this.toolbarPanel.TabIndex = 2;
            this.toolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolbarPanel_MouseDown);
            // 
            // minimizeToolbarButton
            // 
            this.minimizeToolbarButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.minimizeToolbarButton.FlatAppearance.BorderSize = 0;
            this.minimizeToolbarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeToolbarButton.ForeColor = System.Drawing.Color.White;
            this.minimizeToolbarButton.Location = new System.Drawing.Point(690, 0);
            this.minimizeToolbarButton.Name = "minimizeToolbarButton";
            this.minimizeToolbarButton.Size = new System.Drawing.Size(24, 23);
            this.minimizeToolbarButton.TabIndex = 1;
            this.minimizeToolbarButton.Text = "—";
            this.minimizeToolbarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimizeToolbarButton.UseVisualStyleBackColor = false;
            this.minimizeToolbarButton.Click += new System.EventHandler(this.MinimizeToolbarButton_Click);
            // 
            // closeToolbarButton
            // 
            this.closeToolbarButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeToolbarButton.FlatAppearance.BorderSize = 0;
            this.closeToolbarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeToolbarButton.ForeColor = System.Drawing.Color.White;
            this.closeToolbarButton.Location = new System.Drawing.Point(716, 0);
            this.closeToolbarButton.Name = "closeToolbarButton";
            this.closeToolbarButton.Size = new System.Drawing.Size(24, 23);
            this.closeToolbarButton.TabIndex = 0;
            this.closeToolbarButton.Text = "X";
            this.closeToolbarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeToolbarButton.UseVisualStyleBackColor = false;
            this.closeToolbarButton.Click += new System.EventHandler(this.CloseToolbarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Specify Path to the \"Paks\" folder, located in DeadByDaylight/Content";
            // 
            // paksPathTextBox
            // 
            this.paksPathTextBox.BackColor = System.Drawing.Color.White;
            this.paksPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paksPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paksPathTextBox.Location = new System.Drawing.Point(148, 214);
            this.paksPathTextBox.Name = "paksPathTextBox";
            this.paksPathTextBox.ReadOnly = true;
            this.paksPathTextBox.Size = new System.Drawing.Size(444, 21);
            this.paksPathTextBox.TabIndex = 9;
            // 
            // changePaksPathButton
            // 
            this.changePaksPathButton.BackColor = System.Drawing.Color.Transparent;
            this.changePaksPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePaksPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePaksPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(3)))), ((int)(((byte)(50)))));
            this.changePaksPathButton.Location = new System.Drawing.Point(518, 241);
            this.changePaksPathButton.Name = "changePaksPathButton";
            this.changePaksPathButton.Size = new System.Drawing.Size(74, 23);
            this.changePaksPathButton.TabIndex = 11;
            this.changePaksPathButton.Text = "Change";
            this.changePaksPathButton.UseVisualStyleBackColor = false;
            this.changePaksPathButton.Click += new System.EventHandler(this.ChangePaksPathButton_Click);
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.Transparent;
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.installButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.installButton.Location = new System.Drawing.Point(203, 390);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(160, 27);
            this.installButton.TabIndex = 12;
            this.installButton.Text = "INSTALL";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.button5.Location = new System.Drawing.Point(377, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "UNINSTALL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // createPackageButton
            // 
            this.createPackageButton.BackColor = System.Drawing.Color.Transparent;
            this.createPackageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.createPackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPackageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPackageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.createPackageButton.Location = new System.Drawing.Point(203, 426);
            this.createPackageButton.Name = "createPackageButton";
            this.createPackageButton.Size = new System.Drawing.Size(334, 31);
            this.createPackageButton.TabIndex = 15;
            this.createPackageButton.Text = "CREATE MOD PACKAGE";
            this.createPackageButton.UseVisualStyleBackColor = false;
            this.createPackageButton.Click += new System.EventHandler(this.CreatePackageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Dead_By_Daylight_Mod_Installer.Properties.Resources.IMG_TITLE;
            this.pictureBox1.Location = new System.Drawing.Point(40, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 136);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Dead_By_Daylight_Mod_Installer.Properties.Resources.IMG_CREDITS;
            this.pictureBox2.Location = new System.Drawing.Point(0, 507);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(740, 232);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Dead_By_Daylight_Mod_Installer.Properties.Resources.IMG_BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 740);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createPackageButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.changePaksPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paksPathTextBox);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead By Daylight Mod Installer";
            this.toolbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Button minimizeToolbarButton;
        private System.Windows.Forms.Button closeToolbarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paksPathTextBox;
        private System.Windows.Forms.Button changePaksPathButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button createPackageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

