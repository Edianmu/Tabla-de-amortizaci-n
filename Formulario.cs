using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaAmortizacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) //EVENTO CLICK
        {
            dataGridView1.Rows.Clear(); //CUANDO SE HACE CLICK SE LIMPIA LA GRILLA
            calcular(); //INICIA METODO
        }

        private void calcular()  //METODO PARA CALCULAR CUOTA FIJA
        {
            double monto = Convert.ToDouble(this.textMonto.Text);
            double tasainteres = Convert.ToDouble(this.textInteres.Text);
            int plazos = Convert.ToInt32(this.textPlazos.Text);
            tasainteres = tasainteres / 100;

            double intereses = 0, abonoCap = 0, saldoFinal = 0, sumaCuotas = 0;
            double saldoInicial = monto;

            //FORMUA DE CUOTA FIJA
            //double valorCuota = (double)(monto * (Math.Pow(1 + tasainteres, plazos) * tasainteres) / (Math.Pow(1 + tasainteres, plazos) - 1));
            double resultado = (1 - Math.Pow(1 + tasainteres, plazos * -1)) / tasainteres;
            double valorCuota = Math.Round(monto / resultado, 2);

            saldoFinal = saldoInicial;

            for (int I = 1; I <= plazos; I++)
            {
                var saldoFinalAnterior = Math.Round(saldoFinal, 2); //SE GUARDA VARIABLE ANTERIOR
                intereses = Math.Round(saldoFinal * tasainteres, 2);
                abonoCap = Math.Round(valorCuota - intereses, 2);
                saldoFinal = Math.Round(saldoFinal - abonoCap, 2);

                dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), valorCuota, intereses, abonoCap, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                sumaCuotas = Math.Round(sumaCuotas + valorCuota , 2); //ACUMULA LAS CUOTAS
            }

            this.lblResultado.Text = "$ "+sumaCuotas.ToString(); //MUESTRA SUMA EN EL LABEL
        }

        private void btnCalcularVar_Click(object sender, EventArgs e) //EVENTO CLICK DE BOTON CALCULO VARIABLE
        {
            dataGridView1.Rows.Clear(); //CUANDO SE HACE CLICK SE LIMPIA LA GRILLA
            calcularV(); //INICIA METODO
        }
        private void calcularV()  //METODO PARA CALCULAR CUOTA VARIABLE
        {
            double monto = Convert.ToDouble(this.textMonto.Text);
            double tasainteres = Convert.ToDouble(this.textInteres.Text);
            int plazos = Convert.ToInt32(this.textPlazos.Text);
            tasainteres = tasainteres / 100;

            double intereses = 0, valorCuota = 0, saldoFinal = 0, sumaCuotas= 0;
            double saldoInicial = monto;

            //FORMUA DE CUOTA ARIABLE

            double abonoCap = Math.Round(monto / plazos, 2);

            saldoFinal = saldoInicial;

            for (int I = 1; I <= plazos; I++)
            {
                var saldoFinalAnterior = Math.Round(saldoFinal, 2); //SE GUARDA VARIABLE ANTERIOR
                intereses = Math.Round(saldoFinal * (tasainteres), 2);
                valorCuota = Math.Round(abonoCap + intereses, 2);
                saldoFinal = Math.Round(saldoFinal - abonoCap, 2);

                dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), valorCuota, intereses, abonoCap, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                sumaCuotas = Math.Round(sumaCuotas + valorCuota, 2); //ACUMULA LAS CUOTAS
            }

            this.lblResultado.Text = "$ " + sumaCuotas.ToString(); //MUESTRA SUMA EN EL LABEL
        }
    }

 }

    
