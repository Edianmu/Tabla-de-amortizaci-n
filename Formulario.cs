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
            calcularF(); //INICIA METODO
        }

        private void calcularF()  //METODO PARA CALCULAR CUOTA FIJA
        {
            try
            {
                decimal monto =
                    Convert.ToDecimal(this.textMonto.Text);
                decimal tasainteres =
                    Convert.ToDecimal(this.textInteres.Text);
                int plazos =
                    Convert.ToInt16(this.textPlazos.Text);

                tasainteres = tasainteres / 100;

                decimal intereses = 0,
                    abonoCap = 0,
                    saldoFinal = 0,
                    sumaCuotas = 0,
                    saldoInicial = monto;

                if (monto != 0 && plazos != 0 && tasainteres != 0)
                {

                    //FORMUA DE CUOTA FIJA
                   
                    decimal resultado = 
                        ((1 - (decimal)Math.Pow(1 + (double)tasainteres, plazos * -1)) / tasainteres);
                    decimal valorCuota =
                        Math.Round(monto / resultado, 2);

                    saldoFinal = saldoInicial;

                    for (int I = 1; I <= plazos; I++)
                    {
                        var saldoFinalAnterior = 
                            Math.Round(saldoFinal, 2); //SE GUARDA VARIABLE ANTERIOR
                        intereses = 
                            Math.Round(saldoFinal * tasainteres, 2);
                        abonoCap = 
                            Math.Round(valorCuota - intereses, 2);
                        saldoFinal = 
                            Math.Round(saldoFinal - abonoCap, 2);

                        if (saldoFinal < 0.5m )
                        {
                            saldoFinal = 0;
                        }

                        dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), valorCuota, intereses, abonoCap, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                        sumaCuotas =
                            Math.Round(sumaCuotas + valorCuota, 2); //ACUMULA LAS CUOTAS
                    }

                    this.lblResultado.Text =
                        "$ " + sumaCuotas.ToString(); //MUESTRA SUMA EN EL LABEL
                }

            }
            catch (Exception ex) //bloque catch para captura de error
            {
                string error = ex.Message; //acción para manejar el error
            }
        }

        private void btnCalcularVar_Click(object sender, EventArgs e) //EVENTO CLICK DE BOTON CALCULO VARIABLE
        {
            dataGridView1.Rows.Clear(); //CUANDO SE HACE CLICK SE LIMPIA LA GRILLA
            calcularV(); //INICIA METODO
        }
        private void calcularV()  //METODO PARA CALCULAR CUOTA VARIABLE
        {
            try
            {
                decimal monto = 
                    Convert.ToDecimal(this.textMonto.Text);
                decimal tasainteres = 
                    Convert.ToDecimal(this.textInteres.Text);
                int plazos = 
                    Convert.ToInt16(this.textPlazos.Text);

                tasainteres = tasainteres / 100;

                decimal intereses = 0,
                    valorCuota = 0,
                    saldoFinal = 0,
                    sumaCuotas = 0,
                    saldoInicial = monto;

                if (monto != 0 && plazos != 0)
                {

                    //FORMUA DE CUOTA VARIABLE

                    decimal abonoCap = Math.Round(monto / plazos, 2);

                    saldoFinal = saldoInicial;


                    for (int I = 1; I <= plazos; I++)
                    {
                        var saldoFinalAnterior = 
                            Math.Round(saldoFinal, 2); //SE GUARDA VARIABLE ANTERIOR
                        intereses =
                            Math.Round(saldoFinal * (tasainteres), 2);
                        valorCuota =
                            Math.Round(abonoCap + intereses, 2);
                        saldoFinal = 
                            Math.Round(saldoFinal - abonoCap, 2);

                        if (saldoFinal < 0.5m)
                        {
                            saldoFinal = 0;
                        }

                        dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), valorCuota, intereses, abonoCap, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                        sumaCuotas = 
                            Math.Round(sumaCuotas + valorCuota, 2); //ACUMULA LAS CUOTAS
                    }

                    this.lblResultado.Text = 
                        "$ " + sumaCuotas.ToString(); //MUESTRA SUMA EN EL LABEL
                }
            }
            catch (Exception ex) //bloque catch para captura de error
            {
                string error = 
                    ex.Message; //acción para manejar el error
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        //private static T TrySetValue<T>(object value)
        //{

        //    T result = value is null
        //               ? (T)Convert.ChangeType("", typeof(T))
        //               : (T)Convert.ChangeType(value, typeof(T));

        //    return result;
        //}

    }
}

    
