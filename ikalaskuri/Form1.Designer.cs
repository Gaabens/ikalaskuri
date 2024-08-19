namespace ikalaskuri
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
            SyntymaAikaDT = new DateTimePicker();
            LaskeIkaBT = new Button();
            VuottaLB = new Label();
            TuntiaLB = new Label();
            KuukauttaLB = new Label();
            MinuuttiaLB = new Label();
            PaivaaLB = new Label();
            SekuntiaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(12, 28);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(300, 31);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeIkaBT
            // 
            LaskeIkaBT.Location = new Point(352, 28);
            LaskeIkaBT.Name = "LaskeIkaBT";
            LaskeIkaBT.Size = new Size(112, 34);
            LaskeIkaBT.TabIndex = 1;
            LaskeIkaBT.Text = "Laske ikä";
            LaskeIkaBT.UseVisualStyleBackColor = true;
            LaskeIkaBT.Click += LaskeIkaBT_Click;
            // 
            // VuottaLB
            // 
            VuottaLB.AutoSize = true;
            VuottaLB.Location = new Point(27, 120);
            VuottaLB.Name = "VuottaLB";
            VuottaLB.Size = new Size(65, 25);
            VuottaLB.TabIndex = 2;
            VuottaLB.Text = "Vuotta";
            VuottaLB.Visible = false;
            // 
            // TuntiaLB
            // 
            TuntiaLB.AutoSize = true;
            TuntiaLB.Location = new Point(238, 124);
            TuntiaLB.Name = "TuntiaLB";
            TuntiaLB.Size = new Size(60, 25);
            TuntiaLB.TabIndex = 3;
            TuntiaLB.Text = "Tuntia";
            TuntiaLB.Visible = false;
            // 
            // KuukauttaLB
            // 
            KuukauttaLB.AutoSize = true;
            KuukauttaLB.Location = new Point(27, 191);
            KuukauttaLB.Name = "KuukauttaLB";
            KuukauttaLB.Size = new Size(91, 25);
            KuukauttaLB.TabIndex = 4;
            KuukauttaLB.Text = "Kuukautta";
            KuukauttaLB.Visible = false;
            // 
            // MinuuttiaLB
            // 
            MinuuttiaLB.AutoSize = true;
            MinuuttiaLB.Location = new Point(238, 191);
            MinuuttiaLB.Name = "MinuuttiaLB";
            MinuuttiaLB.Size = new Size(87, 25);
            MinuuttiaLB.TabIndex = 5;
            MinuuttiaLB.Text = "Minuuttia";
            MinuuttiaLB.Visible = false;
            // 
            // PaivaaLB
            // 
            PaivaaLB.AutoSize = true;
            PaivaaLB.Location = new Point(27, 250);
            PaivaaLB.Name = "PaivaaLB";
            PaivaaLB.Size = new Size(61, 25);
            PaivaaLB.TabIndex = 6;
            PaivaaLB.Text = "Päivää";
            PaivaaLB.Visible = false;
            // 
            // SekuntiaLB
            // 
            SekuntiaLB.AutoSize = true;
            SekuntiaLB.Location = new Point(238, 250);
            SekuntiaLB.Name = "SekuntiaLB";
            SekuntiaLB.Size = new Size(79, 25);
            SekuntiaLB.TabIndex = 7;
            SekuntiaLB.Text = "Sekuntia";
            SekuntiaLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SekuntiaLB);
            Controls.Add(PaivaaLB);
            Controls.Add(MinuuttiaLB);
            Controls.Add(KuukauttaLB);
            Controls.Add(TuntiaLB);
            Controls.Add(VuottaLB);
            Controls.Add(LaskeIkaBT);
            Controls.Add(SyntymaAikaDT);
            Name = "Form1";
            Text = "Ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeIkaBT;
        private Label VuottaLB;
        private Label TuntiaLB;
        private Label KuukauttaLB;
        private Label MinuuttiaLB;
        private Label PaivaaLB;
        private Label SekuntiaLB;
    }
}
