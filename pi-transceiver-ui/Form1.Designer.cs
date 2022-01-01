namespace pi_transceiver_ui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frequencyDisplay1 = new pi_transceiver_ui.FrequencyDisplay();
            this.pttIndicator1 = new pi_transceiver_ui.PttIndicator();
            this.SuspendLayout();
            // 
            // frequencyDisplay1
            // 
            this.frequencyDisplay1.AutoSize = true;
            this.frequencyDisplay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frequencyDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.frequencyDisplay1.Frequency = 0D;
            this.frequencyDisplay1.Location = new System.Drawing.Point(74, 154);
            this.frequencyDisplay1.Name = "frequencyDisplay1";
            this.frequencyDisplay1.Size = new System.Drawing.Size(668, 81);
            this.frequencyDisplay1.TabIndex = 9;
            // 
            // pttIndicator1
            // 
            this.pttIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.pttIndicator1.Location = new System.Drawing.Point(732, 12);
            this.pttIndicator1.Name = "pttIndicator1";
            this.pttIndicator1.Size = new System.Drawing.Size(56, 44);
            this.pttIndicator1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pttIndicator1);
            this.Controls.Add(this.frequencyDisplay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrequencyDisplay frequencyDisplay1;
        private PttIndicator pttIndicator1;
    }
}