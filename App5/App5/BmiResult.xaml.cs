using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{
        private float height,weight;

        public BmiResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
        }

        public BmiResult(float height,float weight)
        {
            InitializeComponent();
            this.height = height;
            this.weight = weight;
            labelBMI.Text = "BMI=" + (weight / (height * height));
            buttonBack.Clicked += buttonBackClicked;
        }

        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}