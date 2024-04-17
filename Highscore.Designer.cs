namespace Quizz_SarahBarakat
{
    partial class Highscore
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
            this.dgvHighscore = new System.Windows.Forms.DataGridView();
            this.ColPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHighscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighscore
            // 
            this.dgvHighscore.AllowUserToAddRows = false;
            this.dgvHighscore.AllowUserToDeleteRows = false;
            this.dgvHighscore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighscore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPlayer,
            this.ColScore});
            this.dgvHighscore.Location = new System.Drawing.Point(181, 283);
            this.dgvHighscore.Name = "dgvHighscore";
            this.dgvHighscore.ReadOnly = true;
            this.dgvHighscore.RowHeadersWidth = 50;
            this.dgvHighscore.RowTemplate.Height = 24;
            this.dgvHighscore.Size = new System.Drawing.Size(412, 426);
            this.dgvHighscore.TabIndex = 0;
            // 
            // ColPlayer
            // 
            this.ColPlayer.HeaderText = "Player";
            this.ColPlayer.MinimumWidth = 6;
            this.ColPlayer.Name = "ColPlayer";
            this.ColPlayer.ReadOnly = true;
            // 
            // ColScore
            // 
            this.ColScore.HeaderText = "Score";
            this.ColScore.MinimumWidth = 6;
            this.ColScore.Name = "ColScore";
            this.ColScore.ReadOnly = true;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(304, 88);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(144, 38);
            this.lblHighscore.TabIndex = 1;
            this.lblHighscore.Text = "Highscore";
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.dgvHighscore);
            this.Name = "Highscore";
            this.Text = "Highscore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
        private System.Windows.Forms.Label lblHighscore;
    }
}