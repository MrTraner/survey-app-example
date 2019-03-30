using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input; //Para usar ICommand
using Xamarin.Forms; //Para usar Command
using PrimeraAplicacion.Models; //Para usar la clase Survey

namespace PrimeraAplicacion.ViewModels
{
    public class SurveyDetailsViewModel : NotificationObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string favoriteFood;

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { set; get; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() =>
            {
                var newSurvey = new Survey() { Name = this.Name, FavoriteFood = this.FavoriteFood };
                MessagingCenter.Send(this, "SaveSurvey", newSurvey);
            });
        }
    }
}
