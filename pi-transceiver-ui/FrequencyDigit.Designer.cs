namespace pi_transceiver_ui
{
    partial class FrequencyDigit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.digit1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.AutoSize = true;
            this.digit1.BackColor = System.Drawing.Color.Transparent;
            this.digit1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit1.ForeColor = System.Drawing.Color.White;
            this.digit1.Location = new System.Drawing.Point(3, 0);
            this.digit1.Margin = new System.Windows.Forms.Padding(0);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(70, 81);
            this.digit1.TabIndex = 10;
            this.digit1.Text = "0";
            this.digit1.Click += new System.EventHandler(this.digit1_Click);
            // 
            // FrequencyDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.digit1);
            this.Name = "FrequencyDigit";
            this.Size = new System.Drawing.Size(73, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label digit1;
    }
}
