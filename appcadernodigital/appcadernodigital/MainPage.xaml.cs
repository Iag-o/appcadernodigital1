using appcadernodigital.Primeiro;
using appcadernodigital.Segundo;
using appcadernodigital.Terceiro;
using System;
using appcadernodigital;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appcadernodigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            NavigationPage.SetHasNavigationBar(this, false);
        }

 
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DisciplinasPrimeiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiciplinaSegundo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
           Navigation.PushAsync(new DisciplinaTerceiro());
        }
    }
}
