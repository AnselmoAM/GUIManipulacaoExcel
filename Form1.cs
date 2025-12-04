using ClosedXML.Excel;


namespace GUIManipulaçãoExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "Planilhas Excel (*.xlsx)|*.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = dialog.FileName;
                cmbAbaDestino.Items.Clear();


                try
                {
                    using var workbook = new XLWorkbook(dialog.FileName);

                    foreach (var sheet in workbook.Worksheets)
                    {
                        cmbAbaDestino.Items.Add(sheet.Name);
                    }

                    if (cmbAbaDestino.Items.Count > 0)
                        cmbAbaDestino.SelectedIndex = 0;
                }
                catch (IOException)
                {
                    MessageBox.Show("Não foi possível abrir o arquivo porque ele está em uso.\nFeche a planilha no Excel e tente novamente.",
                                    "Arquivo bloqueado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtDestino.Text = "";
                    return;
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string origemPath = txtOrigem.Text;
            string destinoPath = txtDestino.Text;
            string abaDestino = cmbAbaDestino.SelectedItem?.ToString();

            if (!File.Exists(origemPath) || !File.Exists(destinoPath) || string.IsNullOrEmpty(abaDestino))
            {
                AppendLog("❌ Verifique os caminhos e a aba selecionada.");
                return;
            }

            try
            {
                AtualizarPlanilhas(origemPath, destinoPath, abaDestino);
                AppendLog("✅ Atualização concluída.");
            }
            catch (Exception ex)
            {
                AppendLog($"⚠️ Erro: {ex.Message}");
            }
        }
        private void AppendLog(string mensagem)
        {
            txtLog.AppendText(mensagem + Environment.NewLine);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
            txtLog.Refresh(); // força a atualização visual
            System.Threading.Thread.Sleep(50);

        }

        private void btnSelecionarOrigem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Filter = "Planilhas Excel (*.xlsx)|*.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOrigem.Text = dialog.FileName;
            }
        }

        private void AtualizarPlanilhas(string origemPath, string destinoPath, string abaDestino)
        {
            if (MessageBox.Show($"Tem certeza que deseja atualizar os dados da aba \"{abaDestino}\"?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return; // Cancela a execução se o usuário clicar "Não"
            }

            // Índices das colunas que você quer copiar da aba ERP
            //{colunaOrigem, colunaDestino}
            var colunasParaCopiar = new Dictionary<int, int>
            {
                { 1, 1 },   // Cód. Orçamento → coluna 1 da base
                { 2, 2 },   // Cliente → coluna 2 da base
                { 6, 3 },   // Valor Orçado → coluna 3 da base
                { 7, 4 },   // Condição de Pagamento → coluna 4 da base
                { 8, 6 },   // Data da Aprovação → coluna 6 da base
                { 10, 7 },  // Valor Aprovado → coluna 7 da base
                { 11, 8 }   // Número Ordem de Serviço → coluna 8 da base
};

            var baseWorkbook = new XLWorkbook(destinoPath);
            var erpWorkbook = new XLWorkbook(origemPath);

            var baseSheet = baseWorkbook.Worksheet(abaDestino);
            var erpSheet = erpWorkbook.Worksheet(1); // primeira aba do ERP

            int chaveCol = 1;
            int linhaCabecalho = 1;
            int ultimaLinhaBase = baseSheet.LastRowUsed().RowNumber();
            int ultimaLinhaERP = erpSheet.LastRowUsed().RowNumber();
            int linhaFinalOriginal = ultimaLinhaBase;
            int linhaNova = linhaFinalOriginal + 1;

            var colunas = new List<string>();
            int col = 1;
            while (!string.IsNullOrWhiteSpace(baseSheet.Cell(linhaCabecalho, col).GetString()))
            {
                string nomeColuna = baseSheet.Cell(linhaCabecalho, col).GetString().Trim();
                if (col != chaveCol) colunas.Add(nomeColuna);
                col++;
            }

            var orcamentosBase = new Dictionary<string, int>();
            for (int i = linhaCabecalho + 1; i <= ultimaLinhaBase; i++)
            {
                string numero = baseSheet.Cell(i, chaveCol).GetString().Trim();
                if (!string.IsNullOrEmpty(numero) && !orcamentosBase.ContainsKey(numero))
                    orcamentosBase[numero] = i;
            }

            for (int j = linhaCabecalho + 1; j <= ultimaLinhaERP; j++)
            {
                string numeroERP = erpSheet.Cell(j, chaveCol).GetString().Trim();
                if (string.IsNullOrWhiteSpace(numeroERP)) continue;

                if (orcamentosBase.TryGetValue(numeroERP, out int linhaBase))
                {
                    foreach (var par in colunasParaCopiar)
                    {
                        int colOrigem = par.Key;
                        int colDestino = par.Value;

                        string valorBase = baseSheet.Cell(linhaBase, colDestino).GetString().Trim();
                        string valorERP = erpSheet.Cell(j, colOrigem).GetString().Trim();

                        if (valorBase != valorERP)
                        {
                            baseSheet.Cell(linhaBase, colDestino).Value = valorERP;
                            //baseSheet.Cell(linhaBase, colDestino).Style.Fill.BackgroundColor = XLColor.LightYellow;
                            AppendLog($"🔄 Atualizado orçamento {numeroERP}: coluna {colDestino} de '{valorBase}' para '{valorERP}'");
                        }
                    }

                }
                else
                {


                    //ultimaLinhaBase++;
                    var linhaModelo = baseSheet.Row(linhaNova - 1);
                    var novaLinha = baseSheet.Row(linhaNova);
                    //linhaModelo.CopyTo(novaLinha);

                    //Copia só o estilo da linha anterior
                    for (int c = 1; c <= colunas.Count + 1; c++)
                    {
                        var estilo = linhaModelo.Cell(c).Style;
                        novaLinha.Cell(c).Style = estilo;
                    }

                    //loop de inserção
                    foreach (var par in colunasParaCopiar)
                    {
                        int colOrigem = par.Key;
                        int colDestino = par.Value;

                        string valorTexto = erpSheet.Cell(j, colOrigem).GetString();
                        var celula = novaLinha.Cell(colDestino);
                        string nomeColuna = baseSheet.Cell(1, colDestino).GetString();

                        if (nomeColuna.Contains("Data") && DateTime.TryParse(valorTexto, out DateTime data))
                        {
                            celula.Value = data;
                            celula.Style.DateFormat.Format = "dd/MM/yyyy";
                        }
                        else if ((nomeColuna.Contains("Valor") || nomeColuna.Contains("Preço")) && double.TryParse(valorTexto, out double valorNumerico))
                        {
                            celula.Value = valorNumerico;
                            celula.Style.NumberFormat.Format = "_-R$ * #,##0.00_-;-R$ * #,##0.00_-;_-R$ * \"-\"??_-;_-@_-";
                        }
                        else
                        {
                            celula.Value = valorTexto;
                        }
                    }

                    // Preencher dados...
                    AppendLog($"➕ Inserido orçamento {numeroERP} da linha {j}, da Planilha de Origem, na linha {linhaNova}, da Planilha de Destino.");

                    linhaNova++;
                }
            }

            baseWorkbook.Save();
        }
        private int GetColumnIndex(IXLWorksheet sheet, string columnName)
        {
            int col = 1;
            while (!string.IsNullOrWhiteSpace(sheet.Cell(1, col).GetString()))
            {
                if (sheet.Cell(1, col).GetString().Trim() == columnName)
                    return col;
                col++;
            }
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbAbaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
