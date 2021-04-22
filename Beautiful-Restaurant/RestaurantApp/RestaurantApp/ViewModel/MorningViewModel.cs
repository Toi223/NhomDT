using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class MorningViewModel :BaseViewModel
    {
        public MorningViewModel()
        {
            MenuList = GetMenu();
        }
        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        public List<Pick> MenuList { get; set; }
        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Bún đậu mắm tôm", Image = "IMG10.jpg", Description = "Nguyên liệu rõ ràng, phần ăn 2 người", Price = "250.000 vnđ" },
                new Pick { Title = "Phở bò", Image = "IMG9.jpg", Description = "Món ăn đặc đậm bản sắc Việt Nam", Price = "75.000 vnđ" },
                new Pick { Title = "Cơm sườn", Image = "IMG07.jpg", Description = "Miếng sườn được nướng mật ong", Price = "55.000 vnđ" },
               new Pick { Title = "Cơm cà ri gà", Image = "IMG05.png", Description = "thịt được lấy từ gà thả vườn.", Price = "150.000 vnđ" },
               new Pick { Title = "Cơm sườn bì", Image = "IMG03.png", Description = "Sườn tuyển từ những con heo ngon", Price = "75.000 vnđ" },
               new Pick { Title = "Gỏi cá hồi", Image = "IMG04.png", Description = "Rau được dùm trong tự nhiên thân thiện với môi trường", Price = "100.000 vnđ" },
               new Pick { Title = "Nấm xào Caribe", Image = "IMG01.png", Description = "Được nấu theo hương vị của vùng đất Caribe", Price = "15.000 vnđ" }
            };
        }
    }
}
