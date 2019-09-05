using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for PlayerView.xaml
    /// </summary>
    public partial class PlayerView : Window
    {
        PlayerViewModel ViewModel;
        public PlayerView()
        {
            // det här verkar dumt.... gör någon annanstans
            Person person = new Person() { firstname = "Yasmine" };
            ViewModel = new PlayerViewModel(person);
            this.DataContext = ViewModel;
            InitializeComponent();
        }

        public PlayerView(Person person)
        {

            //Tips. Kanske en DTO kan vara något man vill söka efter...
            // DTO namn;
            
            InitializeComponent();
        }
    }
}
