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
    public partial class Lacrimal : ContentPage
    {
        LacrimalViewModel _viewModel = new LacrimalViewModel();
        public Lacrimal()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }
    }
}