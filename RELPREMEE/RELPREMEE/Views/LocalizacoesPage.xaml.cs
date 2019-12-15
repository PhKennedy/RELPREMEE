using RELPREMEE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RELPREMEE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalizacoesPage : ContentPage
    {
        public LocalizacoesPage()
        {
            InitializeComponent();
            BindingContext = new LocalizacoesPageViewModel();
        }
    }
}