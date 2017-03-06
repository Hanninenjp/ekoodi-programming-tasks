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
        //Binding will be done to the competition round jumps, this is just for testing the framework!
        private BindingList<EventCompetitor> _eventCompetitorsList;
        private BindingSource _eventCompetitorsSource;

        private EventRound _eventRound;
        private BindingList<Jump> _eventRoundBindingList;
        private BindingSource _eventRoundBindingSource;

        public FormMainView()
        {
            InitializeComponent();

            //Load event information, parameters and competitors from a file
            //This could be potentially handed by the event constructor!
            _event = EventLoader.LoadXML("../../../../Testevent.xml");
            
            /*
            //Competitors are currently used for testing!
            _eventCompetitorsList = new BindingList<EventCompetitor>(_event.Competitors);
            _eventCompetitorsSource = new BindingSource(_eventCompetitorsList, null);
                        
            MainEventRoundDataGrid.AutoGenerateColumns = false;
            MainEventRoundDataGrid.AutoSize = true;
            MainEventRoundDataGrid.DefaultCellStyle.BackColor = Color.LightYellow;
            MainEventRoundDataGrid.DataSource = _eventCompetitorsSource;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FisCode";
            column.Name = "FIS Code";
            MainEventRoundDataGrid.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastName";
            column.Name = "Last Name";
            MainEventRoundDataGrid.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FirstName";
            column.Name = "First Name";
            MainEventRoundDataGrid.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Nation";
            column.Name = "Nation";
            MainEventRoundDataGrid.Columns.Add(column);
            DataGridViewButtonColumn btncolumn = new DataGridViewButtonColumn();
            btncolumn.Name = "Score Jump";
            btncolumn.Text = "Score Jump";
            btncolumn.UseColumnTextForButtonValue = true;
            MainEventRoundDataGrid.Columns.Add(btncolumn);
            */

            //Get event round, create bindings and populate datagridview
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
            MainEventRoundDataGrid.Columns.Add(column);
            DataGridViewButtonColumn btncolumn = new DataGridViewButtonColumn();
            btncolumn.Name = "Score Jump";
            btncolumn.Text = "Score Jump";
            btncolumn.UseColumnTextForButtonValue = true;
            MainEventRoundDataGrid.Columns.Add(btncolumn);
        }

        private void MainEventRoundDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Handle jump scoring
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = senderGrid.Rows[e.RowIndex];
                DataGridViewButtonCell cell = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.UseColumnTextForButtonValue = false;
                cell.Value = "Revise\nScore";
                //cell.FlatStyle = FlatStyle.Flat;
                //cell.Style.BackColor = Color.LightSalmon;
                //cell.Style.SelectionBackColor = Color.LightSalmon;
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                //MessageBox.Show(String.Format("Button clicked!\nFIS Code: {0}", row.Cells["FIS Code"].Value.ToString()), "Scoring", MessageBoxButtons.OK);
                Jump jump = _eventRound.Jumps.ElementAt(e.RowIndex);
                Form scoreDialog = new FormScoreJump(jump, _event.Parameters);
                scoreDialog.ShowDialog();
                scoreDialog.Dispose();
                //Following will reset the whole list and all formattings will be lost!
                //_eventRoundBindingSource.ResetBindings(false);
                //Reset a single row instead
                _eventRoundBindingSource.ResetItem(e.RowIndex);
            }
        }
    }
}
