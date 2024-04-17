namespace Quizz_SarahBarakat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.buttonSaveMe = new System.Windows.Forms.Button();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelWWvsCont = new System.Windows.Forms.Panel();
            this.radioButtonContinent = new System.Windows.Forms.RadioButton();
            this.radioButtonWW = new System.Windows.Forms.RadioButton();
            this.lblFirstChoice = new System.Windows.Forms.Label();
            this.lblGameChoice = new System.Windows.Forms.Label();
            this.panelContinent = new System.Windows.Forms.Panel();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.lblChooseContinent = new System.Windows.Forms.Label();
            this.panelFootnote = new System.Windows.Forms.Panel();
            this.pictureBoxContinent = new System.Windows.Forms.PictureBox();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.panelChoice1 = new System.Windows.Forms.Panel();
            this.rBCapital = new System.Windows.Forms.RadioButton();
            this.rBCountry = new System.Windows.Forms.RadioButton();
            this.rBFlag = new System.Windows.Forms.RadioButton();
            this.panelChoice2 = new System.Windows.Forms.Panel();
            this.radioButtonCapital = new System.Windows.Forms.RadioButton();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.radioButtonFlag = new System.Windows.Forms.RadioButton();
            this.labelAnswers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panelWWvsCont.SuspendLayout();
            this.panelContinent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinent)).BeginInit();
            this.panelChoice1.SuspendLayout();
            this.panelChoice2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(313, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(505, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Country - Capital - Flag Quizz";
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Location = new System.Drawing.Point(617, 97);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(515, 411);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 1;
            this.pictureBoxStart.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.buttonSaveMe);
            this.panelUser.Controls.Add(this.textBoxPlayer);
            this.panelUser.Controls.Add(this.lblName);
            this.panelUser.Location = new System.Drawing.Point(18, 97);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(499, 156);
            this.panelUser.TabIndex = 2;
            // 
            // buttonSaveMe
            // 
            this.buttonSaveMe.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveMe.Location = new System.Drawing.Point(356, 66);
            this.buttonSaveMe.Name = "buttonSaveMe";
            this.buttonSaveMe.Size = new System.Drawing.Size(110, 34);
            this.buttonSaveMe.TabIndex = 2;
            this.buttonSaveMe.Text = "That´s me";
            this.buttonSaveMe.UseVisualStyleBackColor = true;
            this.buttonSaveMe.Click += new System.EventHandler(this.buttonSaveMe_Click);
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer.Location = new System.Drawing.Point(216, 20);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(250, 30);
            this.textBoxPlayer.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Who are you?*";
            // 
            // panelWWvsCont
            // 
            this.panelWWvsCont.Controls.Add(this.radioButtonContinent);
            this.panelWWvsCont.Controls.Add(this.radioButtonWW);
            this.panelWWvsCont.Controls.Add(this.lblFirstChoice);
            this.panelWWvsCont.Location = new System.Drawing.Point(18, 458);
            this.panelWWvsCont.Name = "panelWWvsCont";
            this.panelWWvsCont.Size = new System.Drawing.Size(499, 158);
            this.panelWWvsCont.TabIndex = 3;
            this.panelWWvsCont.Visible = false;
            // 
            // radioButtonContinent
            // 
            this.radioButtonContinent.AutoSize = true;
            this.radioButtonContinent.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonContinent.Location = new System.Drawing.Point(309, 64);
            this.radioButtonContinent.Name = "radioButtonContinent";
            this.radioButtonContinent.Size = new System.Drawing.Size(107, 27);
            this.radioButtonContinent.TabIndex = 2;
            this.radioButtonContinent.TabStop = true;
            this.radioButtonContinent.Text = "Continent";
            this.radioButtonContinent.UseVisualStyleBackColor = true;
            this.radioButtonContinent.CheckedChanged += new System.EventHandler(this.radioButtonContinent_CheckedChanged);
            // 
            // radioButtonWW
            // 
            this.radioButtonWW.AutoSize = true;
            this.radioButtonWW.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWW.Location = new System.Drawing.Point(309, 21);
            this.radioButtonWW.Name = "radioButtonWW";
            this.radioButtonWW.Size = new System.Drawing.Size(110, 27);
            this.radioButtonWW.TabIndex = 1;
            this.radioButtonWW.TabStop = true;
            this.radioButtonWW.Text = "worldwide";
            this.radioButtonWW.UseVisualStyleBackColor = true;
            this.radioButtonWW.CheckedChanged += new System.EventHandler(this.radioButtonWW_CheckedChanged);
            // 
            // lblFirstChoice
            // 
            this.lblFirstChoice.AutoSize = true;
            this.lblFirstChoice.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstChoice.Location = new System.Drawing.Point(19, 21);
            this.lblFirstChoice.Name = "lblFirstChoice";
            this.lblFirstChoice.Size = new System.Drawing.Size(237, 23);
            this.lblFirstChoice.TabIndex = 0;
            this.lblFirstChoice.Text = "What would you like to play?";
            // 
            // lblGameChoice
            // 
            this.lblGameChoice.AutoSize = true;
            this.lblGameChoice.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameChoice.Location = new System.Drawing.Point(3, 12);
            this.lblGameChoice.Name = "lblGameChoice";
            this.lblGameChoice.Size = new System.Drawing.Size(206, 23);
            this.lblGameChoice.TabIndex = 0;
            this.lblGameChoice.Text = "Choose your playing field";
            // 
            // panelContinent
            // 
            this.panelContinent.Controls.Add(this.comboBoxContinent);
            this.panelContinent.Controls.Add(this.lblChooseContinent);
            this.panelContinent.Location = new System.Drawing.Point(18, 622);
            this.panelContinent.Name = "panelContinent";
            this.panelContinent.Size = new System.Drawing.Size(499, 109);
            this.panelContinent.TabIndex = 5;
            this.panelContinent.Visible = false;
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(290, 17);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(176, 31);
            this.comboBoxContinent.TabIndex = 1;
            this.comboBoxContinent.SelectedIndexChanged += new System.EventHandler(this.comboBoxContinent_SelectedIndexChanged);
            // 
            // lblChooseContinent
            // 
            this.lblChooseContinent.AutoSize = true;
            this.lblChooseContinent.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseContinent.Location = new System.Drawing.Point(19, 17);
            this.lblChooseContinent.Name = "lblChooseContinent";
            this.lblChooseContinent.Size = new System.Drawing.Size(212, 23);
            this.lblChooseContinent.TabIndex = 0;
            this.lblChooseContinent.Text = "Please choose a continent";
            // 
            // panelFootnote
            // 
            this.panelFootnote.Location = new System.Drawing.Point(18, 737);
            this.panelFootnote.Name = "panelFootnote";
            this.panelFootnote.Size = new System.Drawing.Size(503, 60);
            this.panelFootnote.TabIndex = 6;
            // 
            // pictureBoxContinent
            // 
            this.pictureBoxContinent.Location = new System.Drawing.Point(768, 560);
            this.pictureBoxContinent.Name = "pictureBoxContinent";
            this.pictureBoxContinent.Size = new System.Drawing.Size(199, 192);
            this.pictureBoxContinent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContinent.TabIndex = 7;
            this.pictureBoxContinent.TabStop = false;
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.Location = new System.Drawing.Point(1010, 690);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(148, 61);
            this.btnLetsPlay.TabIndex = 8;
            this.btnLetsPlay.Text = "Great, let´s play!";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // panelChoice1
            // 
            this.panelChoice1.Controls.Add(this.rBCapital);
            this.panelChoice1.Controls.Add(this.rBCountry);
            this.panelChoice1.Controls.Add(this.rBFlag);
            this.panelChoice1.Controls.Add(this.lblGameChoice);
            this.panelChoice1.Location = new System.Drawing.Point(17, 260);
            this.panelChoice1.Name = "panelChoice1";
            this.panelChoice1.Size = new System.Drawing.Size(263, 198);
            this.panelChoice1.TabIndex = 9;
            this.panelChoice1.Visible = false;
            // 
            // rBCapital
            // 
            this.rBCapital.AutoSize = true;
            this.rBCapital.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCapital.Location = new System.Drawing.Point(56, 103);
            this.rBCapital.Name = "rBCapital";
            this.rBCapital.Size = new System.Drawing.Size(81, 27);
            this.rBCapital.TabIndex = 3;
            this.rBCapital.TabStop = true;
            this.rBCapital.Text = "capital";
            this.rBCapital.UseVisualStyleBackColor = true;
            // 
            // rBCountry
            // 
            this.rBCountry.AutoSize = true;
            this.rBCountry.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCountry.Location = new System.Drawing.Point(56, 66);
            this.rBCountry.Name = "rBCountry";
            this.rBCountry.Size = new System.Drawing.Size(89, 27);
            this.rBCountry.TabIndex = 2;
            this.rBCountry.TabStop = true;
            this.rBCountry.Text = "country";
            this.rBCountry.UseVisualStyleBackColor = true;
            this.rBCountry.CheckedChanged += new System.EventHandler(this.rBCountry_CheckedChanged);
            // 
            // rBFlag
            // 
            this.rBFlag.AutoSize = true;
            this.rBFlag.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBFlag.Location = new System.Drawing.Point(56, 138);
            this.rBFlag.Name = "rBFlag";
            this.rBFlag.Size = new System.Drawing.Size(59, 27);
            this.rBFlag.TabIndex = 1;
            this.rBFlag.TabStop = true;
            this.rBFlag.Text = "flag";
            this.rBFlag.UseVisualStyleBackColor = true;
            // 
            // panelChoice2
            // 
            this.panelChoice2.Controls.Add(this.radioButtonCapital);
            this.panelChoice2.Controls.Add(this.radioButtonCountry);
            this.panelChoice2.Controls.Add(this.radioButtonFlag);
            this.panelChoice2.Controls.Add(this.labelAnswers);
            this.panelChoice2.Location = new System.Drawing.Point(286, 260);
            this.panelChoice2.Name = "panelChoice2";
            this.panelChoice2.Size = new System.Drawing.Size(231, 198);
            this.panelChoice2.TabIndex = 10;
            this.panelChoice2.Visible = false;
            // 
            // radioButtonCapital
            // 
            this.radioButtonCapital.AutoSize = true;
            this.radioButtonCapital.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCapital.Location = new System.Drawing.Point(56, 103);
            this.radioButtonCapital.Name = "radioButtonCapital";
            this.radioButtonCapital.Size = new System.Drawing.Size(81, 27);
            this.radioButtonCapital.TabIndex = 7;
            this.radioButtonCapital.TabStop = true;
            this.radioButtonCapital.Text = "capital";
            this.radioButtonCapital.UseVisualStyleBackColor = true;
            this.radioButtonCapital.CheckedChanged += new System.EventHandler(this.rBCountry_CheckedChanged);
            // 
            // radioButtonCountry
            // 
            this.radioButtonCountry.AutoSize = true;
            this.radioButtonCountry.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCountry.Location = new System.Drawing.Point(56, 66);
            this.radioButtonCountry.Name = "radioButtonCountry";
            this.radioButtonCountry.Size = new System.Drawing.Size(89, 27);
            this.radioButtonCountry.TabIndex = 6;
            this.radioButtonCountry.TabStop = true;
            this.radioButtonCountry.Text = "country";
            this.radioButtonCountry.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlag
            // 
            this.radioButtonFlag.AutoSize = true;
            this.radioButtonFlag.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFlag.Location = new System.Drawing.Point(56, 138);
            this.radioButtonFlag.Name = "radioButtonFlag";
            this.radioButtonFlag.Size = new System.Drawing.Size(59, 27);
            this.radioButtonFlag.TabIndex = 5;
            this.radioButtonFlag.TabStop = true;
            this.radioButtonFlag.Text = "flag";
            this.radioButtonFlag.UseVisualStyleBackColor = true;
            this.radioButtonFlag.CheckedChanged += new System.EventHandler(this.rBCountry_CheckedChanged);
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoSize = true;
            this.labelAnswers.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswers.Location = new System.Drawing.Point(3, 12);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(167, 23);
            this.labelAnswers.TabIndex = 4;
            this.labelAnswers.Text = "Choose your answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 822);
            this.Controls.Add(this.panelChoice2);
            this.Controls.Add(this.panelChoice1);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.pictureBoxContinent);
            this.Controls.Add(this.panelFootnote);
            this.Controls.Add(this.panelContinent);
            this.Controls.Add(this.panelWWvsCont);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Country - Capital - Flag";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelWWvsCont.ResumeLayout(false);
            this.panelWWvsCont.PerformLayout();
            this.panelContinent.ResumeLayout(false);
            this.panelContinent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinent)).EndInit();
            this.panelChoice1.ResumeLayout(false);
            this.panelChoice1.PerformLayout();
            this.panelChoice2.ResumeLayout(false);
            this.panelChoice2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelWWvsCont;
        private System.Windows.Forms.Button buttonSaveMe;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.Label lblFirstChoice;
        private System.Windows.Forms.Label lblGameChoice;
        private System.Windows.Forms.Panel panelContinent;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.Label lblChooseContinent;
        private System.Windows.Forms.Panel panelFootnote;
        private System.Windows.Forms.RadioButton radioButtonContinent;
        private System.Windows.Forms.RadioButton radioButtonWW;
        private System.Windows.Forms.PictureBox pictureBoxContinent;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.Panel panelChoice1;
        private System.Windows.Forms.RadioButton rBCapital;
        private System.Windows.Forms.RadioButton rBCountry;
        private System.Windows.Forms.RadioButton rBFlag;
        private System.Windows.Forms.Panel panelChoice2;
        private System.Windows.Forms.RadioButton radioButtonCapital;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.RadioButton radioButtonFlag;
        private System.Windows.Forms.Label labelAnswers;
    }
}

