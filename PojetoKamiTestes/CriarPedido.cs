using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoKamiTestes
{
    public partial class CriarPedido : Form
    {
        public CriarPedido()
        {
            InitializeComponent();
        }
                
        private void CriarPedido_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            private void btn_pedido_Click(object sender, EventArgs e)
        {
            panelDados.Controls.Clear();

            int y = 10;
            double total = 0;

            // ITEM 1
            if (chkItem1.Checked)
            {
                Label lbl = new Label();
                lbl.Text = chkItem1.Text;
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                panelDados.Controls.Add(lbl);

                y += 25;
                total += 15;
            }

            // ITEM 2
            if (chkItem2.Checked)
            {
                Label lbl = new Label();
                lbl.Text = chkItem2.Text;
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                panelDados.Controls.Add(lbl);

                y += 25;
                total += 5;
            }

            // TOTAL
            Label lblTotal = new Label();
            lblTotal.Text = "Total: R$ " + total;
            lblTotal.Location = new Point(10, y + 10);
            lblTotal.AutoSize = true;

            panelDados.Controls.Add(lblTotal);
        }
    }
    }
}
