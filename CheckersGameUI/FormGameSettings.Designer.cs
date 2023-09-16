namespace CheckersGameUI
{
    partial class FormGameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameSettings));
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.checkBoxPlayerTwo = new System.Windows.Forms.CheckBox();
            this.textBoxPlayerOneName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerTwoName = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelBoardSize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoardSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBoardSize.Location = new System.Drawing.Point(29, 11);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(139, 32);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board Size:";
            this.labelBoardSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonSmall.Checked = true;
            this.radioButtonSmall.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSmall.Location = new System.Drawing.Point(44, 64);
            this.radioButtonSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(69, 21);
            this.radioButtonSmall.TabIndex = 1;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "6 X 6";
            this.radioButtonSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSmall.UseVisualStyleBackColor = false;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonMedium.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMedium.Location = new System.Drawing.Point(125, 64);
            this.radioButtonMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(69, 21);
            this.radioButtonMedium.TabIndex = 2;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "8 X 8";
            this.radioButtonMedium.UseVisualStyleBackColor = false;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonLarge.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLarge.Location = new System.Drawing.Point(209, 64);
            this.radioButtonLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(85, 21);
            this.radioButtonLarge.TabIndex = 3;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "10 X 10";
            this.radioButtonLarge.UseVisualStyleBackColor = false;
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayerOne.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayerOne.Location = new System.Drawing.Point(48, 139);
            this.labelPlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(99, 25);
            this.labelPlayerOne.Text = "player 1:";
            this.labelPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayers
            // 
            this.labelPlayers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayers.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers.Location = new System.Drawing.Point(29, 103);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(95, 25);
            this.labelPlayers.Text = "Players:";
            this.labelPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPlayerTwo
            // 
            this.checkBoxPlayerTwo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxPlayerTwo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPlayerTwo.Location = new System.Drawing.Point(44, 178);
            this.checkBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPlayerTwo.Name = "checkBoxPlayerTwo";
            this.checkBoxPlayerTwo.Size = new System.Drawing.Size(124, 25);
            this.checkBoxPlayerTwo.Text = "Player 2:";
            this.checkBoxPlayerTwo.UseVisualStyleBackColor = false;
            this.checkBoxPlayerTwo.CheckedChanged += new System.EventHandler(this.checkBoxPlayerTwo_CheckedChanged);
            // 
            // textBoxPlayerOneName
            // 
            this.textBoxPlayerOneName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPlayerOneName.Location = new System.Drawing.Point(176, 139);
            this.textBoxPlayerOneName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPlayerOneName.Name = "textBoxPlayerOneName";
            this.textBoxPlayerOneName.Size = new System.Drawing.Size(132, 22);
            this.textBoxPlayerOneName.TabIndex = 4;
            // 
            // textBoxPlayerTwoName
            // 
            this.textBoxPlayerTwoName.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPlayerTwoName.Enabled = false;
            this.textBoxPlayerTwoName.Location = new System.Drawing.Point(176, 178);
            this.textBoxPlayerTwoName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPlayerTwoName.Name = "textBoxPlayerTwoName";
            this.textBoxPlayerTwoName.Size = new System.Drawing.Size(132, 22);
            this.textBoxPlayerTwoName.TabIndex = 5;
            this.textBoxPlayerTwoName.Text = "[Computer]";
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(209, 235);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(100, 28);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormGameSettings
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 283);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxPlayerTwoName);
            this.Controls.Add(this.textBoxPlayerOneName);
            this.Controls.Add(this.checkBoxPlayerTwo);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelPlayerOne);
            this.Controls.Add(this.radioButtonLarge);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonSmall);
            this.Controls.Add(this.labelBoardSize);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.CheckBox checkBoxPlayerTwo;
        private System.Windows.Forms.TextBox textBoxPlayerOneName;
        private System.Windows.Forms.TextBox textBoxPlayerTwoName;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label labelBoardSize;
    }
}