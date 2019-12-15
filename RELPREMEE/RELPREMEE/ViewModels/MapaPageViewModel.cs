using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.SecureStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;

namespace RELPREMEE.ViewModels
{
    public class MapaPageViewModel : BaseViewModel
    {
        private Map _mapa;
        private Pin _pin;
        private string _localidadeNome;

        public Map Mapa
        {
            get
            {
                return _mapa;
            }
            set
            {
                SetProperty(ref _mapa, value);
            }
        }
        public Pin Pin
        {
            get
            {
                return _pin;
            }
            set
            {
                SetProperty(ref _pin, value);
            }
        }
        public PermissionStatus GpsPermission
        {
            get;
            set;
        }
        public string LocalidadeNome
        {
            get
            {
                return _localidadeNome;
            }
            set
            {
                SetProperty(ref _localidadeNome, value);
            }
        }

        public MapaPageViewModel()
        {
            LocalidadeNome = CrossSecureStorage.Current.GetValue("LocalSelecionado");
            GerarPins();
            InicializarMapa();
        }

        async void InicializarMapa()
        {
            await GarantirPermissoes();
            Mapa = new Map();
            if (GpsPermission == PermissionStatus.Granted)
            {
                Mapa.MyLocationEnabled = true;
                Mapa.UiSettings.MyLocationButtonEnabled = true;
            }

            Mapa.Pins.Add(Pin);
            Mapa.SelectedPin = _pin;
            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(_pin.Position, Distance.FromMeters(5000)), true);
        }
        async Task GarantirPermissoes()
        {
            GpsPermission = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
            if (GpsPermission != PermissionStatus.Granted)
            {
                var result = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);

                if (result.ContainsKey(Permission.Location))
                    GpsPermission = result[Permission.Location];
            }

        }
        void GerarPins()
        {
            if(CrossSecureStorage.Current.GetValue("LocalSelecionado") == "IFPA - Campus Belém")
            Pin = new Pin()
            {
                Type = PinType.Place,
                Label = LocalidadeNome,
                Address = "Av. Alm. Barroso, 1155 - Marco, Belém - PA",
                Position = new Position(-1.437990, -48.460587),
                IsDraggable = false
            };

        }
    }
}
