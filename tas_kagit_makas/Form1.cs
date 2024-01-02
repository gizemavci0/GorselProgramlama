using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tas_kagit_makas
{
    public partial class Form1 : Form
    {
        public int kullanıcı_skor = 0;
        public int rakip_skor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rakip_secim = rand.Next(1,4);
            switch (rakip_secim)
            {
                case 1:
                    //taş - taş
                    label3.Text = "BERABERE";
                    label3.BackColor = Color.Yellow;
                    label1.Text = "TAŞ"; //kullanıcı seçim
                    label2.Text = "TAŞ"; //rakip seçim
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 2:
                    //taş - kağıt
                    label3.Text = "KAYBETTİN";
                    label3.BackColor = Color.Red;
                    label1.Text = "TAŞ"; //kullanıcı seçim
                    label2.Text = "KAĞIT"; //rakip seçim
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    rakip_skor++;
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 3:
                    //taş - makas
                    label3.Text = "KAZANDIN";
                    label3.BackColor = Color.Green;
                    label1.Text = "TAŞ"; //kullanıcı seçim
                    label2.Text = "MAKAS"; //rakip seçimi
                    kullanıcı_skor++;
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
            }
            oyun_sonu_kontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rakip_secim = rand.Next(1, 4);
            switch (rakip_secim)
            {
                case 1:
                    //kağıt - taş
                    label3.Text = "KAZANDIN";
                    label3.BackColor = Color.Green;
                    label1.Text = "KAĞIT"; //kullanıcı seçim
                    label2.Text = "TAŞ"; //rakip seçim
                    kullanıcı_skor++;
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 2:
                    //kağıt - kağıt
                    label3.Text = "BERABERE";
                    label3.BackColor = Color.Yellow;
                    label1.Text = "KAĞIT"; //kullanıcı seçim
                    label2.Text = "KAĞIT"; //rakip seçim
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 3:
                    //kağıt - makas
                    label3.Text = "KAYBETTİN";
                    label3.BackColor = Color.Red;
                    label1.Text = "KAĞIT"; //kullanıcı seçim
                    label2.Text = "MAKAS"; //rakip seçimi
                    rakip_skor++;
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
            }
            oyun_sonu_kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rakip_secim = rand.Next(1, 4);
            switch (rakip_secim)
            {
                case 1:
                    //makas - taş
                    label3.Text = "KAYBETTİN";
                    label3.BackColor = Color.Red;
                    label1.Text = "MAKAS"; //kullanıcı seçim
                    label2.Text = "TAŞ"; //rakip seçim
                    rakip_skor++;
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 2:
                    //makas - kağıt
                    label3.Text = "KAZANDIN";
                    label3.BackColor = Color.Green;
                    label1.Text = "MAKAS"; //kullanıcı seçim
                    label2.Text = "KAĞIT"; //rakip seçim
                    kullanıcı_skor++;
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;
                case 3:
                    //makas - makas
                    label3.Text = "BERABERE";
                    label3.BackColor = Color.Yellow;
                    label1.Text = "MAKAS"; //kullanıcı seçim
                    label2.Text = "MAKAS"; //rakip seçimi
                    label4.Text = Convert.ToString(kullanıcı_skor);
                    label5.Text = Convert.ToString(rakip_skor);
                    break;

            }
            oyun_sonu_kontrol();
        }
        private void oyun_sonu_kontrol()
        {
            if(kullanıcı_skor == 3)
            {
                MessageBox.Show(kullanıcı_skor+"-"+rakip_skor+" skor ile\nKAZANDINIZ");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

            if (rakip_skor == 3)
            {
                MessageBox.Show(kullanıcı_skor + "-" + rakip_skor + " skor ile\nKAYBETTİNİZ");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyunumuz bilgisayar ile kullanıcı arasında geçen tek kişilik oyundur. Skoru 3'e ilk ulaşan kazanır. Oyuna devam etmek isterseniz 'Tamam' tuşuna basabilirsiniz.", "Oyun Başlama Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Kullanıcı 'Tamam' tuşuna bastı, oyun başlatılıyor
                // Burada oyununuzun başlaması için gerekli kodları yazılabilir
            }
            else
            {
                // Kullanıcı 'İptal' tuşuna bastı, form kapatılıyor
                this.Close();
            }
        }
    }
}
