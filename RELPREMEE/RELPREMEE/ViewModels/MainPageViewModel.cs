using Xamarin.Forms;

namespace RELPREMEE.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {        
        public Command EventosCommand { get; }
        public Command LocalizacoesCommand { get; }
        public Command SobreCommand { get; }

        public MainPageViewModel()
        {
            EventosCommand = new Command(EventosExecute);
            LocalizacoesCommand = new Command(LocalizacoesExecute);
            SobreCommand = new Command(SobreExecute);
        }

        private void SobreExecute(object obj)
        {
            //Navegar para pagina de about do projeto
        }
        private async void LocalizacoesExecute(object obj)
        {
           await NavigationService.NavigateToLocalizacoesPage();
        }
        private async void EventosExecute(object obj)
        {
            await NavigationService.NavigateToEventosPage();
        }
    }
}
