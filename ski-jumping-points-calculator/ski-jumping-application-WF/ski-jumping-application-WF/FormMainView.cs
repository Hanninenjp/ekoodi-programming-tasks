using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ekoodi.Sports;

namespace ski_jumping_application_WF
{
    public partial class FormMainView : Form
    {
        private Event _event;
        private EventRound _eventRound;
        private BindingList<Jump> _eventRoundBindingList;
        private BindingSource _eventRoundBindingSource;
        private BindingList<EventResult> _eventResultsBindingList;
        private BindingSource _eventResultsBindingSource;

        public FormMainView()
        {
            InitializeComponent();
            //Initializations are implemented in form shown event handler
        }

        private void MainEventRoundDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Handle jump scoring, if button is clicked in the datagrid button column
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Score jump
                Jump jump = _eventRound.Jumps.ElementAt(e.RowIndex);
                Form scoreDialog = new FormScoreJump(jump, _event.Parameters);
                if (scoreDialog.ShowDialog() != DialogResult.OK)
                {
                    //Jump was not scored, form was closed
                    scoreDialog.Dispose();
                    return;
                }
                scoreDialog.Dispose();
                //Update datagrid row, score has changed
                //Following will reset the whole list and all formattings will be lost
                //_eventRoundBindingSource.ResetBindings(false);
                //Reset a single row instead
                _eventRoundBindingSource.ResetItem(e.RowIndex);
                //Format datagrid row to reflect that jump has been scored
                DataGridViewRow row = senderGrid.Rows[e.RowIndex];
                DataGridViewButtonCell cell = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.UseColumnTextForButtonValue = false;
                cell.Value = "Revise\nScore";
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                //Update results
                //Results list is constructed and populated in Event constructor
                //Results for the competitor are just updated with the jump score
                _event.UpdateResult(jump.Competitor, jump.Score);
                //Results list is ordered by the Event after update
                //For an unknown reason the datagridview does not reflect changes in the bound datasource after the sort
                //This issue needs further investigation
                //A workaround is to create and bind the datasource again after each results update
                MainEventResultsDataGrid.DataSource = null;
                _eventResultsBindingList = new BindingList<EventResult>(_event.Results);
                _eventResultsBindingSource = new BindingSource(_eventResultsBindingList, null);
                MainEventResultsDataGrid.DataSource = _eventResultsBindingSource;
            }
        }

        private void FormMainView_Load(object sender, EventArgs e)
        {
            //Initializations are implemented in form shown event handler
        }

        private void FormMainView_Shown(object sender, EventArgs e)
        {
            try
            {
                //Display empty event information
                EventInformationName.Text = "No event information";
                EventInformationVenue.Text = String.Empty;
                EventInformationHill.Text = String.Empty;
                EventInformationDate.Text = String.Empty;

                //Display empty event parameters
                EventParametersText.Text = "No event parameters";

                //Load event configuration file and create Event
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Choose event configuration file";
                dialog.Filter = "XML files | *.xml";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //File selected, attempt to load and create event
                    String path = dialog.FileName;
                    _event = EventLoader.LoadXML(path);
                }
                else
                {
                    //No file selected, exit
                    Application.Exit();
                    return;
                }

                //Display event information
                EventInformationName.Text = _event.Name;
                EventInformationVenue.Text = String.Format("Venue: {0}", _event.Venue);
                EventInformationHill.Text = String.Format("Hill: {0}", _event.Hill);
                EventInformationDate.Text = String.Format("Date: {0}", _event.Date.ToShortDateString());

                //Display event parameters
                EventParametersText.Text = _event.Parameters.ToString();

                //Initialize and populate event round datagrid
                _eventRound = _event.GetFirstRound();
                _eventRoundBindingList = new BindingList<Jump>(_eventRound.Jumps);
                _eventRoundBindingSource = new BindingSource(_eventRoundBindingList, null);

                MainEventRoundDataGrid.AutoGenerateColumns = false;
                MainEventRoundDataGrid.AutoSize = true;
                MainEventRoundDataGrid.DefaultCellStyle.BackColor = Color.LightYellow;
                MainEventRoundDataGrid.DataSource = _eventRoundBindingSource;

                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorFisCode";
                column.Name = "FIS Code";
                MainEventRoundDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorLastName";
                column.Name = "Last Name";
                MainEventRoundDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorFirstName";
                column.Name = "First Name";
                MainEventRoundDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorNation";
                column.Name = "Nation";
                MainEventRoundDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Score";
                column.Name = "Score";
                column.DefaultCellStyle.Format = "F2";
                MainEventRoundDataGrid.Columns.Add(column);
                DataGridViewButtonColumn btncolumn = new DataGridViewButtonColumn();
                btncolumn.Name = "Score Jump";
                btncolumn.Text = "Score Jump";
                btncolumn.UseColumnTextForButtonValue = true;
                MainEventRoundDataGrid.Columns.Add(btncolumn);

                //Initialize and populate event results datagrid
                _eventResultsBindingList = new BindingList<EventResult>(_event.Results);
                _eventResultsBindingSource = new BindingSource(_eventResultsBindingList, null);

                MainEventResultsDataGrid.AutoGenerateColumns = false;
                MainEventResultsDataGrid.AutoSize = true;
                MainEventResultsDataGrid.DefaultCellStyle.BackColor = Color.LightYellow;
                MainEventResultsDataGrid.DataSource = _eventResultsBindingSource;

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorFisCode";
                column.Name = "FIS Code";
                MainEventResultsDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorLastName";
                column.Name = "Last Name";
                MainEventResultsDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorFirstName";
                column.Name = "First Name";
                MainEventResultsDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "CompetitorNation";
                column.Name = "Nation";
                MainEventResultsDataGrid.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Score";
                column.Name = "Score";
                column.DefaultCellStyle.Format = "F2";
                MainEventResultsDataGrid.Columns.Add(column);

                //Select event round tab
                MainTabControl.SelectTab("MainTabRound");
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}", exception.Message), "EKoodi - Ski jumping points calculator", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
