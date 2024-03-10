using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using SQLNET.Data.Models;
using SQLNET.Views;
using static System.Reflection.Metadata.BlobBuilder;

namespace SQLNET.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {

        private RelayCommand loginNavigate;
        public RelayCommand LoginNavigate
        {
            set
            {
                RegisterWindow registerWindow = new RegisterWindow();

                // Показываем новое окно
                registerWindow.Show();

                // Закрываем текущее окно
                App.Current.MainWindow.Close();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
