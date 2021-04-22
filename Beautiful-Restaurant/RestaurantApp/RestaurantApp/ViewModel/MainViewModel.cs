using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        public ICommand ListQ => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new MorningPage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Sườn mật ong", Image = "IMG03.png",
                    Description = "Sườn nướng ngon full size" },
                new Pick { Title = "Nấm xào Caribe", Image = "IMG01.png",
                    Description = "Sườn nướng ngon full size" },
                new Pick { Title = "Sườn nướng bự", Image = "IMG07.png",
                    Description = "Sườn nướng ngon full size" }
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}
