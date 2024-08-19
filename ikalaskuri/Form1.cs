namespace ikalaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeIkaBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;

            DateTime nyt = DateTime.Now;

            double erotus = Math.Round((nyt - synttari).TotalDays);

            VuottaLB.Text = Math.Ceiling(erotus /365.25) + " vuotta";

            KuukauttaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";

            PaivaaLB.Text = erotus + " p‰iv‰‰";

            TuntiaLB.Text = (erotus * 24) + " tuntia";

            MinuuttiaLB.Text = (erotus * 24 * 60) + " minuuttia";

            SekuntiaLB.Text = (erotus * 24 * 60 * 60) + " sekuntia";

            VuottaLB.Visible = true;

            KuukauttaLB.Visible= true;

            PaivaaLB.Visible = true;

            TuntiaLB.Visible = true;

            MinuuttiaLB.Visible = true;

            SekuntiaLB.Visible = true;
        }
    }
}
