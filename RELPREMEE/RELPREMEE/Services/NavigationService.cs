using RELPREMEE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RELPREMEE.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToLocalizacoesPage()
        {
            if (App.Current.MainPage.Navigation.NavigationStack.Count == 0 ||
                   App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != typeof(LocalizacoesPage))
            {
                await App.Current.MainPage.Navigation.PushAsync(new LocalizacoesPage());
            }
        }
        public async Task NavigateToMapaPage()
        {
            if (App.Current.MainPage.Navigation.NavigationStack.Count == 0 ||
                   App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != typeof(MapaPage))
            {
                await App.Current.MainPage.Navigation.PushAsync(new MapaPage());
            }
        }
        public async Task NavigateToEventosPage()
        {
            if (App.Current.MainPage.Navigation.NavigationStack.Count == 0 ||
                   App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != typeof(EventosPage))
            {
                await App.Current.MainPage.Navigation.PushAsync(new EventosPage());
            }
        }
    }
}
