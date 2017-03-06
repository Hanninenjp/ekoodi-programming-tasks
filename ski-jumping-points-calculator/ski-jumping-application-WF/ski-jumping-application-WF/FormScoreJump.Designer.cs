namespace ski_jumping_application_WF
{
    partial class FormScoreJump
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
            this.FormScoreJumpTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FormScoreCompetitor = new System.Windows.Forms.GroupBox();
            this.FormScoreData = new System.Windows.Forms.GroupBox();
            this.CompetitorFisCodeLabel = new System.Windows.Forms.Label();
            this.CompetitorLastNameLabel = new System.Windows.Forms.Label();
            this.CompetitorFirstNameLabel = new System.Windows.Forms.Label();
            this.CompetitorNationLabel = new System.Windows.Forms.Label();
            this.CompetitorFisCodeText = new System.Windows.Forms.Label();
            this.CompetitorLastNameText = new System.Windows.Forms.Label();
            this.CompetitorFirstNameText = new System.Windows.Forms.Label();
            this.CompetitorNationText = new System.Windows.Forms.Label();
            this.JumpLengthLabel = new System.Windows.Forms.Label();
            this.JumpLengthValue = new System.Windows.Forms.NumericUpDown();
            this.JumpWindLabel = new System.Windows.Forms.Label();
            this.JumpWindValue = new System.Windows.Forms.NumericUpDown();
            this.JumpPlatformLabel = new System.Windows.Forms.Label();
            this.JumpPlatformValue = new System.Windows.Forms.NumericUpDown();
            this.JumpStyle1Label = new System.Windows.Forms.Label();
            this.JumpStyle1Value = new System.Windows.Forms.NumericUpDown();
            this.JumpStyle2Label = new System.Windows.Forms.Label();
            this.JumpStyle2Value = new System.Windows.Forms.NumericUpDown();
            this.JumpStyle3Label = new System.Windows.Forms.Label();
            this.JumpStyle3Value = new System.Windows.Forms.NumericUpDown();
            this.JumpStyle4Label = new System.Windows.Forms.Label();
            this.JumpStyle4Value = new System.Windows.Forms.NumericUpDown();
            this.JumpStyle5Label = new System.Windows.Forms.Label();
            this.JumpStyle5Value = new System.Windows.Forms.NumericUpDown();
            this.BtnSetScore = new System.Windows.Forms.Button();
            this.FormScoreJumpTableLayout.SuspendLayout();
            this.FormScoreCompetitor.SuspendLayout();
            this.FormScoreData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpLengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpWindValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpPlatformValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle3Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle4Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle5Value)).BeginInit();
            this.SuspendLayout();
            // 
            // FormScoreJumpTableLayout
            // 
            this.FormScoreJumpTableLayout.ColumnCount = 1;
            this.FormScoreJumpTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormScoreJumpTableLayout.Controls.Add(this.FormScoreCompetitor, 0, 0);
            this.FormScoreJumpTableLayout.Controls.Add(this.FormScoreData, 0, 1);
            this.FormScoreJumpTableLayout.Controls.Add(this.BtnSetScore, 0, 2);
            this.FormScoreJumpTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormScoreJumpTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FormScoreJumpTableLayout.Name = "FormScoreJumpTableLayout";
            this.FormScoreJumpTableLayout.RowCount = 3;
            this.FormScoreJumpTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FormScoreJumpTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.FormScoreJumpTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.FormScoreJumpTableLayout.Size = new System.Drawing.Size(272, 394);
            this.FormScoreJumpTableLayout.TabIndex = 0;
            // 
            // FormScoreCompetitor
            // 
            this.FormScoreCompetitor.Controls.Add(this.CompetitorNationText);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorFirstNameText);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorLastNameText);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorFisCodeText);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorNationLabel);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorFirstNameLabel);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorLastNameLabel);
            this.FormScoreCompetitor.Controls.Add(this.CompetitorFisCodeLabel);
            this.FormScoreCompetitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormScoreCompetitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormScoreCompetitor.Location = new System.Drawing.Point(3, 3);
            this.FormScoreCompetitor.Name = "FormScoreCompetitor";
            this.FormScoreCompetitor.Size = new System.Drawing.Size(266, 92);
            this.FormScoreCompetitor.TabIndex = 0;
            this.FormScoreCompetitor.TabStop = false;
            this.FormScoreCompetitor.Text = "Competitor";
            // 
            // FormScoreData
            // 
            this.FormScoreData.Controls.Add(this.JumpStyle5Value);
            this.FormScoreData.Controls.Add(this.JumpStyle5Label);
            this.FormScoreData.Controls.Add(this.JumpStyle4Value);
            this.FormScoreData.Controls.Add(this.JumpStyle4Label);
            this.FormScoreData.Controls.Add(this.JumpStyle3Value);
            this.FormScoreData.Controls.Add(this.JumpStyle3Label);
            this.FormScoreData.Controls.Add(this.JumpStyle2Value);
            this.FormScoreData.Controls.Add(this.JumpStyle2Label);
            this.FormScoreData.Controls.Add(this.JumpStyle1Value);
            this.FormScoreData.Controls.Add(this.JumpStyle1Label);
            this.FormScoreData.Controls.Add(this.JumpPlatformValue);
            this.FormScoreData.Controls.Add(this.JumpPlatformLabel);
            this.FormScoreData.Controls.Add(this.JumpWindValue);
            this.FormScoreData.Controls.Add(this.JumpWindLabel);
            this.FormScoreData.Controls.Add(this.JumpLengthValue);
            this.FormScoreData.Controls.Add(this.JumpLengthLabel);
            this.FormScoreData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormScoreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormScoreData.Location = new System.Drawing.Point(3, 101);
            this.FormScoreData.Name = "FormScoreData";
            this.FormScoreData.Size = new System.Drawing.Size(266, 250);
            this.FormScoreData.TabIndex = 1;
            this.FormScoreData.TabStop = false;
            this.FormScoreData.Text = "Jump data";
            // 
            // CompetitorFisCodeLabel
            // 
            this.CompetitorFisCodeLabel.AutoSize = true;
            this.CompetitorFisCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompetitorFisCodeLabel.Location = new System.Drawing.Point(7, 20);
            this.CompetitorFisCodeLabel.Name = "CompetitorFisCodeLabel";
            this.CompetitorFisCodeLabel.Size = new System.Drawing.Size(67, 16);
            this.CompetitorFisCodeLabel.TabIndex = 0;
            this.CompetitorFisCodeLabel.Text = "FIS Code:";
            // 
            // CompetitorLastNameLabel
            // 
            this.CompetitorLastNameLabel.AutoSize = true;
            this.CompetitorLastNameLabel.Location = new System.Drawing.Point(7, 37);
            this.CompetitorLastNameLabel.Name = "CompetitorLastNameLabel";
            this.CompetitorLastNameLabel.Size = new System.Drawing.Size(73, 16);
            this.CompetitorLastNameLabel.TabIndex = 1;
            this.CompetitorLastNameLabel.Text = "Last name:";
            // 
            // CompetitorFirstNameLabel
            // 
            this.CompetitorFirstNameLabel.AutoSize = true;
            this.CompetitorFirstNameLabel.Location = new System.Drawing.Point(7, 54);
            this.CompetitorFirstNameLabel.Name = "CompetitorFirstNameLabel";
            this.CompetitorFirstNameLabel.Size = new System.Drawing.Size(73, 16);
            this.CompetitorFirstNameLabel.TabIndex = 2;
            this.CompetitorFirstNameLabel.Text = "First name:";
            // 
            // CompetitorNationLabel
            // 
            this.CompetitorNationLabel.AutoSize = true;
            this.CompetitorNationLabel.Location = new System.Drawing.Point(7, 71);
            this.CompetitorNationLabel.Name = "CompetitorNationLabel";
            this.CompetitorNationLabel.Size = new System.Drawing.Size(50, 16);
            this.CompetitorNationLabel.TabIndex = 3;
            this.CompetitorNationLabel.Text = "Nation:";
            // 
            // CompetitorFisCodeText
            // 
            this.CompetitorFisCodeText.AutoSize = true;
            this.CompetitorFisCodeText.Location = new System.Drawing.Point(120, 20);
            this.CompetitorFisCodeText.Name = "CompetitorFisCodeText";
            this.CompetitorFisCodeText.Size = new System.Drawing.Size(53, 16);
            this.CompetitorFisCodeText.TabIndex = 4;
            this.CompetitorFisCodeText.Text = "<code>";
            // 
            // CompetitorLastNameText
            // 
            this.CompetitorLastNameText.AutoSize = true;
            this.CompetitorLastNameText.Location = new System.Drawing.Point(120, 37);
            this.CompetitorLastNameText.Name = "CompetitorLastNameText";
            this.CompetitorLastNameText.Size = new System.Drawing.Size(56, 16);
            this.CompetitorLastNameText.TabIndex = 5;
            this.CompetitorLastNameText.Text = "<name>";
            // 
            // CompetitorFirstNameText
            // 
            this.CompetitorFirstNameText.AutoSize = true;
            this.CompetitorFirstNameText.Location = new System.Drawing.Point(120, 54);
            this.CompetitorFirstNameText.Name = "CompetitorFirstNameText";
            this.CompetitorFirstNameText.Size = new System.Drawing.Size(56, 16);
            this.CompetitorFirstNameText.TabIndex = 6;
            this.CompetitorFirstNameText.Text = "<name>";
            // 
            // CompetitorNationText
            // 
            this.CompetitorNationText.AutoSize = true;
            this.CompetitorNationText.Location = new System.Drawing.Point(120, 71);
            this.CompetitorNationText.Name = "CompetitorNationText";
            this.CompetitorNationText.Size = new System.Drawing.Size(58, 16);
            this.CompetitorNationText.TabIndex = 7;
            this.CompetitorNationText.Text = "<nation>";
            // 
            // JumpLengthLabel
            // 
            this.JumpLengthLabel.AutoSize = true;
            this.JumpLengthLabel.Location = new System.Drawing.Point(7, 28);
            this.JumpLengthLabel.Name = "JumpLengthLabel";
            this.JumpLengthLabel.Size = new System.Drawing.Size(73, 16);
            this.JumpLengthLabel.TabIndex = 0;
            this.JumpLengthLabel.Text = "Length (m):";
            // 
            // JumpLengthValue
            // 
            this.JumpLengthValue.DecimalPlaces = 1;
            this.JumpLengthValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpLengthValue.Location = new System.Drawing.Point(123, 22);
            this.JumpLengthValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.JumpLengthValue.Name = "JumpLengthValue";
            this.JumpLengthValue.Size = new System.Drawing.Size(120, 22);
            this.JumpLengthValue.TabIndex = 1;
            this.JumpLengthValue.Enter += new System.EventHandler(this.JumpLengthValue_Enter);
            // 
            // JumpWindLabel
            // 
            this.JumpWindLabel.AutoSize = true;
            this.JumpWindLabel.Location = new System.Drawing.Point(7, 56);
            this.JumpWindLabel.Name = "JumpWindLabel";
            this.JumpWindLabel.Size = new System.Drawing.Size(93, 16);
            this.JumpWindLabel.TabIndex = 2;
            this.JumpWindLabel.Text = "Wind (+/- m/s):";
            // 
            // JumpWindValue
            // 
            this.JumpWindValue.DecimalPlaces = 1;
            this.JumpWindValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.JumpWindValue.Location = new System.Drawing.Point(123, 50);
            this.JumpWindValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpWindValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.JumpWindValue.Name = "JumpWindValue";
            this.JumpWindValue.Size = new System.Drawing.Size(120, 22);
            this.JumpWindValue.TabIndex = 3;
            this.JumpWindValue.Enter += new System.EventHandler(this.JumpWindValue_Enter);
            // 
            // JumpPlatformLabel
            // 
            this.JumpPlatformLabel.AutoSize = true;
            this.JumpPlatformLabel.Location = new System.Drawing.Point(7, 84);
            this.JumpPlatformLabel.Name = "JumpPlatformLabel";
            this.JumpPlatformLabel.Size = new System.Drawing.Size(100, 16);
            this.JumpPlatformLabel.TabIndex = 4;
            this.JumpPlatformLabel.Text = "Platform (+/- m):";
            // 
            // JumpPlatformValue
            // 
            this.JumpPlatformValue.DecimalPlaces = 1;
            this.JumpPlatformValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.JumpPlatformValue.Location = new System.Drawing.Point(123, 78);
            this.JumpPlatformValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.JumpPlatformValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.JumpPlatformValue.Name = "JumpPlatformValue";
            this.JumpPlatformValue.Size = new System.Drawing.Size(120, 22);
            this.JumpPlatformValue.TabIndex = 5;
            this.JumpPlatformValue.Enter += new System.EventHandler(this.JumpPlatformValue_Enter);
            // 
            // JumpStyle1Label
            // 
            this.JumpStyle1Label.AutoSize = true;
            this.JumpStyle1Label.Location = new System.Drawing.Point(7, 112);
            this.JumpStyle1Label.Name = "JumpStyle1Label";
            this.JumpStyle1Label.Size = new System.Drawing.Size(90, 16);
            this.JumpStyle1Label.TabIndex = 6;
            this.JumpStyle1Label.Text = "Style points 1:";
            // 
            // JumpStyle1Value
            // 
            this.JumpStyle1Value.DecimalPlaces = 1;
            this.JumpStyle1Value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpStyle1Value.Location = new System.Drawing.Point(123, 106);
            this.JumpStyle1Value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle1Value.Name = "JumpStyle1Value";
            this.JumpStyle1Value.Size = new System.Drawing.Size(120, 22);
            this.JumpStyle1Value.TabIndex = 7;
            this.JumpStyle1Value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle1Value.Enter += new System.EventHandler(this.JumpStyle1Value_Enter);
            // 
            // JumpStyle2Label
            // 
            this.JumpStyle2Label.AutoSize = true;
            this.JumpStyle2Label.Location = new System.Drawing.Point(7, 140);
            this.JumpStyle2Label.Name = "JumpStyle2Label";
            this.JumpStyle2Label.Size = new System.Drawing.Size(90, 16);
            this.JumpStyle2Label.TabIndex = 8;
            this.JumpStyle2Label.Text = "Style points 2:";
            // 
            // JumpStyle2Value
            // 
            this.JumpStyle2Value.DecimalPlaces = 1;
            this.JumpStyle2Value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpStyle2Value.Location = new System.Drawing.Point(123, 134);
            this.JumpStyle2Value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle2Value.Name = "JumpStyle2Value";
            this.JumpStyle2Value.Size = new System.Drawing.Size(120, 22);
            this.JumpStyle2Value.TabIndex = 9;
            this.JumpStyle2Value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle2Value.Enter += new System.EventHandler(this.JumpStyle2Value_Enter);
            // 
            // JumpStyle3Label
            // 
            this.JumpStyle3Label.AutoSize = true;
            this.JumpStyle3Label.Location = new System.Drawing.Point(7, 168);
            this.JumpStyle3Label.Name = "JumpStyle3Label";
            this.JumpStyle3Label.Size = new System.Drawing.Size(90, 16);
            this.JumpStyle3Label.TabIndex = 10;
            this.JumpStyle3Label.Text = "Style points 3:";
            // 
            // JumpStyle3Value
            // 
            this.JumpStyle3Value.DecimalPlaces = 1;
            this.JumpStyle3Value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpStyle3Value.Location = new System.Drawing.Point(123, 162);
            this.JumpStyle3Value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle3Value.Name = "JumpStyle3Value";
            this.JumpStyle3Value.Size = new System.Drawing.Size(120, 22);
            this.JumpStyle3Value.TabIndex = 11;
            this.JumpStyle3Value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle3Value.Enter += new System.EventHandler(this.JumpStyle3Value_Enter);
            // 
            // JumpStyle4Label
            // 
            this.JumpStyle4Label.AutoSize = true;
            this.JumpStyle4Label.Location = new System.Drawing.Point(7, 196);
            this.JumpStyle4Label.Name = "JumpStyle4Label";
            this.JumpStyle4Label.Size = new System.Drawing.Size(90, 16);
            this.JumpStyle4Label.TabIndex = 12;
            this.JumpStyle4Label.Text = "Style points 4:";
            // 
            // JumpStyle4Value
            // 
            this.JumpStyle4Value.DecimalPlaces = 1;
            this.JumpStyle4Value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpStyle4Value.Location = new System.Drawing.Point(123, 190);
            this.JumpStyle4Value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle4Value.Name = "JumpStyle4Value";
            this.JumpStyle4Value.Size = new System.Drawing.Size(120, 22);
            this.JumpStyle4Value.TabIndex = 13;
            this.JumpStyle4Value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle4Value.Enter += new System.EventHandler(this.JumpStyle4Value_Enter);
            // 
            // JumpStyle5Label
            // 
            this.JumpStyle5Label.AutoSize = true;
            this.JumpStyle5Label.Location = new System.Drawing.Point(7, 224);
            this.JumpStyle5Label.Name = "JumpStyle5Label";
            this.JumpStyle5Label.Size = new System.Drawing.Size(90, 16);
            this.JumpStyle5Label.TabIndex = 14;
            this.JumpStyle5Label.Text = "Style points 5:";
            // 
            // JumpStyle5Value
            // 
            this.JumpStyle5Value.DecimalPlaces = 1;
            this.JumpStyle5Value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.JumpStyle5Value.Location = new System.Drawing.Point(123, 218);
            this.JumpStyle5Value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle5Value.Name = "JumpStyle5Value";
            this.JumpStyle5Value.Size = new System.Drawing.Size(120, 22);
            this.JumpStyle5Value.TabIndex = 15;
            this.JumpStyle5Value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.JumpStyle5Value.Enter += new System.EventHandler(this.JumpStyle5Value_Enter);
            // 
            // BtnSetScore
            // 
            this.BtnSetScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnSetScore.Location = new System.Drawing.Point(98, 357);
            this.BtnSetScore.Name = "BtnSetScore";
            this.BtnSetScore.Size = new System.Drawing.Size(75, 34);
            this.BtnSetScore.TabIndex = 2;
            this.BtnSetScore.Text = "Set\r\nScore";
            this.BtnSetScore.UseVisualStyleBackColor = true;
            this.BtnSetScore.Click += new System.EventHandler(this.BtnSetScore_Click);
            // 
            // FormScoreJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 394);
            this.Controls.Add(this.FormScoreJumpTableLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScoreJump";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jump Scoring";
            this.TopMost = true;
            this.FormScoreJumpTableLayout.ResumeLayout(false);
            this.FormScoreCompetitor.ResumeLayout(false);
            this.FormScoreCompetitor.PerformLayout();
            this.FormScoreData.ResumeLayout(false);
            this.FormScoreData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpLengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpWindValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpPlatformValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle3Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle4Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpStyle5Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormScoreJumpTableLayout;
        private System.Windows.Forms.GroupBox FormScoreCompetitor;
        private System.Windows.Forms.GroupBox FormScoreData;
        private System.Windows.Forms.Label CompetitorNationText;
        private System.Windows.Forms.Label CompetitorFirstNameText;
        private System.Windows.Forms.Label CompetitorLastNameText;
        private System.Windows.Forms.Label CompetitorFisCodeText;
        private System.Windows.Forms.Label CompetitorNationLabel;
        private System.Windows.Forms.Label CompetitorFirstNameLabel;
        private System.Windows.Forms.Label CompetitorLastNameLabel;
        private System.Windows.Forms.Label CompetitorFisCodeLabel;
        private System.Windows.Forms.Label JumpPlatformLabel;
        private System.Windows.Forms.NumericUpDown JumpWindValue;
        private System.Windows.Forms.Label JumpWindLabel;
        private System.Windows.Forms.NumericUpDown JumpLengthValue;
        private System.Windows.Forms.Label JumpLengthLabel;
        private System.Windows.Forms.NumericUpDown JumpStyle5Value;
        private System.Windows.Forms.Label JumpStyle5Label;
        private System.Windows.Forms.NumericUpDown JumpStyle4Value;
        private System.Windows.Forms.Label JumpStyle4Label;
        private System.Windows.Forms.NumericUpDown JumpStyle3Value;
        private System.Windows.Forms.Label JumpStyle3Label;
        private System.Windows.Forms.NumericUpDown JumpStyle2Value;
        private System.Windows.Forms.Label JumpStyle2Label;
        private System.Windows.Forms.NumericUpDown JumpStyle1Value;
        private System.Windows.Forms.Label JumpStyle1Label;
        private System.Windows.Forms.NumericUpDown JumpPlatformValue;
        private System.Windows.Forms.Button BtnSetScore;
    }
}