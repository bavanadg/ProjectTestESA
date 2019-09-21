using ESA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Go2_MP_Roeche (object sender, EventArgs e)
        {
            // await NavigationPage(new Page_Rodrigo());
            // NavigationPage(Page_Rodrigo);
            await Navigation.PushAsync(new Page_Rodrigo());
        }
    }
}
