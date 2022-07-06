using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablaAmortizacion.Model;

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
                decimal aval =
                    Convert.ToDecimal(this.textAval.Text);

                NumModel modelo = new NumModel();
                modelo.Monto = monto;
                modelo.Tasa = tasainteres;
                modelo.Plazos = plazos; 
                modelo.Aval = aval;

                tasainteres = tasainteres / 100;
                aval = Math.Round((monto * (aval / 100)) /plazos, 2);


                decimal intereses = 0,
                    abonoCap = 0,
                    saldoFinal = 0,
                    cuotaFinal = 0,
                    sumaCuotas = 0;
                decimal saldoInicial = monto;

                if (monto != 0 && plazos != 0 && tasainteres != 0)
                {

                    //FORMUA DE CUOTA FIJA

                    saldoFinal = saldoInicial;

                    decimal resultado = 
                        ((1 - (decimal)Math.Pow(1 + (double)tasainteres, plazos * -1)) / tasainteres);
                    decimal valorCuota =
                        Math.Round((monto / resultado), 2);



                    for (int I = 1; I <= plazos; I++)
                    {
                        var saldoFinalAnterior = 
                            Math.Round(saldoFinal, 2); //SE GUARDA VARIABLE ANTERIOR
                        intereses = 
                            Math.Round(saldoFinal * tasainteres, 2);
                        cuotaFinal =
                             Math.Round(valorCuota + aval, 2);
                        abonoCap = 
                            Math.Round(valorCuota - intereses, 2);
                        saldoFinal = 
                            Math.Round(saldoFinal- abonoCap, 2);
                        
                        if (saldoFinal < 0.5m )
                        {
                            saldoFinal = 0;
                        }

                        dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), cuotaFinal, intereses, abonoCap, aval, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                        sumaCuotas =
                            Math.Round(sumaCuotas + cuotaFinal, 2); //ACUMULA EL VALOR DE LAS CUOTAS
                    }

                    this.lblResultado.Text =
                        "$ " + sumaCuotas.ToString(); //MUESTRA SUMA DE CUOTAS EN EL LABEL
                }
                else
                {
                    MessageBox.Show("Asegurese de ingresar un valor en todos los campos solicitados en Datos del Crédito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) //bloque catch para captura de error
            {
                //acción para manejar el error
                MessageBox.Show(ex.Message);    
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
                decimal aval =
                    Convert.ToDecimal(this.textAval.Text);

                tasainteres = tasainteres / 100;
                aval = Math.Round((monto * (aval / 100)) / plazos, 2);

                decimal intereses = 0,
                    valorCuota = 0,
                    saldoFinal = 0,
                    cuotaFinal = 0,
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
                            Math.Round(saldoFinal * tasainteres, 2);
                        valorCuota =
                            Math.Round(abonoCap + intereses, 2);
                        cuotaFinal =
                             Math.Round(valorCuota + aval, 2);
                        saldoFinal = 
                            Math.Round(saldoFinal - abonoCap, 2);

                        if (saldoFinal < 0.5m)
                        {
                            saldoFinal = 0;
                        }
                        
                        dataGridView1.Rows.Add(I, saldoFinalAnterior.ToString(), cuotaFinal, intereses, abonoCap, aval, saldoFinal); //MOSTRAR VALORES EN LA GRILLA

                        sumaCuotas = 
                            Math.Round(sumaCuotas + cuotaFinal, 2); //ACUMULA EL VALOR DE LAS CUOTAS
                    }

                    this.lblResultado.Text = 
                        "$ " + sumaCuotas.ToString(); //MUESTRA SUMA DE CUOTAS EN EL LABEL
                }
                else
                {
                    MessageBox.Show("Asegurese de ingresar un valor en todos los campos solicitados en Datos del Crédito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) //bloque catch para captura de error
            {
                MessageBox.Show(ex.Message); //acción para manejar el error
            }
        }

        //MENU
        //REGISTRAR
        private void tslRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarIdentificacion() == false)
            {
                return;
            }
            if (ValidarFechaNacimiento() == false)
            {
                return;
            }



        }

        //VALIDACIONES
        //-Validación de Identificación para que salga o no error provider
        private bool ValidarFechaNacimiento()
        {
            int days = DateTime.Now.Date.Subtract(dtpFecha.Value.Date).Days;
            int years= days / 365;

            if (years < 18)
            {
                erpError.SetError(dtpFecha, "Debe ser mayor de edad");
                return false;
            }
            else
            {
                erpError.SetError(dtpFecha, ""); 
                return true;
            }
        }

        //-Validación de Identificación para que salga o no error provider
        private bool ValidarIdentificacion()
        {
            int NumIdentificacion;

            if (!int.TryParse(textIdentificacion.Text, out NumIdentificacion) || string.IsNullOrEmpty(textIdentificacion.Text) || textIdentificacion.Text.StartsWith(" "))
            {
                
                erpError.SetError(textIdentificacion, "Debe ingresar un número de identificación");

                textIdentificacion.Clear(); //Limpia cuadro de texto
                textIdentificacion.Focus(); //Enfoca el cuadro de texto

                return false;
            }
            else
            {
                erpError.SetError(textIdentificacion, "");
                return true;
            }
        }

        //-Validacion de nombre para que salga o no error provider
        private bool ValidarNombre()
        {

            if (string.IsNullOrEmpty(textNombre.Text) || textNombre.Text.StartsWith(" ")) 
            {
                erpError.SetError(textNombre, "Debe ingresar un nombre");
                return false;
            }
          
            else
            {
                erpError.SetError(textNombre, "");
                return true;
            }
        }
    }
}


