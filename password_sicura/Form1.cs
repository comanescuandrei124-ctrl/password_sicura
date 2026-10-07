using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_sicura
{
    public partial class Form1 : Form
    {
        private int contatore = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string password =txt_n1.Text.Trim();

            if (password == "Cyber2026")
            {
                MessageBox.Show("Password corretta!");
                Application.Exit();
            }
            else
            {
                contatore++; // Incrementa il contatore ad ogni errore

                if (contatore >= 3)
                {
                    MessageBox.Show("Troppi tentativi errati. Account bloccato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error); //che figata il MessageBoxIcon. non sapevo che esistesse
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Password errata! Tentativo {contatore} di 3.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

    }
}

