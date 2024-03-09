using System;
using System.Windows.Forms;

namespace CopiarMensagens
{
    public class FormPrincipal : Form
    {
        private Button btnSemEnergia;
        private Button btnSemContatoLocal;

        public FormPrincipal()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configurar propriedades do formulário
            this.TopMost = true; // Mantém a janela sempre no topo

            // Inicializar os botões
            btnSemEnergia = new Button();
            btnSemEnergia.Text = "Sem Energia";
            btnSemEnergia.Click += btnSemEnergia_Click;

            btnSemContatoLocal = new Button();
            btnSemContatoLocal.Text = "Sem Contato Local";
            btnSemContatoLocal.Click += btnSemContatoLocal_Click;

            // Adicionar os botões ao formulário
            Controls.Add(btnSemEnergia);
            Controls.Add(btnSemContatoLocal);

            // Configurar outras configurações de layout, se necessário
        }

        private void btnSemEnergia_Click(object sender, EventArgs e)
        {
            string message = "Sem contato com a unidade. Devido queda simultânea dos links, possível queda de energia.";
            CopyAction(message);
        }

        private void btnSemContatoLocal_Click(object sender, EventArgs e)
        {
            string message = "Sem contato do local, solicitado auxílio do Cliente na validação interna.";
            CopyAction(message);
        }

        // ... outros métodos de botão e a função CopyAction

        private void CopyTextToClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        private void CopyAction(string message)
        {
            CopyTextToClipboard(message);
            MessageBox.Show("Mensagem copiada para a área de transferência!");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instanciando o FormPrincipal
            Application.Run(new FormPrincipal());
        }
    }
}
