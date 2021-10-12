using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
       
        public decimal faktoriyel(decimal sayi1)
        {
            decimal toplam = 1;
            for (int i = 1; i <= sayi1; i++)
            {
                try
                {
                    toplam = toplam * i;
                }
                catch (System.OverflowException err)
                {
                    MessageBox.Show("Some Error Occured:"+ err.ToString());
                    break;

                }
                
            }
            return toplam;
        }
        public decimal kombinasyon(decimal sayi1, decimal sayi2)
        {
            decimal z = sayi1 - sayi2;
            decimal toplam = faktoriyel(sayi1) / (faktoriyel(z) * faktoriyel(sayi2));
            return toplam;
        }
        string oldlbl1,oldlbl2,oldlbl3;
        private void Form1_Load(object sender, EventArgs e)
        {
            oldlbl1 = gosterimFormul1.Text;
            oldlbl2 = gosterimFormul2.Text;
            oldlbl3 = gosterimFormul3.Text;
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            if (baslik.Text == "Faktoriyel")
               lblSonuc.Text = faktoriyel(Convert.ToDecimal(txtVar1.Text)).ToString();
            if (baslik.Text == "Kombinasyon")
                lblSonuc.Text = kombinasyon(Convert.ToDecimal(txtVar1.Text), Convert.ToDecimal(txtVar2.Text)).ToString();

                
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {   if(baslik.Text == "Faktoriyel")
            {
                baslik.Text = "Kombinasyon";
                gosterimFormul2.Visible = true;
                gosterimFormul1.Text = "x!";
                gosterimFormul3.Visible = true;
                txtVar2.Visible = true;
                lblvar2.Visible = true;
                lblvar2.Text = "y";
                lblVar1.Text = "x";
            }    
                
            else if (baslik.Text == "Kombinasyon")
            {
                baslik.Text = "Binom";
             
                txtVar2.Visible = true;
                lblvar2.Visible = true;
                lblvar2.Text = "y";
                lblVar1.Text = "x";
                lblvar3.Visible = true;
                txtVar3.Visible = true;
                lblvar3.Text = "n";
            }
                
            else if (baslik.Text == "Binom")
            {
                baslik.Text = "Faktoriyel";
                txtVar2.Visible = false;
                lblvar2.Visible = false;
                lblvar2.Text = "y";
                lblVar1.Text = "x";
                lblvar3.Visible = false;
                txtVar3.Visible = false;
                lblvar3.Text = "n";
                gosterimFormul1.Text = oldlbl1;
                gosterimFormul2.Visible = false;
                gosterimFormul3.Visible = false;
            }

               


        }

        private void txtVar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txtVar1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtVar1_KeyUp(object sender, KeyEventArgs e)
        {
            int x = 0;
            
            if (baslik.Text == "Kombinasyon")
            {
                
                try { x = int.Parse(txtVar1.Text); }
                catch (Exception) { }
                gosterimFormul1.Text = x + "!";
            }
            if (baslik.Text == "Faktoriyel")
            {
                
                
                try { x = int.Parse(txtVar1.Text); }
                catch (System.FormatException) { lbln.Text = "n"; }
                 lbln.Text = x.ToString();
            }
        }

        private void txtVar2_KeyUp(object sender, KeyEventArgs e)
        {
            int y = 0;
            int x = int.Parse(txtVar1.Text);

            if (txtVar2.Text != "")
            {
                y = int.Parse(txtVar2.Text);
            }


            gosterimFormul3.Text = "(" + (x - y).ToString() + "!*" + y + "!"+")";

            gosterimFormul1.Text = x + "!";
        }
    }
}
