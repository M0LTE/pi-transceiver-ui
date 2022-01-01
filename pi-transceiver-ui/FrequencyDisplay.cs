using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_transceiver_ui
{
    public partial class FrequencyDisplay : UserControl
    {
        private double frequency;

        public FrequencyDisplay()
        {
            InitializeComponent();
        }

        public double Frequency
        {
            get => frequency;
            set
            {
                frequency = value;
                UpdateUI();
            }
        }

        private static readonly Color DarkColour = Color.DarkSlateGray;

        private void UpdateUI()
        {
            var parts = frequency.ToString("0000.000");

            frequencyDigit1.Text = parts[0].ToString();
            frequencyDigit2.Text = parts[1].ToString();
            frequencyDigit3.Text = parts[2].ToString();
            frequencyDigit4.Text = parts[3].ToString();
            frequencyDigit5.Text = parts[5].ToString();
            frequencyDigit6.Text = parts[6].ToString();
            frequencyDigit7.Text = parts[7].ToString();

            frequencyDigit1.ForeColor = frequencyDigit1.Text == "0" ? DarkColour : Color.White;
            frequencyDigit2.ForeColor = frequencyDigit1.Text == "0" && frequencyDigit2.Text == "0" ? DarkColour : Color.White;
            frequencyDigit3.ForeColor = frequencyDigit1.Text == "0" && frequencyDigit2.Text == "0" && frequencyDigit3.Text == "0" ? DarkColour : Color.White;
            frequencyDigit4.ForeColor = frequencyDigit1.Text == "0" && frequencyDigit2.Text == "0" && frequencyDigit3.Text == "0" && frequencyDigit4.Text == "0" ? DarkColour : Color.White;
        }
    }
}
