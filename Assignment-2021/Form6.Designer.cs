
namespace Assignment_2021
{
    partial class Form6
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxJandals = new System.Windows.Forms.CheckBox();
            this.checkBoxSheep = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfboard = new System.Windows.Forms.CheckBox();
            this.checkBoxVegemite = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(109, 299);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(15, 299);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(54, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Loading...";
            // 
            // checkBoxJandals
            // 
            this.checkBoxJandals.AutoSize = true;
            this.checkBoxJandals.Location = new System.Drawing.Point(15, 185);
            this.checkBoxJandals.Name = "checkBoxJandals";
            this.checkBoxJandals.Size = new System.Drawing.Size(62, 17);
            this.checkBoxJandals.TabIndex = 3;
            this.checkBoxJandals.Text = "Jandals";
            this.checkBoxJandals.UseVisualStyleBackColor = true;
            this.checkBoxJandals.CheckedChanged += new System.EventHandler(this.checkBoxJandals_CheckedChanged);
            // 
            // checkBoxSheep
            // 
            this.checkBoxSheep.AutoSize = true;
            this.checkBoxSheep.Location = new System.Drawing.Point(165, 185);
            this.checkBoxSheep.Name = "checkBoxSheep";
            this.checkBoxSheep.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSheep.TabIndex = 4;
            this.checkBoxSheep.Text = "Sheep";
            this.checkBoxSheep.UseVisualStyleBackColor = true;
            this.checkBoxSheep.CheckedChanged += new System.EventHandler(this.checkBoxSheep_CheckedChanged);
            // 
            // checkBoxSurfboard
            // 
            this.checkBoxSurfboard.AutoSize = true;
            this.checkBoxSurfboard.Location = new System.Drawing.Point(311, 185);
            this.checkBoxSurfboard.Name = "checkBoxSurfboard";
            this.checkBoxSurfboard.Size = new System.Drawing.Size(72, 17);
            this.checkBoxSurfboard.TabIndex = 5;
            this.checkBoxSurfboard.Text = "Surfboard";
            this.checkBoxSurfboard.UseVisualStyleBackColor = true;
            this.checkBoxSurfboard.CheckedChanged += new System.EventHandler(this.checkBoxSurfboard_CheckedChanged);
            // 
            // checkBoxVegemite
            // 
            this.checkBoxVegemite.AutoSize = true;
            this.checkBoxVegemite.Location = new System.Drawing.Point(459, 185);
            this.checkBoxVegemite.Name = "checkBoxVegemite";
            this.checkBoxVegemite.Size = new System.Drawing.Size(70, 17);
            this.checkBoxVegemite.TabIndex = 6;
            this.checkBoxVegemite.Text = "Vegemite";
            this.checkBoxVegemite.UseVisualStyleBackColor = true;
            this.checkBoxVegemite.CheckedChanged += new System.EventHandler(this.checkBoxVegemite_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Assignment_2021.Properties.Resources.vegemite;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(459, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 91);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Assignment_2021.Properties.Resources.surfboard;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(311, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 91);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Assignment_2021.Properties.Resources.sheep;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(165, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment_2021.Properties.Resources.jandal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(109, 242);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 12;
            this.textBoxUsername.TextChanged += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxVegemite);
            this.Controls.Add(this.checkBoxSurfboard);
            this.Controls.Add(this.checkBoxSheep);
            this.Controls.Add(this.checkBoxJandals);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxJandals;
        private System.Windows.Forms.CheckBox checkBoxSheep;
        private System.Windows.Forms.CheckBox checkBoxSurfboard;
        private System.Windows.Forms.CheckBox checkBoxVegemite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}