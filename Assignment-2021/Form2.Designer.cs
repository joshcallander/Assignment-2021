
namespace Assignment_2021
{
    partial class Form2
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
            this.checkBoxTwoPlayers = new System.Windows.Forms.CheckBox();
            this.checkBoxThreePlayers = new System.Windows.Forms.CheckBox();
            this.checkBoxFourPlayers = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxTwoPlayers
            // 
            this.checkBoxTwoPlayers.AutoSize = true;
            this.checkBoxTwoPlayers.Location = new System.Drawing.Point(27, 128);
            this.checkBoxTwoPlayers.Name = "checkBoxTwoPlayers";
            this.checkBoxTwoPlayers.Size = new System.Drawing.Size(69, 17);
            this.checkBoxTwoPlayers.TabIndex = 0;
            this.checkBoxTwoPlayers.Text = "2 Players";
            this.checkBoxTwoPlayers.UseVisualStyleBackColor = true;
            this.checkBoxTwoPlayers.CheckedChanged += new System.EventHandler(this.checkBoxTwoPlayers_CheckedChanged);
            // 
            // checkBoxThreePlayers
            // 
            this.checkBoxThreePlayers.AutoSize = true;
            this.checkBoxThreePlayers.Location = new System.Drawing.Point(140, 128);
            this.checkBoxThreePlayers.Name = "checkBoxThreePlayers";
            this.checkBoxThreePlayers.Size = new System.Drawing.Size(69, 17);
            this.checkBoxThreePlayers.TabIndex = 1;
            this.checkBoxThreePlayers.Text = "3 Players";
            this.checkBoxThreePlayers.UseVisualStyleBackColor = true;
            this.checkBoxThreePlayers.CheckedChanged += new System.EventHandler(this.checkBoxThreePlayers_CheckedChanged);
            // 
            // checkBoxFourPlayers
            // 
            this.checkBoxFourPlayers.AutoSize = true;
            this.checkBoxFourPlayers.Location = new System.Drawing.Point(250, 128);
            this.checkBoxFourPlayers.Name = "checkBoxFourPlayers";
            this.checkBoxFourPlayers.Size = new System.Drawing.Size(69, 17);
            this.checkBoxFourPlayers.TabIndex = 2;
            this.checkBoxFourPlayers.Text = "4 Players";
            this.checkBoxFourPlayers.UseVisualStyleBackColor = true;
            this.checkBoxFourPlayers.CheckedChanged += new System.EventHandler(this.checkBoxFourPlayers_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(27, 171);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(150, 171);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(20, 20);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(175, 39);
            this.labelHeading.TabIndex = 5;
            this.labelHeading.Text = "Monopoly";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(24, 78);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(547, 16);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Use the checkboxes below to select the number of players, then click the Start Ga" +
    "me button.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxFourPlayers);
            this.Controls.Add(this.checkBoxThreePlayers);
            this.Controls.Add(this.checkBoxTwoPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTwoPlayers;
        private System.Windows.Forms.CheckBox checkBoxThreePlayers;
        private System.Windows.Forms.CheckBox checkBoxFourPlayers;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelText;
    }
}

