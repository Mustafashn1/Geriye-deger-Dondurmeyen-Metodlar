using System.Windows.Forms;

namespace Geriye_değer_Döndürmeyen_Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Yazdir()
        {
            textBox1.Text = "Mustafa ";
            textBox2.Text = "Şahin ";
            textBox3.Text = " 26 ";
            textBox4.Text = " Kasap ";
            textBox1.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Yazdir();






        }





    }
}