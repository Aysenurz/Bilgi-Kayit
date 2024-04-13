namespace Kayıt_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true; ;
            panel1.Visible = true;
            label13.Text = comboBox1.Text;
            label14.Text = textBox1.Text;
            label16.Text = textBox5.Text;
            label17.Text = textBox2.Text;
            label18.Text = textBox3.Text;
            label19.Text = textBox4.Text;
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BİLGİ KAYIT EKRANINA HOSGELDİNİZ :) ");
            MessageBox.Show("LÜTFEN İSTENEN BİLGİLERİ DOLDURUN!");
            MessageBox.Show("KAYIT EKRANI AÇILIYOR...");
            panel2.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
