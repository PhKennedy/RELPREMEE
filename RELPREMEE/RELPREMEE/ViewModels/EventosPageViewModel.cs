using RELPREMEE.Models;
using RELPREMEE.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RELPREMEE.ViewModels
{
    public class EventosPageViewModel : BaseViewModel
    {
        public ObservableCollection<Event> Eventos { get; }
        public DataService DataService { get; }

        public EventosPageViewModel()
        {
            DataService = new DataService();
            GetEventos();
        }

        public async void GetEventos()
        {
            List<Event> events;
            try
            {
                events = await DataService.GetAllEventsAsync();
                foreach (var e in events)
                {
                    Eventos.Add(e);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
