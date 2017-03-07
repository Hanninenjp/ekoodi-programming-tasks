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
    public partial class FormScoreJump : Form
    {
        private Jump _jump;
        private EventParameters _parameters;

        public FormScoreJump(Jump jump, EventParameters parameters)
        {
            InitializeComponent();
            _jump = jump;
            _parameters = parameters;
            CompetitorFisCodeText.Text = _jump.CompetitorFisCode;
            CompetitorLastNameText.Text = _jump.CompetitorLastName;
            CompetitorFirstNameText.Text = _jump.CompetitorFirstName;
            CompetitorNationText.Text = _jump.CompetitorNation;
        }

        //Handle enter event to select control text when tabbed into control
        //This is intended to make entering the values more fluid

        private void JumpLengthValue_Enter(object sender, EventArgs e)
        {
            JumpLengthValue.Select(0, JumpLengthValue.Text.Length);
        }

        private void JumpWindValue_Enter(object sender, EventArgs e)
        {
            JumpWindValue.Select(0, JumpWindValue.Text.Length);
        }

        private void JumpPlatformValue_Enter(object sender, EventArgs e)
        {
            JumpPlatformValue.Select(0, JumpPlatformValue.Text.Length);
        }

        private void JumpStyle1Value_Enter(object sender, EventArgs e)
        {
            JumpStyle1Value.Select(0, JumpStyle1Value.Text.Length);
        }

        private void JumpStyle2Value_Enter(object sender, EventArgs e)
        {
            JumpStyle2Value.Select(0, JumpStyle2Value.Text.Length);
        }

        private void JumpStyle3Value_Enter(object sender, EventArgs e)
        {
            JumpStyle3Value.Select(0, JumpStyle3Value.Text.Length);
        }

        private void JumpStyle4Value_Enter(object sender, EventArgs e)
        {
            JumpStyle4Value.Select(0, JumpStyle4Value.Text.Length);
        }

        private void JumpStyle5Value_Enter(object sender, EventArgs e)
        {
            JumpStyle5Value.Select(0, JumpStyle5Value.Text.Length);
        }

        private void BtnSetScore_Click(object sender, EventArgs e)
        {
            //Handle jump scoring and close
            IList<double> stylePoints = new List<double>();
            stylePoints.Add((double)JumpStyle1Value.Value);
            stylePoints.Add((double)JumpStyle2Value.Value);
            stylePoints.Add((double)JumpStyle3Value.Value);
            stylePoints.Add((double)JumpStyle4Value.Value);
            stylePoints.Add((double)JumpStyle5Value.Value);
            //Positive change in platform (+meters in platform height) affects negatively to the score (-points)
            //User can simply enter the difference in the platform in meters
            JumpData jumpData = new JumpData((double)JumpLengthValue.Value, (double)JumpWindValue.Value, -(double)JumpPlatformValue.Value, stylePoints);
            _jump.ScoreJump(jumpData, _parameters);
            Close();
        }
    }
}
