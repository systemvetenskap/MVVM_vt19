using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;

namespace WpfApp1.ViewModels
{
    class PlayerViewModel : INotifyPropertyChanged
    {
        public bool IsSaveEnabled { get; set; } = false;
        private string firstname;
        private RelayCommand saveCommand;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                IsSaveEnabled = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Firstname"));
            }
        }

        public PlayerViewModel()
        {

        }
        public PlayerViewModel(Person person)
        {
            this.Firstname = person.firstname;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        #region Commands
        public RelayCommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    //saveCommand = new RelayCommand(p => { UpdatePlayer(); });
                    saveCommand = new RelayCommand(p => { UpdatePlayer(); },p => IsChanged());
                }
                return saveCommand;
            }
            set
            {
                saveCommand = value;
            }
        }
        #endregion

        #region Methods
        private bool IsChanged()
        {
            return false;
        }

        private void UpdatePlayer()
        {
            // kod som sparar mot databasen
            string first = Firstname;
        }
        #endregion
    }
}
