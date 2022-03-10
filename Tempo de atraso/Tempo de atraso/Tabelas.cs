using System;
using System.Data;
using System.Windows.Forms;

namespace Tempo_de_atraso
{
    public partial class Tabelas : Form
    {

        public DataTable dt = new DataTable();


        public Tabelas()
        {
            InitializeComponent();
            tabelaConfig();
        }

        public void tabelaConfig()// Cria os campos da tabela
        {

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Entrada", typeof(string));
            dt.Columns.Add("Pausa", typeof(string));
            dt.Columns.Add("Volta", typeof(string));
            dt.Columns.Add("Saída", typeof(string));


        }


        private void atualizarLinha()
        {                                         /*Enviar data já no formato 00/00/0000 */
            dt.Rows.Add(campName.Text, dateTimeCamp.Value.ToString("dd/MM/yyyy"), campEntrada02.Text, campPausa02.Text,
                                                                                    campVolta02.Text, campSaida02.Text);
            dataGridView1.DataSource = dt;
        }


        private bool validarCampo()
        {
            bool result = true;

            if (campName.Text.Equals(0))
            {
                MessageBox.Show("Campo nome é obrigatório.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campName.Focus();
                result = false;

            }
            else if (dateTimeCamp.Value.Equals(0))
            {
                MessageBox.Show("Campo de data é obrigatório.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeCamp.Focus();
                result = false;
            }
            return result;
        }

        private void btnAuto02_Click(object sender, EventArgs e)
        {//Preencher automatico os campos
            campEntrada02.Text = "7:30";
            campPausa02.Text = "12:00";
            campVolta02.Text = "13:15";
            campSaida02.Text = "17:30";

        }

        private void limparCampos()
        {

            campEntrada02.Clear();
            campPausa02.Clear();
            campVolta02.Clear();
            campSaida02.Clear();
            campName.Clear();
            dateTimeCamp.ResetText();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                atualizarLinha();
                limparCampos();
                campName.Focus();
            }
        }

        private void btnExport_Click(object sender, EventArgs e) //Exportar para excel.
        {

            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
