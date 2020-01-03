using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RELPREMEE.Services
{
     public interface INavigationService
    {
        Task NavigateToLocalizacoesPage();
        Task NavigateToMapaPage();
        Task NavigateToEventosPage();

    }
}
