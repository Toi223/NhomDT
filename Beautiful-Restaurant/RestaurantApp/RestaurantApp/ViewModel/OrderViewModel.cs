using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
               new Pick { Title = "Xa lách cá hồi", Image = "IMG02.png", Description = "Cá hồi được áp chảo", Price = "350.000 vnđ" }
            };
        }
    }
}
