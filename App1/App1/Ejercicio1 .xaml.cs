using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio1 : TabbedPage
    {
        public Ejercicio1()
        {
            InitializeComponent();

        }
        

        async void Paso1(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 1", "Piensa en el dia de tu cumpleanios. Ahora multiplicalo por veinte (x20)", "'Lo tengo'");
        }
 
        async void Paso2(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 2", "Genial! Ahora sumale setente y tres al resuldato (+73)", "'Lo tengo'");
        }
        async void Paso3(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 3", "Al resultado multiplicalo por cinco (x5) ", "'Lo tengo'");
        }
        async void Paso4(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 4", "Muy bien :)! Por ultimo sumale la fecha del mes de tu cumpleanios", "'Finish!'");
        }
        private void Calcular(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Resultado.Text))
            {
                int resultado, dia, fecha, X;
                var Z = int.Parse(Resultado.Text);
                string Total = "", namemes ="";
                X = (Z - 365); 
                resultado = X;
                dia = resultado / 100;
                fecha = resultado % 100;
                switch (fecha)
                {
                    case 01:
                        {
                            if(fecha == 01)
                            {
                                namemes = "Enero";
                            }
                            break;
                        }
                    case 02:
                        {
                            if (fecha == 02)
                            {
                                namemes = "Febrero";
                            }
                            break;
                        }
                    case 03:
                        {
                            if (fecha == 03)
                            {
                                namemes = "Marzo";
                            }
                            break;
                        }
                    case 04:
                        {
                            if (fecha == 04)
                            {
                                namemes = "Abril";
                            }
                            break;
                        }
                    case 05:
                        {
                            if (fecha == 05)
                            {
                                namemes = "Mayo";
                            }
                            break;
                        }
                    case 06:
                        {
                            if (fecha == 06)
                            {
                                namemes = "Junio";
                            }
                            break;
                        }
                    case 07:
                        {
                            if (fecha == 07)
                            {
                                namemes = "Julio";
                            }
                            break;
                        }
                    case 08:
                        {
                            if (fecha == 08)
                            {
                                namemes = "Agosto";
                            }
                            break;
                        }
                    case 09:
                        {
                            if (fecha == 09)
                            {
                                namemes = "Septiembre";
                            }
                            break;
                        }
                    case 10:
                        {
                            if (fecha == 10)
                            {
                                namemes = "Octubre";
                            }
                            break;
                        }
                    case 11:
                        {
                            if (fecha == 11)
                            {
                                namemes = "Noviembre";
                            }
                            break;
                        }
                    case 12:
                        {
                            if (fecha == 12)
                            {
                                namemes = "Diciembre";
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
                Total = "Usted nacio el dia " + dia + " y  el  mes " + fecha +"(" + namemes + ")";

                DisplayAlert("La Respueta es:",
                    Total,
                    "GENIAL! ^o^");
            }
            else
            {
                DisplayAlert("datos erroneos",
                    "Llene todos los campos",
                    "ok");
            }
        }
        async void nePaso1(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 1", "Piensa en un numero y multiplicalo por 2 (x2)", "'Lo tengo'");
        }
        async void nePaso2(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 2", "Genial! Ahora sumale 8 al resultado (+8)", "'Lo tengo'");
        }
        async void nePaso3(object sender, EventArgs e)
        {
            await DisplayAlert("Paso 3", "Por ultimo multiplicalo por cinco (x5)", "'GOOO!!'");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(neResultado.Text))
            {
                var z = int.Parse(neResultado.Text);
                int  x, resultado;
                x = z / 10;
                resultado = x - 4;
                string Total = "";
                Total = "El numero que estabas pensado es : " + resultado;
                DisplayAlert("Resultado", Total, "GOO");

            }
            else
            {
                DisplayAlert("datos erroneos",
                   "Llene todos los campos",
                   "ok");
            }
        }

       
    }
}


  