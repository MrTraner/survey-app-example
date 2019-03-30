using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel; //Para usar ObservableCollection
using PrimeraAplicacion.Models; //Para usar la clase Survey
using System.Windows.Input; //Para usar ICommand
using Xamarin.Forms; //Para usar Command

namespace PrimeraAplicacion.ViewModels
{
    public class MainPageViewModel : NotificationObject
    {
        private ObservableCollection<Survey> surveys;

        public ObservableCollection<Survey> Surveys
        {
            get { return surveys; }
            set { surveys = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }

        public MainPageViewModel()
        {
            Surveys = new ObservableCollection<Survey>();

            AddCommand = new Command(AddCommandExecute);

            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
            {
                Surveys.Add(s);
            });
        }

        private void AddCommandExecute()
        {
            MessagingCenter.Send(this, "AddSurvey");
        }
    }
}
