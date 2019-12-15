using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.SecureStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace RELPREMEE.ViewModels
{
    class LocalizacoesPageViewModel : BaseViewModel
    {
        public Command IFPACommand { get; }

        public LocalizacoesPageViewModel()
        {
            IFPACommand = new Command(IFPACommandExecute);
        }

        private async void IFPACommandExecute(object obj)
        {
            CrossSecureStorage.Current.SetValue("LocalSelecionado", "IFPA - Campus Belém");
            await NavigationService.NavigateToMapaPage();
        }
    }
}