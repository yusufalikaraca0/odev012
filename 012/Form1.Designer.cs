
namespace _012
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslik = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.grpGosterim = new System.Windows.Forms.GroupBox();
            this.formulBaslik = new System.Windows.Forms.Label();
            this.gosterimFormul1 = new System.Windows.Forms.Label();
            this.lblVar1 = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.lblvar2 = new System.Windows.Forms.Label();
            this.txtVar3 = new System.Windows.Forms.TextBox();
            this.lblvar3 = new System.Windows.Forms.Label();
            this.lblSonucBaslik = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.Hesapla = new System.Windows.Forms.Button();
            this.gosterimFormul2 = new System.Windows.Forms.Label();
            this.gosterimFormul3 = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.grpGosterim.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.baslik.Location = new System.Drawing.Point(141, 30);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(100, 24);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "Faktoriyel";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(319, 33);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(51, 23);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "--->";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // grpGosterim
            // 
            this.grpGosterim.Controls.Add(this.lbln);
            this.grpGosterim.Controls.Add(this.gosterimFormul3);
            this.grpGosterim.Controls.Add(this.gosterimFormul2);
            this.grpGosterim.Controls.Add(this.gosterimFormul1);
            this.grpGosterim.Controls.Add(this.formulBaslik);
            this.grpGosterim.Location = new System.Drawing.Point(172, 77);
            this.grpGosterim.Name = "grpGosterim";
            this.grpGosterim.Size = new System.Drawing.Size(210, 147);
            this.grpGosterim.TabIndex = 2;
            this.grpGosterim.TabStop = false;
            this.grpGosterim.Text = "Gösterim";
            // 
            // formulBaslik
            // 
            this.formulBaslik.AutoSize = true;
            this.formulBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.formulBaslik.Location = new System.Drawing.Point(7, 20);
            this.formulBaslik.Name = "formulBaslik";
            this.formulBaslik.Size = new System.Drawing.Size(87, 17);
            this.formulBaslik.TabIndex = 0;
            this.formulBaslik.Text = "N Faktoriyel;";
            // 
            // gosterimFormul1
            // 
            this.gosterimFormul1.AutoSize = true;
            this.gosterimFormul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.gosterimFormul1.Location = new System.Drawing.Point(58, 43);
            this.gosterimFormul1.Name = "gosterimFormul1";
            this.gosterimFormul1.Size = new System.Drawing.Size(81, 24);
            this.gosterimFormul1.TabIndex = 1;
            this.gosterimFormul1.Text = "1*2*3....*";
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVar1.Location = new System.Drawing.Point(12, 120);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(42, 24);
            this.lblVar1.TabIndex = 3;
            this.lblVar1.Text = "n = ";
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(51, 125);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(82, 20);
            this.txtVar1.TabIndex = 4;
            this.txtVar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar1_KeyPress);
            this.txtVar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVar1_KeyUp);
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(51, 167);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(82, 20);
            this.txtVar2.TabIndex = 6;
            this.txtVar2.Visible = false;
            this.txtVar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVar2_KeyPress);
            this.txtVar2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVar2_KeyUp);
            // 
            // lblvar2
            // 
            this.lblvar2.AutoSize = true;
            this.lblvar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblvar2.Location = new System.Drawing.Point(12, 162);
            this.lblvar2.Name = "lblvar2";
            this.lblvar2.Size = new System.Drawing.Size(42, 24);
            this.lblvar2.TabIndex = 5;
            this.lblvar2.Text = "n = ";
            this.lblvar2.Visible = false;
            // 
            // txtVar3
            // 
            this.txtVar3.Location = new System.Drawing.Point(51, 204);
            this.txtVar3.Name = "txtVar3";
            this.txtVar3.Size = new System.Drawing.Size(82, 20);
            this.txtVar3.TabIndex = 8;
            this.txtVar3.Visible = false;
            // 
            // lblvar3
            // 
            this.lblvar3.AutoSize = true;
            this.lblvar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblvar3.Location = new System.Drawing.Point(12, 199);
            this.lblvar3.Name = "lblvar3";
            this.lblvar3.Size = new System.Drawing.Size(42, 24);
            this.lblvar3.TabIndex = 7;
            this.lblvar3.Text = "n = ";
            this.lblvar3.Visible = false;
            // 
            // lblSonucBaslik
            // 
            this.lblSonucBaslik.AutoSize = true;
            this.lblSonucBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSonucBaslik.Location = new System.Drawing.Point(196, 254);
            this.lblSonucBaslik.Name = "lblSonucBaslik";
            this.lblSonucBaslik.Size = new System.Drawing.Size(70, 24);
            this.lblSonucBaslik.TabIndex = 9;
            this.lblSonucBaslik.Text = "Sonuc";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.lblSonuc.Location = new System.Drawing.Point(278, 257);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(55, 24);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "z∈{R}";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(16, 257);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(156, 23);
            this.Hesapla.TabIndex = 10;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // gosterimFormul2
            // 
            this.gosterimFormul2.AutoSize = true;
            this.gosterimFormul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gosterimFormul2.Location = new System.Drawing.Point(58, 78);
            this.gosterimFormul2.Name = "gosterimFormul2";
            this.gosterimFormul2.Size = new System.Drawing.Size(46, 24);
            this.gosterimFormul2.TabIndex = 2;
            this.gosterimFormul2.Text = "------";
            this.gosterimFormul2.Visible = false;
            // 
            // gosterimFormul3
            // 
            this.gosterimFormul3.AutoSize = true;
            this.gosterimFormul3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gosterimFormul3.Location = new System.Drawing.Point(58, 102);
            this.gosterimFormul3.Name = "gosterimFormul3";
            this.gosterimFormul3.Size = new System.Drawing.Size(73, 24);
            this.gosterimFormul3.TabIndex = 3;
            this.gosterimFormul3.Text = "(x-y)!*y!";
            this.gosterimFormul3.Visible = false;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.lbln.Location = new System.Drawing.Point(143, 43);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(21, 24);
            this.lbln.TabIndex = 4;
            this.lbln.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 558);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSonucBaslik);
            this.Controls.Add(this.txtVar3);
            this.Controls.Add(this.lblvar3);
            this.Controls.Add(this.txtVar2);
            this.Controls.Add(this.lblvar2);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.lblVar1);
            this.Controls.Add(this.grpGosterim);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGosterim.ResumeLayout(false);
            this.grpGosterim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.GroupBox grpGosterim;
        private System.Windows.Forms.Label gosterimFormul1;
        private System.Windows.Forms.Label formulBaslik;
        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.Label lblvar2;
        private System.Windows.Forms.TextBox txtVar3;
        private System.Windows.Forms.Label lblvar3;
        private System.Windows.Forms.Label lblSonucBaslik;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label gosterimFormul3;
        private System.Windows.Forms.Label gosterimFormul2;
        private System.Windows.Forms.Label lbln;
    }
}

