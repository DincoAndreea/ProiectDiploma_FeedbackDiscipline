using FeedbackDiscipline.Modele;
using FeedbackDiscipline.ServiciiAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FeedbackDiscipline.Pagini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conectare : ContentPage
    {
        IAdministrareServicii administrareServicii = new AdministrareServicii();
        public Conectare()
        {
            InitializeComponent();
        }

        private async void ConectareUtilizator(object sender, EventArgs e)
        {
            var email = campEmail.Text;
            var parola = campParola.Text;

            Logare logare = new Logare { email = email, parola = parola };

            var autentificare = await administrareServicii.Logare(logare);

            if (autentificare.id_utilizator == null)
            {
                await DisplayAlert("", "Parola sau numele de utilizator nu sunt corecte.", "Ok");
            }
            else
            {
                await Xamarin.Essentials.SecureStorage.SetAsync("token", autentificare.token);

                await Xamarin.Essentials.SecureStorage.SetAsync("tokenReimprospatare", autentificare.token_reimprospatare);

                await Xamarin.Essentials.SecureStorage.SetAsync("idUtilizator", autentificare.id_utilizator);

                if (autentificare.rol == "student")
                {
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new EvaluareDiscipline());
                }

                if (autentificare.rol == "profesor")
                {
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new RaportEvaluari());
                }

                if (autentificare.rol == "administrator")
                {
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Administrare());
                }
            }

            
        }
    }
}