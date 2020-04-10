using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PracticeApp.ViewModel
{
    class RESTViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _response = string.Empty;
        public string Response
        {
            get
            {
                return _response;
            }
            set
            {
                if (value != _response)
                {
                    _response = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public ICommand ConnectCommand => new Command(ConnectToRESTAPI);   

        private void ConnectToRESTAPI()
        {
            _response = App.RestAPIManager.GetTaskAsync().Result;
        }
    }
}
