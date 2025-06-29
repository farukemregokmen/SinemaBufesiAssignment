namespace Sinema_Bufesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misirFiyati, suFiyati, cayFiyati, biletFiyati, toplam;
            misirFiyati = Convert.ToInt16(textBox1.Text) * 4;
            suFiyati = Convert.ToInt16(textBox2.Text) * 1;
            cayFiyati = Convert.ToInt16(textBox3.Text) * 2;
            biletFiyati = Convert.ToInt16(textBox4.Text) * 8;
            toplam = misirFiyati + suFiyati + cayFiyati + biletFiyati;
            kasa = kasa + toplam;
            label14.Text = toplam.ToString() + " TL";
            label16.Text = kasa.ToString() + " TL";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
