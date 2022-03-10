using System;
using System.Windows.Forms;



namespace Tempo_de_atraso
{
    public partial class Principal : Form
    {


        public Principal()
        {
            
            InitializeComponent();
            var atraso = new TimeSpan(0, 0, 0);
            var toleranciaEmp = new TimeSpan(0, 10, 0);
            
            lblAtraso01.Visible = false;
            lblAtraso02.Visible = false;
            
            lblHoraExtra.Text = "Hora extra: " + atraso.ToString();
            lblTol.Text = "Tolerância: " + toleranciaEmp.ToString();
            lblAtrasoTotal.Text = "Atraso Total: " + atraso.ToString();
            
        }
        
       
        private void btnCalculator_Click1(object sender, EventArgs e)
        {
            


            //Valores da empresa
            var horarioEmpresaEmpInt = new TimeSpan(7, 30, 0);
            var horarioPauseEmpInt = new TimeSpan(12, 0, 0);
            var horarioVoltaEmpOut = new TimeSpan(13, 15, 0);
            var horarioEmpresaEmpOut = new TimeSpan(17, 30, 0);
            var toleranciaEmp = new TimeSpan(0, 10, 0);

            var atraso = new TimeSpan(0, 0, 0);
            var atraso01 = new TimeSpan();
            var horaExtra = new TimeSpan();


            //Converte string para ser armazenado em TimeSpan
            //Valores dos funcionarios

           


            var entraFunc = TimeSpan.Parse(entradaCamp.Text);
            var voltaFunc = TimeSpan.Parse(voltaCamp.Text);
            var saidaFunc = TimeSpan.Parse(saidaCamp.Text);
            atraso01 = voltaFunc.Subtract(horarioVoltaEmpOut);
            atraso = entraFunc.Subtract(horarioEmpresaEmpInt);


            var tolerancia01 = toleranciaEmp.Subtract(atraso + atraso01);

            lblTol.Text = "Tolerância: " + tolerancia01.ToString();

            if (horarioEmpresaEmpInt >= entraFunc || voltaFunc >= horarioVoltaEmpOut && atraso > toleranciaEmp) //Verificação de entrada
            {
                
                var atrasoTotal = atraso.Add(atraso01);

                lblAtrasoTotal.Text = "Atraso Total: " + atrasoTotal.ToString();

                lblAtraso02.Text = "Atraso: " + atraso01.ToString();

                lblAtraso01.Text = "Atraso: " + atraso.ToString();
                lblAtraso02.Visible = true;
                lblAtraso01.Visible = true;


                if (saidaFunc.CompareTo(horarioEmpresaEmpOut) == 1)//Verificação de hora extra
                {
                    horaExtra = saidaFunc.Subtract(horarioEmpresaEmpOut);

                    if (atrasoTotal.CompareTo(toleranciaEmp) == 1)
                    {

                        var tempoTrabalhado = atrasoTotal.Subtract(horaExtra);
                        lblAtraso02.Text = "Atraso: " + tempoTrabalhado.ToString();

                        lblAtraso01.Text = "Atraso: " + tempoTrabalhado.ToString();
                        lblAtrasoTotal.Text = "Atraso Total: " + tempoTrabalhado.ToString();
                        lblHoraExtra.Text = "Hora extra: " + horaExtra.ToString();

                    }

                    lblHoraExtra.Text = "Hora extra: " + horaExtra.ToString();

                }


               



            }
            else
            {
                lblAtraso01.Visible = false;
                lblAtraso02.Visible = false;
            }
        }


        private void arredondar()
        {
        }


        private void btnAuto(object sender, EventArgs e)//Preencher auto os campos de texto
        {
            var atraso = new TimeSpan(0, 0, 0);
            var toleranciaEmp = new TimeSpan(0, 10, 0);
            lblTol.Text = "Tolerância: " + toleranciaEmp.ToString();
            lblAtraso02.Text = "Atraso: " + atraso.ToString();
            lblAtraso01.Text = "Atraso: " + atraso.ToString();
            lblAtraso01.Visible = false;
            lblAtraso02.Visible = false;
            entradaCamp.Text = "7:30";
            pausaCamp.Text = "12:00";
            voltaCamp.Text = "13:15";
            saidaCamp.Text = "17:30";
            lblHoraExtra.Text = "Hora extra: " + atraso.ToString();
            lblAtrasoTotal.Text = "Atraso Total: " + atraso.ToString();
        }

        
        private void exportaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tabelas tb = new Tabelas();
            tb.Show();
           



        }
    }
}
