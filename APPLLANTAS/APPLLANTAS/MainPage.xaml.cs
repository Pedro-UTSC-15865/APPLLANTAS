using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APPLLANTAS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var llantas = double.Parse(LLANTAS.Text);

            double total = 0;
            string promocion = "";

            if(llantas>=1 && llantas <= 4)
            {
                total = llantas*350;
                promocion = "Se aplico la PROMO 1";
            }else if (llantas >= 5 && llantas <= 10)
            {
                total = llantas * 300;
                promocion = "Se aplico la PROMO 2";
            }else if (llantas > 10)
            {
                total = llantas * 250;
                promocion = "Se aplico la PROMO 3";
            }
            else
            {
                total = 0;
                promocion = "NO aplico la PROMO";
            }

            TOTAL.Text = total.ToString();
            DisplayAlert("AVISO", promocion, "Ok");

        }
    }
}
