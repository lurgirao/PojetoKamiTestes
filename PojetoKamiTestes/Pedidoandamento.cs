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

            // 🔥 cria os panels aqui (sem depender do Load)
            listaPanels = new List<Panel>()
    {
        Pedido1,
        Pedido2,
        Pedido3,
        Pedido4,
        Pedido5,
        Pedido6
    };

            foreach (var p in listaPanels)
            {
                p.Visible = false;
            }
        }

        public void AdicionarPedido(Dictionary<string, (double preco, int quantidade)> pedido)
        {
            // pega o primeiro panel livre
            Panel painelLivre = listaPanels.FirstOrDefault(p => !p.Visible);

            if (painelLivre == null)
            {
                MessageBox.Show("Limite de pedidos atingido!");
                return;
            }

            CriarCardPedido(painelLivre, pedido);
        }

        private void Pedidoandamento_Load(object sender, EventArgs e)
        {
            listaPanels = new List<Panel>()
    {
        Pedido1,
        Pedido2,
        Pedido3,
        Pedido4,
        Pedido5,
        Pedido6
    };

            // esconder todos no começo
            foreach (var p in listaPanels)
            {
                p.Visible = false;
            }
        }


        private void MostrarPedido()
        {
         
    }

        private void CriarCardPedido()

{        
        }
            private void CriarCardPedido(Panel painel, Dictionary<string, (double preco, int quantidade)> pedido)
        {
            painel.Controls.Clear();
            painel.Visible = true;

            string numeroPedido = contadorPedidos.ToString("D4");

            // título
            Label titulo = new Label();
            titulo.Text = "Pedido #" + numeroPedido;
            titulo.Font = new Font("Arial", 10, FontStyle.Bold);
            titulo.Location = new Point(10, 10);
            titulo.AutoSize = true;

            painel.Controls.Add(titulo);

            int y = 40;
            double total = 0;

            // itens
            foreach (var item in pedido)
            {
                Label lbl = new Label();
                lbl.Text = $"{item.Key} x{item.Value.quantidade}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                painel.Controls.Add(lbl);

                y += 20;
                total += item.Value.preco * item.Value.quantidade;
            }

            // total
            Label lblTotal = new Label();
            lblTotal.Text = "Total: R$ " + total.ToString("F2");
            lblTotal.Location = new Point(10, y + 10);
            lblTotal.AutoSize = true;

            painel.Controls.Add(lblTotal);

            // 🔥 BOTÃO (ESSENCIAL)
            Button btn = new Button();
            btn.Text = "Pedido concluído";
            btn.Size = new Size(130, 30);
            btn.Location = new Point(10, y + 40);

            btn.Click += (s, e) =>
            {
                painel.Controls.Clear();   // remove conteúdo
                painel.Visible = false;    // esconde panel
            };

            painel.Controls.Add(btn);

            contadorPedidos++;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
