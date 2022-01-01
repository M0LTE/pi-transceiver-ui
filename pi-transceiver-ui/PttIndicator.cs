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
    public partial class PttIndicator : UserControl
    {
        public PttIndicator()
        {
            InitializeComponent();

            label1.Font = new Font(label1.Font.FontFamily, 18f, FontStyle.Bold);
        }

        public void SetPtt(bool tx)
        {
            label1.ForeColor = tx ? Color.Red : Color.LimeGreen;
            label1.Text = tx ? "TX" : "RX";
        }
    }
}