using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PrimeraAplicacion.ViewModels; //Para usar la clase SurveyDetailsViewModel
using PrimeraAplicacion.Models; //Para usar la clase Survey

namespace PrimeraAplicacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveyDetailsView : ContentPage
	{
		public SurveyDetailsView ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", async (a, s) =>
            {
                await Navigation.PopModalAsync();
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey");
        }
    }
}