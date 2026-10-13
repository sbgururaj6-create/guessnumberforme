namespace GuessNumberforme
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
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbMin = new System.Windows.Forms.TrackBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TrackBar();
            this.lblGuess = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TrackBar();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // numMax
            // 
            this.numMax.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.numMax.Location = new System.Drawing.Point(12, 21);
            this.numMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMax.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 20);
            this.numMax.TabIndex = 0;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(172, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Pradėti";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(12, 47);
            this.tbMin.Maximum = 100;
            this.tbMin.Minimum = 1;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(300, 45);
            this.tbMin.TabIndex = 2;
            this.tbMin.Value = 1;
            // 
            // lblMin
            // 
            this.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMin.Location = new System.Drawing.Point(340, 47);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(54, 45);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "1";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMax.Location = new System.Drawing.Point(340, 111);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(54, 45);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "100";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(12, 111);
            this.tbMax.Maximum = 100;
            this.tbMax.Minimum = 1;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(300, 45);
            this.tbMax.TabIndex = 4;
            this.tbMax.Value = 100;
            // 
            // lblGuess
            // 
            this.lblGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuess.Location = new System.Drawing.Point(340, 182);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(54, 45);
            this.lblGuess.TabIndex = 7;
            this.lblGuess.Text = "1";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(12, 182);
            this.tbGuess.Maximum = 100;
            this.tbGuess.Minimum = 1;
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(300, 45);
            this.tbGuess.TabIndex = 6;
            this.tbGuess.Value = 1;
            this.tbGuess.Scroll += new System.EventHandler(this.tbGuess_Scroll);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(12, 229);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(80, 30);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Spėti";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(232, 229);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Naujas";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(98, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(128, 30);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 271);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atspėk skaičių!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar tbMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TrackBar tbMax;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TrackBar tbGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblMessage;
    }
}

