using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaOO
{
    public partial class Form1 : Form
    {
        private ContaCorrente C;

        public Form1()
        {
            InitializeComponent();

            C = new ContaCorrente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.Depositar(int.Parse(txtValor.Text));
            lblmensagem.Text = "Desposito realizado !";
            txtValor.Text = "";
            txtValor.Focus();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            C.Sacar(int.Parse(txtValor.Text));
            lblmensagem.Text = "Saque realizado !";
            txtValor.Text = "";
            txtValor.Focus();

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            lblmensagem.Text =  C.Saldo.ToString();
            txtValor.Text = "";
            txtValor.Focus();
        }
    }
}
