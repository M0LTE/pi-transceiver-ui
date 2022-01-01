namespace pi_transceiver_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frequencyDisplay1.Frequency = 144.300;
            pttIndicator1.SetPtt(false);
        }
    }
}