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
    public partial class FrequencyDigit : UserControl
    {
        public FrequencyDigit()
        {
            InitializeComponent();
        }

        private void digit1_Click(object sender, EventArgs e)
        {

        }

        public override string Text { get => digit1.Text; set => digit1.Text = value; }

        public override Color ForeColor { get => digit1.ForeColor; set => digit1.ForeColor = value; }
    }
}
