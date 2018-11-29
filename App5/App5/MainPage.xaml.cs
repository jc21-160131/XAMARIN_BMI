using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonClickEvent;
            ButtonBMI2.Clicked += ButtonClickEvent2;
        }

        private void ButtonClickEvent2(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);
            if (height > 3)
            {
                height = height / 100;
            }
            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height,weight)));
        }

        private void ButtonClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);
            if (height > 3)
            {
                height = height / 100;
            }
            LabelResult.Text = "BMI=" + (weight / (height * height));
        }
    }
}
