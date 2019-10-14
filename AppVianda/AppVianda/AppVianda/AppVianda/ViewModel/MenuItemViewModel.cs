using AppVianda.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppVianda.ViewModel
{
    public class MenuItemViewModel
    {
        #region Properties
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }
        #endregion

        #region Commmands
        public ICommand NavigateCommand
        {
            get
            {
                return new Command(Navigate);
            }
        }

        private void Navigate(object obj)
        {
            if (this.PageName == "LoginPage")
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
        #endregion
    }
}
