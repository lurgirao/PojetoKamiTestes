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
 
    public partial class Pedidoandamento : Form
    {
        List<Panel> listaPanels;

        static int contadorPedidos = 1;

        public Pedidoandamento()
        {
            InitializeComponent();
        }

        Dictionary<string, (double preco, int quantidade)> pedidoRecebido;

        public Pedidoandamento(Dictionary<string, (double preco, int quantidade)> pedido)
        {
            InitializeComponent();
            pedidoRecebido = pedido;
        }

        private void Pedidoandamento_Load(object sender, EventArgs e)
        {
            listaPanels = new List<Panel>()
    {
        panelPedidos,
        Pedido2,
        Pedido3,
        Pedido4,
        Pedido5,
        Pedido6
    };

            CriarCardPedido(); 
        }
        
        private void MostrarPedido()
        {
            
        }

        private void CriarCardPedido()

        {
            int indice = contadorPedidos - 1;

            if (indice >= listaPanels.Count)
            {
                MessageBox.Show("Limite de pedidos atingido!");
                return;
            }

            Panel painelDestino = listaPanels[indice];
            painelDestino.Controls.Clear();

            string numeroPedido = contadorPedidos.ToString("D4");

            Label lblTitulo = new Label();
            lblTitulo.Text = "Pedido #" + numeroPedido;
            lblTitulo.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.AutoSize = true;

            painelDestino.Controls.Add(lblTitulo);

            int y = 40;
            double total = 0;

            foreach (var item in pedidoRecebido)
            {
                string nome = item.Key;
                double preco = item.Value.preco;
                int qtd = item.Value.quantidade;

                Label lbl = new Label();
                lbl.Text = $"{nome} x{qtd}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                painelDestino.Controls.Add(lbl);

                y += 20;
                total += preco * qtd;
            }

            Label lblTotal = new Label();
            lblTotal.Text = "Total: R$ " + total.ToString("F2");
            lblTotal.Location = new Point(10, y + 10);
            lblTotal.AutoSize = true;

            painelDestino.Controls.Add(lblTotal);

            contadorPedidos++;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}