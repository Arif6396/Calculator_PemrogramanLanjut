using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (cmbOperasi.Items.Count > 0)
            {
                cmbOperasi.SelectedIndex = 0;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                double nilaiA = Convert.ToDouble(txtNilaiA.Text);
                double nilaiB = Convert.ToDouble(txtNilaiB.Text);
                double hasil = 0;

                string operasi = cmbOperasi.SelectedItem.ToString();

                switch (operasi)
                {
                    case "Penambahan":
                        hasil = nilaiA + nilaiB;
                        break;
                    case "Pengurangan":
                        hasil = nilaiA - nilaiB;
                        break;
                    case "Perkalian":
                        hasil = nilaiA * nilaiB;
                        break;
                    case "Pembagian":
                        if (nilaiB != 0)
                        {
                            hasil = nilaiA / nilaiB;
                        }
                        else
                        {
                            MessageBox.Show("Error: Tidak dapat membagi dengan nol!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Pilih operasi yang valid.");
                        return;
                }

                txtHasil.Text = hasil.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka yang valid untuk Nilai A dan Nilai B!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
