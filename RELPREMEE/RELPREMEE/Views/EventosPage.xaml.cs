using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RELPREMEE.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RELPREMEE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventosPage : ContentPage
    {
        public EventosPage()
        {
            InitializeComponent();
            BindingContext = new EventosPageViewModel();
        }
    }
}