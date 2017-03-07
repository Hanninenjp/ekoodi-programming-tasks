namespace ski_jumping_application_WF
{
    partial class FormMainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainView));
            this.MainViewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainEventInformationPanel = new System.Windows.Forms.Panel();
            this.EventInformationDate = new System.Windows.Forms.Label();
            this.EventInformationHill = new System.Windows.Forms.Label();
            this.EventInformationVenue = new System.Windows.Forms.Label();
            this.EventInformationName = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabEventParameters = new System.Windows.Forms.TabPage();
            this.EventParametersGroup = new System.Windows.Forms.GroupBox();
            this.EventParametersText = new System.Windows.Forms.Label();
            this.MainTabRound = new System.Windows.Forms.TabPage();
            this.MainEventRoundDataGrid = new System.Windows.Forms.DataGridView();
            this.MainTabResults = new System.Windows.Forms.TabPage();
            this.MainEventResultsDataGrid = new System.Windows.Forms.DataGridView();
            this.MainViewLayout.SuspendLayout();
            this.MainEventInformationPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainTabEventParameters.SuspendLayout();
            this.EventParametersGroup.SuspendLayout();
            this.MainTabRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainEventRoundDataGrid)).BeginInit();
            this.MainTabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainEventResultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainViewLayout
            // 
            this.MainViewLayout.ColumnCount = 1;
            this.MainViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainViewLayout.Controls.Add(this.MainEventInformationPanel, 0, 0);
            this.MainViewLayout.Controls.Add(this.MainTabControl, 0, 1);
            this.MainViewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainViewLayout.Location = new System.Drawing.Point(0, 0);
            this.MainViewLayout.Name = "MainViewLayout";
            this.MainViewLayout.RowCount = 2;
            this.MainViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainViewLayout.Size = new System.Drawing.Size(784, 562);
            this.MainViewLayout.TabIndex = 0;
            // 
            // MainEventInformationPanel
            // 
            this.MainEventInformationPanel.Controls.Add(this.EventInformationDate);
            this.MainEventInformationPanel.Controls.Add(this.EventInformationHill);
            this.MainEventInformationPanel.Controls.Add(this.EventInformationVenue);
            this.MainEventInformationPanel.Controls.Add(this.EventInformationName);
            this.MainEventInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainEventInformationPanel.Location = new System.Drawing.Point(3, 3);
            this.MainEventInformationPanel.Name = "MainEventInformationPanel";
            this.MainEventInformationPanel.Size = new System.Drawing.Size(778, 106);
            this.MainEventInformationPanel.TabIndex = 0;
            // 
            // EventInformationDate
            // 
            this.EventInformationDate.AutoSize = true;
            this.EventInformationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventInformationDate.Location = new System.Drawing.Point(5, 82);
            this.EventInformationDate.Name = "EventInformationDate";
            this.EventInformationDate.Size = new System.Drawing.Size(62, 20);
            this.EventInformationDate.TabIndex = 3;
            this.EventInformationDate.Text = "<Date>";
            // 
            // EventInformationHill
            // 
            this.EventInformationHill.AutoSize = true;
            this.EventInformationHill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventInformationHill.Location = new System.Drawing.Point(5, 62);
            this.EventInformationHill.Name = "EventInformationHill";
            this.EventInformationHill.Size = new System.Drawing.Size(83, 20);
            this.EventInformationHill.TabIndex = 2;
            this.EventInformationHill.Text = "<Hill Size>";
            // 
            // EventInformationVenue
            // 
            this.EventInformationVenue.AutoSize = true;
            this.EventInformationVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventInformationVenue.Location = new System.Drawing.Point(4, 37);
            this.EventInformationVenue.Name = "EventInformationVenue";
            this.EventInformationVenue.Size = new System.Drawing.Size(98, 25);
            this.EventInformationVenue.TabIndex = 1;
            this.EventInformationVenue.Text = "<Venue>";
            // 
            // EventInformationName
            // 
            this.EventInformationName.AutoSize = true;
            this.EventInformationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventInformationName.Location = new System.Drawing.Point(3, 4);
            this.EventInformationName.Name = "EventInformationName";
            this.EventInformationName.Size = new System.Drawing.Size(209, 33);
            this.EventInformationName.TabIndex = 0;
            this.EventInformationName.Text = "<Event Name>";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTabEventParameters);
            this.MainTabControl.Controls.Add(this.MainTabRound);
            this.MainTabControl.Controls.Add(this.MainTabResults);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(3, 115);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(778, 444);
            this.MainTabControl.TabIndex = 1;
            // 
            // MainTabEventParameters
            // 
            this.MainTabEventParameters.BackColor = System.Drawing.SystemColors.Control;
            this.MainTabEventParameters.Controls.Add(this.EventParametersGroup);
            this.MainTabEventParameters.Location = new System.Drawing.Point(4, 22);
            this.MainTabEventParameters.Name = "MainTabEventParameters";
            this.MainTabEventParameters.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabEventParameters.Size = new System.Drawing.Size(770, 418);
            this.MainTabEventParameters.TabIndex = 0;
            this.MainTabEventParameters.Text = "Event parameters";
            // 
            // EventParametersGroup
            // 
            this.EventParametersGroup.BackColor = System.Drawing.SystemColors.Control;
            this.EventParametersGroup.Controls.Add(this.EventParametersText);
            this.EventParametersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventParametersGroup.Location = new System.Drawing.Point(3, 3);
            this.EventParametersGroup.Name = "EventParametersGroup";
            this.EventParametersGroup.Size = new System.Drawing.Size(764, 412);
            this.EventParametersGroup.TabIndex = 0;
            this.EventParametersGroup.TabStop = false;
            // 
            // EventParametersText
            // 
            this.EventParametersText.AutoSize = true;
            this.EventParametersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParametersText.Location = new System.Drawing.Point(7, 16);
            this.EventParametersText.Name = "EventParametersText";
            this.EventParametersText.Size = new System.Drawing.Size(128, 16);
            this.EventParametersText.TabIndex = 0;
            this.EventParametersText.Text = "<Event parameters>";
            // 
            // MainTabRound
            // 
            this.MainTabRound.BackColor = System.Drawing.SystemColors.Control;
            this.MainTabRound.Controls.Add(this.MainEventRoundDataGrid);
            this.MainTabRound.Location = new System.Drawing.Point(4, 22);
            this.MainTabRound.Name = "MainTabRound";
            this.MainTabRound.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabRound.Size = new System.Drawing.Size(770, 418);
            this.MainTabRound.TabIndex = 1;
            this.MainTabRound.Text = "Event round";
            // 
            // MainEventRoundDataGrid
            // 
            this.MainEventRoundDataGrid.AllowUserToAddRows = false;
            this.MainEventRoundDataGrid.AllowUserToDeleteRows = false;
            this.MainEventRoundDataGrid.AllowUserToResizeColumns = false;
            this.MainEventRoundDataGrid.AllowUserToResizeRows = false;
            this.MainEventRoundDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainEventRoundDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainEventRoundDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.MainEventRoundDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainEventRoundDataGrid.Location = new System.Drawing.Point(3, 3);
            this.MainEventRoundDataGrid.Name = "MainEventRoundDataGrid";
            this.MainEventRoundDataGrid.ReadOnly = true;
            this.MainEventRoundDataGrid.RowHeadersVisible = false;
            this.MainEventRoundDataGrid.Size = new System.Drawing.Size(764, 412);
            this.MainEventRoundDataGrid.TabIndex = 0;
            this.MainEventRoundDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainEventRoundDataGrid_CellContentClick);
            // 
            // MainTabResults
            // 
            this.MainTabResults.BackColor = System.Drawing.SystemColors.Control;
            this.MainTabResults.Controls.Add(this.MainEventResultsDataGrid);
            this.MainTabResults.Location = new System.Drawing.Point(4, 22);
            this.MainTabResults.Name = "MainTabResults";
            this.MainTabResults.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabResults.Size = new System.Drawing.Size(770, 418);
            this.MainTabResults.TabIndex = 2;
            this.MainTabResults.Text = "Event results";
            // 
            // MainEventResultsDataGrid
            // 
            this.MainEventResultsDataGrid.AllowUserToAddRows = false;
            this.MainEventResultsDataGrid.AllowUserToDeleteRows = false;
            this.MainEventResultsDataGrid.AllowUserToResizeColumns = false;
            this.MainEventResultsDataGrid.AllowUserToResizeRows = false;
            this.MainEventResultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainEventResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainEventResultsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainEventResultsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainEventResultsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.MainEventResultsDataGrid.Name = "MainEventResultsDataGrid";
            this.MainEventResultsDataGrid.ReadOnly = true;
            this.MainEventResultsDataGrid.RowHeadersVisible = false;
            this.MainEventResultsDataGrid.Size = new System.Drawing.Size(764, 412);
            this.MainEventResultsDataGrid.TabIndex = 0;
            // 
            // FormMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainViewLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EKoodi - Ski jumping points calculator";
            this.Load += new System.EventHandler(this.FormMainView_Load);
            this.Shown += new System.EventHandler(this.FormMainView_Shown);
            this.MainViewLayout.ResumeLayout(false);
            this.MainEventInformationPanel.ResumeLayout(false);
            this.MainEventInformationPanel.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.MainTabEventParameters.ResumeLayout(false);
            this.EventParametersGroup.ResumeLayout(false);
            this.EventParametersGroup.PerformLayout();
            this.MainTabRound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainEventRoundDataGrid)).EndInit();
            this.MainTabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainEventResultsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainViewLayout;
        private System.Windows.Forms.Panel MainEventInformationPanel;
        private System.Windows.Forms.Label EventInformationName;
        private System.Windows.Forms.Label EventInformationDate;
        private System.Windows.Forms.Label EventInformationHill;
        private System.Windows.Forms.Label EventInformationVenue;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabEventParameters;
        private System.Windows.Forms.TabPage MainTabRound;
        private System.Windows.Forms.TabPage MainTabResults;
        private System.Windows.Forms.DataGridView MainEventRoundDataGrid;
        private System.Windows.Forms.GroupBox EventParametersGroup;
        private System.Windows.Forms.Label EventParametersText;
        private System.Windows.Forms.DataGridView MainEventResultsDataGrid;
    }
}

