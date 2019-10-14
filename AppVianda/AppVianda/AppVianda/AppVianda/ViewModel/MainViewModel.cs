using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppVianda.ViewModel
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menus { get; set; }
        #endregion

        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }

        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_perfil",
                PageName = "PerfilPage",
                Title = "Mi Perfil"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_compra",
                PageName = "VentasPage",
                Title = "Ventas"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_stadisticas",
                PageName = "EstadisticaPage",
                Title = "Estadísticas"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_ajuste",
                PageName = "AjustesPage",
                Title = "Ajustes"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit",
                PageName = "LoginPage",
                Title = "Cerrar sesión"
            });
        }
        #endregion
    }
}
