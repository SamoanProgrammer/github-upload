using PracticeApp.WebCalls;
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

        public RESTViewModel()
        {
            MessagingCenter.Subscribe<RestService, string>(
            this, Helper.MessengerKeys.RESTResponse, (sender, arg) =>
            {
                Response = arg;
            });
        }
        public ICommand ConnectCommand => new Command(ConnectToRESTAPI);   

        private async void ConnectToRESTAPI()
        {
            await App.RestAPIManager.GetTaskAsync();
        }
    }
}
