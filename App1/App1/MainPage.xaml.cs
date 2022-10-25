using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void Button_Clicked(object sender, System.EventArgs e)
        {
            if (txtGasolina.Text != null && txtAlcool.Text != null)
            {
                double vlGasolina = Convert.ToDouble(txtGasolina.Text);
                double vlAlcool = Convert.ToDouble(txtAlcool.Text);

                var calculo = vlAlcool / vlGasolina;

                if (calculo <= 0.7)
                {
                    lblMessage.Text = "É mais vantajoso abastecer no etanol";
                }
                else
                {
                    lblMessage.Text = "É mais vantajoso abastecer na gasolina";
                }

                lblMessage.TextColor = Color.Black;
            } else
            {
                lblMessage.Text = "É necessário preencher os todos os campos.";
                lblMessage.TextColor = Color.Red;
            }
            
        }
    }
}
