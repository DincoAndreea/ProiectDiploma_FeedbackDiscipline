using FeedbackDiscipline.Modele;
using FeedbackDiscipline.ServiciiAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FeedbackDiscipline.Pagini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Administrare : ContentPage
    {
        List<string> roluriUtilizator = new List<string> { "student", "profesor" };
        IAdministrareServicii administrareServicii = new AdministrareServicii();
        public Administrare()
        {
            InitializeComponent();
            preiaUtillizatori();
            rolUtilizatorInregistrare.ItemsSource = roluriUtilizator;
        }

        private async void Deconectare(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new Conectare());         
        }

        private async void preiaUtillizatori()
        {
            ListaUtilizatori.ItemsSource = await administrareServicii.Utilizatori(await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
        }

        private async void inregistrareUtilizator(object sender, EventArgs e)
        {
            string nume_utilizator = numeUtilizatorInregistrare.Text != null ? numeUtilizatorInregistrare.Text : "";
            string email = emailUtilizatorInregistrare.Text != null ? emailUtilizatorInregistrare.Text : "";
            string parola = parolaUtilizatorInregistrare.Text != null ? parolaUtilizatorInregistrare.Text : "";
            string rol = rolUtilizatorInregistrare.SelectedItem as string != null ? rolUtilizatorInregistrare.SelectedItem as string : "";

            if (nume_utilizator != "" && validareNumeUtilizator(nume_utilizator) && email != "" && validareEmail(email) && parola != "" && validareParola(parola) && rol != "")
            {
                var inregistrare_utilizator = new Inregistrare { nume_utilizator = nume_utilizator, email = email, parola = parola, rol = rol };

                var inregistrare = await administrareServicii.Inregistrare(inregistrare_utilizator, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));

                if (inregistrare == System.Net.HttpStatusCode.OK)
                {
                    await DisplayAlert("", "Utilizatorul a fost înregistrat cu succes.", "Ok");
                }
                else
                {
                    await DisplayAlert("", "Utilizatorul nu a fost înregistrat.", "Ok");
                }
            }
            else
            {
                StringBuilder mesaj = new StringBuilder();

                if(!validareNumeUtilizator(nume_utilizator))
                {
                    mesaj.Append("Numele utilizatorului este invalid. Numele trebuie să conțină doar litere mici și cifre la finalul numelui iar numele de familie este separat de prenume printr-un punct. (Exemple nume utilizator valide: ana.popescu, ana.popescu5)\n\n");
                }

                if(!validareParola(parola))
                {
                    mesaj.Append("Parola nu este validă. Parola trebuie să înceapă cu o literă mare și trebuie să conțină cel puțin o cifră. (Exemple parole valide: Student220456, Parola123) \n\n");
                }

                if(!validareEmail(email))
                {
                    mesaj.Append("Email-ul este invalid. Introdu o adresă de email validă. \n\n");
                }

                if(rol == "")
                {
                    mesaj.Append("Alege rolul utilizatorului. \n");
                }

                await DisplayAlert("", mesaj.ToString(), "Ok");
            }
            
        }

        private bool validareNumeUtilizator(string nume_utilizator)
        {
            string tipar = "^[a-z]*[.][a-z]*[0-9]*$";
            Regex reg = new Regex(tipar);

            return reg.IsMatch(nume_utilizator);
        }

        private bool validareEmail(string email)
        {
            string tipar = "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[;]{0,1}\\s*)+$";
            Regex reg = new Regex(tipar);

            return reg.IsMatch(email);
        }

        private bool validareParola(string parola)
        {
            string tipar = "^[A-Z][a-zA-Z]*[0-9]*$";
            Regex reg = new Regex(tipar);

            return reg.IsMatch(parola);
        }

        private void reimprospatareListaUtilizatori(object sender, EventArgs e)
        {
            preiaUtillizatori();
            ListaUtilizatori.SelectedItems.Clear();
        }

        private async void stergeUtilizatori(object sender, EventArgs e)
        {
            var nume_utilizatori = ListaUtilizatori.SelectedItems.Cast<Utilizatori>().ToList();

            if(nume_utilizatori.Count > 0)
            {
                for (int i = 0; i < nume_utilizatori.Count; i++)
                {
                    Utilizatori utilizator = new Utilizatori { nume_utilizator = nume_utilizatori[i].nume_utilizator };

                    var stergere = await administrareServicii.StergeUtilizator(utilizator, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));

                    List<string> utilizatori_stersi = new List<string>();

                    List<string> utilizatori_nestersi = new List<string>();

                    StringBuilder mesaj = new StringBuilder();

                    if (stergere == System.Net.HttpStatusCode.OK)
                    {
                        utilizatori_stersi.Add(nume_utilizatori[i].nume_utilizator);
                    }
                    else
                    {
                        utilizatori_nestersi.Add(nume_utilizatori[i].nume_utilizator);
                    }

                    if(utilizatori_stersi.Count > 1)
                    {
                        mesaj.Append("Utilizatorii " + string.Join(", ", utilizatori_stersi) + " au fost șterși cu succes.\n");
                    }

                    if(utilizatori_stersi.Count == 1)
                    {
                        mesaj.Append("Utilizatorul " + string.Join(", ", utilizatori_stersi) + " a fost șters cu succes.\n");
                    }
                    
                    if (utilizatori_nestersi.Count > 1)
                    {
                        mesaj.Append("Următorii utilizatori nu s-au putut șterge: " + string.Join(", ", utilizatori_nestersi) + ".");
                    }

                    if (utilizatori_nestersi.Count == 1)
                    {
                        mesaj.Append("Utilizatorul " + string.Join(", ", utilizatori_nestersi) + " nu s-a putut șterge.");
                    }


                    await DisplayAlert("", mesaj.ToString(), "Ok");
                }
            }

            ListaUtilizatori.SelectedItems.Clear();
        }
    }
}