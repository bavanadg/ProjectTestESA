using ESA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Rodrigo : ContentPage
    {
        public Page_Rodrigo()
        {
            InitializeComponent();
            BindingContext = new REC01ViewModel();
            // REC: The above st. sets the binding context
            // of the entire MainPage. This is what finally
            // makes the binding to happen.
        }
    }
}