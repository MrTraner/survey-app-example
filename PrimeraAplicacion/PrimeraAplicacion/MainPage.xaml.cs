using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using PrimeraAplicacion.ViewModels; //Para usar la clase MainPageViewModel

namespace PrimeraAplicacion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            MessagingCenter.Subscribe<MainPageViewModel>(this, "AddSurvey", async (a) =>
            {
                await Navigation.PushModalAsync(new SurveyDetailsView());
            });
		}
	}
}
