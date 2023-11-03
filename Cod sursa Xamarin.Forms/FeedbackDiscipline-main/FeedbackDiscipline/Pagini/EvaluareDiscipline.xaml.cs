using FeedbackDiscipline.Modele;
using FeedbackDiscipline.ServiciiAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FeedbackDiscipline.Pagini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvaluareDiscipline : ContentPage
    {
        private List<TipuriActivitati> tipactivitati { get; set; }
        IEvaluareDisciplineServicii evaluareDisciplineServicii = new EvaluareDisciplineServicii();
        public EvaluareDiscipline()
        {
            InitializeComponent();
            preiaCicluriStudii();
            preiaTipuriActivitati();
            Intrebare2.IsVisible = false;
            grilaIntrebare2.IsVisible = false;
            Intrebare3.IsVisible = false;
            grilaIntrebare3.IsVisible = false;
            Intrebare4.IsVisible = false;
            grilaIntrebare4.IsVisible = false;
            Intrebare9.IsVisible = false;
            grilaIntrebare9.IsVisible = false;
            Intrebare12.IsVisible = false;
            grilaIntrebare12.IsVisible = false;
            Intrebare13.IsVisible = false;
            grilaIntrebare13.IsVisible = false;
            Intrebare14.IsVisible = false;
            grilaIntrebare14.IsVisible = false;
        }

        private async void preiaCicluriStudii()
        {
            CicluriStudiu.ItemsSource = await evaluareDisciplineServicii.preiaCicluriStudii(await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
            CicluriStudiu.ItemDisplayBinding = new Binding("nume_ciclu_de_studii");
        }

        private async void preiaTipuriActivitati()
        {
            tipactivitati = await evaluareDisciplineServicii.preiaTipuriActivitati(await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
        }

        private void DisciplineSelectare(object sender, EventArgs e)
        {
            TipActivitate.ItemsSource = tipactivitati;
            TipActivitate.ItemDisplayBinding = new Binding("nume_activitate");
            ListaActivitati.ItemsSource = null;
            ListaActivitati.SelectedItems = null;
        }

        private void TipuriActivitatiSelectare(object sender, EventArgs e)
        {
            TipuriActivitati tip = (TipuriActivitati)TipActivitate.SelectedItem;
            Disciplina dis = (Disciplina)Disciplina.SelectedItem;
            ListaActivitati.SelectedItems = null;

            if (tip != null && dis != null)
            {
                if (tip.nume_activitate == "Seminar")
                {
                    var numberList = Enumerable.Range(1, dis.nr_seminare).ToList();
                    ListaActivitati.ItemsSource = numberList;
                }
                if (tip.nume_activitate == "Curs")
                {
                    var numberList = Enumerable.Range(1, dis.nr_cursuri).ToList();
                    ListaActivitati.ItemsSource = numberList;
                }
                if (tip.nume_activitate == "Laborator")
                {
                    var numberList = Enumerable.Range(1, dis.nr_laboratoare).ToList();
                    ListaActivitati.ItemsSource = numberList;
                }
                if (tip.nume_activitate == "Proiect")
                {
                    var numberList = Enumerable.Range(1, dis.nr_intalniri_proiect).ToList();
                    ListaActivitati.ItemsSource = numberList;
                }
            }
        }

        private async void CicluriStudiuSelectare(object sender, EventArgs e)
        {
            Picker pick = sender as Picker;
            CiclulDeStudii ciclu = pick.SelectedItem as CiclulDeStudii;
            AniStudiu.ItemsSource = await evaluareDisciplineServicii.preiaAniStudiuDupaCiclulDeStudii(ciclu.id_ciclu_de_studii, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
            AniStudiu.ItemDisplayBinding = new Binding("anul_de_studiu");
            ProgrameDeStudiu.ItemsSource = await evaluareDisciplineServicii.preiaProgrameStudiiDupaCiclulDeStudii(ciclu.id_ciclu_de_studii, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
            ProgrameDeStudiu.ItemDisplayBinding = new Binding("nume_programe_de_studiu");
            Disciplina.ItemsSource = null;
            TipActivitate.ItemsSource = null;
            ListaActivitati.ItemsSource = null;
            ListaActivitati.SelectedItems = null;
        }

        private async void ProgrameDeStudiuSelectare(object sender, EventArgs e)
        {
            Picker pick = sender as Picker;
            ProgrameStudiu program = pick.SelectedItem as ProgrameStudiu;
            if (program != null)
            {
                Disciplina.ItemsSource = await evaluareDisciplineServicii.preiaDisciplineDupaProgramulDeStudiu(program.id_programe_de_studiu, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
                Disciplina.ItemDisplayBinding = new Binding("nume_disciplina");
                ListaActivitati.ItemsSource = null;
                ListaActivitati.SelectedItems = null;
            }
        }

        private void SelectareActivitati(object sender, SelectionChangedEventArgs e)
        {
            List<int> lista_activitati = ListaActivitati.SelectedItems.Cast<int>().ToList();

            ListaPrezente.ItemsSource = lista_activitati;

            if (TipActivitate.SelectedItem != null && ListaActivitati.ItemsSource != null && ListaActivitati.SelectedItems != null)
            {
                List<int> lista_activitati_total = ListaActivitati.ItemsSource.Cast<int>().ToList();

                if (lista_activitati_total.Count > 0)
                {
                    Intrebare2.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare2.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare3.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare3.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare4.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare4.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare9.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare9.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare12.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare12.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare13.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare13.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    Intrebare14.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;
                    grilaIntrebare14.IsVisible = lista_activitati.Contains(lista_activitati_total.ElementAt(lista_activitati_total.Count - 1)) ? true : false;

                    var lista_elemente = PaginaChestionar.Children.ToList();

                    int index = 0;

                    for (int j = 0; j < lista_elemente.Count; j++)
                    {
                        if (FindByName("grilaIntrebare14") == lista_elemente[j])
                        {
                            index = j;
                        }
                    }

                    for (int j = 0; j < lista_elemente.Count;j++)
                    {
                        if (j > index)
                        {
                            PaginaChestionar.Children.Remove(lista_elemente[j]);
                        }
                    }

                    PaginaChestionar.Children.Add(new Label { Text = "● Ce îmbunătățiri ați propune pentru această activitate?", FontSize = 20, Padding = 6, TextColor = Color.Black });

                    for (int i = 0; i < lista_activitati.Count; i++)
                    {
                        PaginaChestionar.Children.Add(new Editor { TextColor = Color.Black, Placeholder = "Răspuns pentru activitatea " + lista_activitati[i], PlaceholderColor = Color.Gray, Keyboard = Keyboard.Text, AutoSize = EditorAutoSizeOption.TextChanges, Margin = new Thickness (5,-7,0,0) });
                    }

                    PaginaChestionar.Children.Add(new Label { Text = "● Ce aspecte din cadrul acestei activități v-au plăcut?", FontSize = 20, Padding = 6, TextColor = Color.Black });

                    for (int i = 0; i < lista_activitati.Count; i++)
                    {
                        PaginaChestionar.Children.Add(new Editor { TextColor = Color.Black, Placeholder = "Răspuns pentru activitatea " + lista_activitati[i], PlaceholderColor = Color.Gray, Keyboard = Keyboard.Text, AutoSize = EditorAutoSizeOption.TextChanges, Margin = new Thickness(5, -7, 0, 0) });
                    }


                }
            }
        }

        private void casutaBifatIntrebare14NuSeAplicaModificare(object sender, CheckedChangedEventArgs e)
        {
            if ((casutaBifatIntrebare14NuSeAplica.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && casutaBifatIntrebare14Romana.IsChecked) || (casutaBifatIntrebare14NuSeAplica.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && casutaBifatIntrebare14Romana.IsChecked) || (casutaBifatIntrebare14NuSeAplica.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14Romana.IsChecked) || (casutaBifatIntrebare14NuSeAplica.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14Romana.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0))
            {
                casutaBifatIntrebare14Engleza.IsChecked = false;
                casutaBifatIntrebare14Romana.IsChecked = false;
                casutaBifatIntrebare14NuSeAplica.IsChecked = true;
                campIntrebare14AlteLimbi.Text = string.Empty;
            }
        }

        private void casutaBifatIntrebare14RomanaModificare(object sender, CheckedChangedEventArgs e)
        {
            if (casutaBifatIntrebare14NuSeAplica.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && casutaBifatIntrebare14Romana.IsChecked)
            {
                casutaBifatIntrebare14NuSeAplica.IsChecked = false;
            }
        }

        private void casutaBifatIntrebare14EnglezaModificare(object sender, CheckedChangedEventArgs e)
        {
            if (casutaBifatIntrebare14NuSeAplica.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14Romana.IsChecked)
            {
                casutaBifatIntrebare14NuSeAplica.IsChecked = false;
            }
        }

        private void campIntrebare14AlteLimbiModificare(object sender, TextChangedEventArgs e)
        {
            if ((casutaBifatIntrebare14NuSeAplica.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14Romana.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0) || (casutaBifatIntrebare14NuSeAplica.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && casutaBifatIntrebare14Romana.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0))
            {
                casutaBifatIntrebare14NuSeAplica.IsChecked = false;
            }
        }

        private void casutaBifatIntrebare2FizicModificare(object sender, CheckedChangedEventArgs e)
        {
            if (!casutaBifatIntrebare2Electronic.IsChecked && casutaBifatIntrebare2Fizic.IsChecked)
            {
                casutaBifatIntrebare2NuSeAplica.IsChecked = false;
            }
        }

        private void casutaBifatIntrebare2ElectronicModificare(object sender, CheckedChangedEventArgs e)
        {
            if (casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2Fizic.IsChecked)
            {
                casutaBifatIntrebare2NuSeAplica.IsChecked = false;
            }
        }

        private void casutaBifatIntrebare2NuSeAplicaModificare(object sender, CheckedChangedEventArgs e)
        {
            if ((casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2Fizic.IsChecked && casutaBifatIntrebare2NuSeAplica.IsChecked) || (!casutaBifatIntrebare2Electronic.IsChecked && casutaBifatIntrebare2Fizic.IsChecked && casutaBifatIntrebare2NuSeAplica.IsChecked) || (casutaBifatIntrebare2Electronic.IsChecked && casutaBifatIntrebare2Fizic.IsChecked && casutaBifatIntrebare2NuSeAplica.IsChecked))
            {
                casutaBifatIntrebare2NuSeAplica.IsChecked = true;
                casutaBifatIntrebare2Fizic.IsChecked = false;
                casutaBifatIntrebare2Electronic.IsChecked = false;
            }
        }

        private async void butonTrimiteChestionar(object sender, EventArgs e)
        {
            bool complet = ListaActivitati.SelectedItems.Cast<int>().ToList().Contains(14) ? true : false;

            bool cicluStudii = CicluriStudiu.SelectedItem == null ? false : true;
            CicluriStudiu.Title = CicluriStudiu.SelectedItem == null ? "Alege ciclul de studii" : "*Ciclul de studii:";
            CicluriStudiu.TitleColor = CicluriStudiu.SelectedItem == null ? Color.Red : Color.Gray;


            bool anStudiu = AniStudiu.SelectedItem == null ? false : true;
            AniStudiu.Title = AniStudiu.SelectedItem == null ? "Alege anul de studiu" : "*Anul de studiu:";
            AniStudiu.TitleColor = AniStudiu.SelectedItem == null ? Color.Red : Color.Gray;

            bool programStudiu = ProgrameDeStudiu.SelectedItem == null ? false : true;
            ProgrameDeStudiu.Title = ProgrameDeStudiu.SelectedItem == null ? "Alege programul de studiu" : "*Programul de studiu:";
            ProgrameDeStudiu.TitleColor = ProgrameDeStudiu.SelectedItem == null ? Color.Red : Color.Gray;

            bool disciplinaB = Disciplina.SelectedItem == null ? false : true;
            Disciplina.Title = Disciplina.SelectedItem == null ? "Alege disciplina" : "*Disciplina:";
            Disciplina.TitleColor = Disciplina.SelectedItem == null ? Color.Red : Color.Gray;

            bool tipActivitate = TipActivitate.SelectedItem == null ? false : true;
            TipActivitate.Title = TipActivitate.SelectedItem == null ? "Alege tipul activității" : "*Tipul de activitate:";
            TipActivitate.TitleColor = TipActivitate.SelectedItem == null ? Color.Red : Color.Gray;

            bool listaActivitati = ListaActivitati.SelectedItems.Count == 0 ? false : true;
            etichetaListaActivitati.TextColor = ListaActivitati.SelectedItems.Count == 0 ? Color.Red : Color.Black;

            bool intrebare2 = (!casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2Fizic.IsChecked && !casutaBifatIntrebare2NuSeAplica.IsChecked && Intrebare2.IsVisible) ? false : true;
            Intrebare2.TextColor = (!casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2Fizic.IsChecked && !casutaBifatIntrebare2NuSeAplica.IsChecked && Intrebare2.IsVisible) ? Color.Red : Color.Black;

            bool intrebare3 = (!butonRadioIntrebare3Da.IsChecked && !butonRadioIntrebare3Nu.IsChecked && !butonRadioIntrebare3NuSeAplica.IsChecked && Intrebare3.IsVisible) ? false : true;
            Intrebare3.TextColor = (!butonRadioIntrebare3Da.IsChecked && !butonRadioIntrebare3Nu.IsChecked && !butonRadioIntrebare3NuSeAplica.IsChecked && Intrebare3.IsVisible) ? Color.Red : Color.Black;

            bool intrebare4 = (!butonRadioIntrebare41.IsChecked && !butonRadioIntrebare42.IsChecked && !butonRadioIntrebare43.IsChecked && !butonRadioIntrebare44.IsChecked && !butonRadioIntrebare45.IsChecked && !butonRadioIntrebare46.IsChecked && Intrebare4.IsVisible) ? false : true;
            Intrebare4.TextColor = (!butonRadioIntrebare41.IsChecked && !butonRadioIntrebare42.IsChecked && !butonRadioIntrebare43.IsChecked && !butonRadioIntrebare44.IsChecked && !butonRadioIntrebare45.IsChecked && !butonRadioIntrebare46.IsChecked && Intrebare4.IsVisible) ? Color.Red : Color.Black;

            bool intrebare5 = (!butonRadioIntrebare51.IsChecked && !butonRadioIntrebare52.IsChecked && !butonRadioIntrebare53.IsChecked && !butonRadioIntrebare54.IsChecked && !butonRadioIntrebare55.IsChecked && !butonRadioIntrebare56.IsChecked) ? false : true;
            Intrebare5.TextColor = (!butonRadioIntrebare51.IsChecked && !butonRadioIntrebare52.IsChecked && !butonRadioIntrebare53.IsChecked && !butonRadioIntrebare54.IsChecked && !butonRadioIntrebare55.IsChecked && !butonRadioIntrebare56.IsChecked) ? Color.Red : Color.Black;

            bool intrebare6 = (!butonRadioIntrebare61.IsChecked && !butonRadioIntrebare62.IsChecked && !butonRadioIntrebare63.IsChecked && !butonRadioIntrebare64.IsChecked && !butonRadioIntrebare65.IsChecked && !butonRadioIntrebare66.IsChecked) ? false : true;
            Intrebare6.TextColor = (!butonRadioIntrebare61.IsChecked && !butonRadioIntrebare62.IsChecked && !butonRadioIntrebare63.IsChecked && !butonRadioIntrebare64.IsChecked && !butonRadioIntrebare65.IsChecked && !butonRadioIntrebare66.IsChecked) ? Color.Red : Color.Black;

            bool intrebare7 = (!butonRadioIntrebare71.IsChecked && !butonRadioIntrebare72.IsChecked && !butonRadioIntrebare73.IsChecked && !butonRadioIntrebare74.IsChecked && !butonRadioIntrebare75.IsChecked && !butonRadioIntrebare76.IsChecked) ? false : true;
            Intrebare7.TextColor = (!butonRadioIntrebare71.IsChecked && !butonRadioIntrebare72.IsChecked && !butonRadioIntrebare73.IsChecked && !butonRadioIntrebare74.IsChecked && !butonRadioIntrebare75.IsChecked && !butonRadioIntrebare76.IsChecked) ? Color.Red : Color.Black;

            bool intrebare8 = (!butonRadioIntrebare81.IsChecked && !butonRadioIntrebare82.IsChecked && !butonRadioIntrebare83.IsChecked && !butonRadioIntrebare84.IsChecked && !butonRadioIntrebare85.IsChecked && !butonRadioIntrebare86.IsChecked) ? false : true;
            Intrebare8.TextColor = (!butonRadioIntrebare81.IsChecked && !butonRadioIntrebare82.IsChecked && !butonRadioIntrebare83.IsChecked && !butonRadioIntrebare84.IsChecked && !butonRadioIntrebare85.IsChecked && !butonRadioIntrebare86.IsChecked) ? Color.Red : Color.Black;

            bool intrebare9 = (!butonRadioIntrebare91.IsChecked && !butonRadioIntrebare92.IsChecked && !butonRadioIntrebare93.IsChecked && !butonRadioIntrebare94.IsChecked && !butonRadioIntrebare95.IsChecked && !butonRadioIntrebare96.IsChecked && Intrebare9.IsVisible) ? false : true;
            Intrebare9.TextColor = (!butonRadioIntrebare91.IsChecked && !butonRadioIntrebare92.IsChecked && !butonRadioIntrebare93.IsChecked && !butonRadioIntrebare94.IsChecked && !butonRadioIntrebare95.IsChecked && !butonRadioIntrebare96.IsChecked && Intrebare9.IsVisible) ? Color.Red : Color.Black;

            bool intrebare10 = (!butonRadioIntrebare101.IsChecked && !butonRadioIntrebare102.IsChecked && !butonRadioIntrebare103.IsChecked && !butonRadioIntrebare104.IsChecked && !butonRadioIntrebare105.IsChecked && !butonRadioIntrebare106.IsChecked) ? false : true;
            Intrebare10.TextColor = (!butonRadioIntrebare101.IsChecked && !butonRadioIntrebare102.IsChecked && !butonRadioIntrebare103.IsChecked && !butonRadioIntrebare104.IsChecked && !butonRadioIntrebare105.IsChecked && !butonRadioIntrebare106.IsChecked) ? Color.Red : Color.Black;

            bool intrebare11 = (!butonRadioIntrebare111.IsChecked && !butonRadioIntrebare112.IsChecked && !butonRadioIntrebare113.IsChecked && !butonRadioIntrebare114.IsChecked && !butonRadioIntrebare115.IsChecked && !butonRadioIntrebare116.IsChecked) ? false : true;
            Intrebare11.TextColor = (!butonRadioIntrebare111.IsChecked && !butonRadioIntrebare112.IsChecked && !butonRadioIntrebare113.IsChecked && !butonRadioIntrebare114.IsChecked && !butonRadioIntrebare115.IsChecked && !butonRadioIntrebare116.IsChecked) ? Color.Red : Color.Black;

            bool intrebare12 = (!butonRadioIntrebare121.IsChecked && !butonRadioIntrebare122.IsChecked && !butonRadioIntrebare123.IsChecked && !butonRadioIntrebare124.IsChecked && !butonRadioIntrebare125.IsChecked && Intrebare12.IsVisible) ? false : true;
            Intrebare12.TextColor = (!butonRadioIntrebare121.IsChecked && !butonRadioIntrebare122.IsChecked && !butonRadioIntrebare123.IsChecked && !butonRadioIntrebare124.IsChecked && !butonRadioIntrebare125.IsChecked && Intrebare12.IsVisible) ? Color.Red : Color.Black;

            bool intrebare13 = (!butonRadioIntrebare131.IsChecked && !butonRadioIntrebare132.IsChecked && !butonRadioIntrebare133.IsChecked && !butonRadioIntrebare134.IsChecked && !butonRadioIntrebare135.IsChecked && !butonRadioIntrebare136.IsChecked && Intrebare13.IsVisible) ? false : true;
            Intrebare13.TextColor = (!butonRadioIntrebare131.IsChecked && !butonRadioIntrebare132.IsChecked && !butonRadioIntrebare133.IsChecked && !butonRadioIntrebare134.IsChecked && !butonRadioIntrebare135.IsChecked && !butonRadioIntrebare136.IsChecked && Intrebare13.IsVisible) ? Color.Red : Color.Black;

            bool intrebare14 = (!casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text == null && Intrebare14.IsVisible) ? false : true;
            Intrebare14.TextColor = (!casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text == null && Intrebare14.IsVisible) ? Color.Red : Color.Black;

            if ((cicluStudii && anStudiu && programStudiu && disciplinaB && tipActivitate && listaActivitati && intrebare5 && intrebare6 && intrebare7 && intrebare8 && intrebare10 && intrebare11 && !complet) || (complet && cicluStudii && anStudiu && programStudiu && disciplinaB && tipActivitate && listaActivitati && intrebare2 && intrebare3 && intrebare4 && intrebare5 && intrebare6 && intrebare7 && intrebare8 && intrebare9 && intrebare10 && intrebare11 && intrebare12 && intrebare13 && intrebare14))
            {
                AniDeStudiu anul_de_studiu = AniStudiu.SelectedItem as AniDeStudiu;

                ProgrameStudiu programul_de_studiu = ProgrameDeStudiu.SelectedItem as ProgrameStudiu;

                Disciplina disciplina = Disciplina.SelectedItem as Disciplina;

                TipuriActivitati tip_activitate = TipActivitate.SelectedItem as TipuriActivitati;

                List<int> lista_activitati = ListaActivitati.SelectedItems.Cast<int>().ToList();

                List<int> lista_activitati_total = ListaActivitati.ItemsSource.Cast<int>().ToList();

                List<int> lista_prezente = ListaPrezente.SelectedItems.Cast<int>().ToList();

                List<int> lista_prezente_total = ListaPrezente.ItemsSource.Cast<int>().ToList();

                int final = lista_activitati_total.ElementAt(lista_activitati_total.Count - 1);

                string raspuns_intrebare2 = (casutaBifatIntrebare2Fizic.IsChecked && !casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2NuSeAplica.IsChecked) ? "Fizic" : (!casutaBifatIntrebare2Fizic.IsChecked && casutaBifatIntrebare2Electronic.IsChecked && !casutaBifatIntrebare2NuSeAplica.IsChecked) ? "Electronic" : (!casutaBifatIntrebare2Fizic.IsChecked && !casutaBifatIntrebare2Electronic.IsChecked && casutaBifatIntrebare2NuSeAplica.IsChecked) ? "Nu se aplica" : (casutaBifatIntrebare2Electronic.IsChecked && casutaBifatIntrebare2Fizic.IsChecked && !casutaBifatIntrebare2NuSeAplica.IsChecked) ? "Fizic, Electronic" : "";

                string raspuns_intrebare3 = butonRadioIntrebare3Da.IsChecked ? "Da" : butonRadioIntrebare3Nu.IsChecked ? "Nu" : butonRadioIntrebare3NuSeAplica.IsChecked ? "Nu se aplica" : "";

                int raspuns_intrebare4 = butonRadioIntrebare41.IsChecked ? 1 : butonRadioIntrebare42.IsChecked ? 2 : butonRadioIntrebare43.IsChecked ? 3 : butonRadioIntrebare44.IsChecked ? 4 : butonRadioIntrebare45.IsChecked ? 5 : butonRadioIntrebare46.IsChecked ? 6 : 0;

                int raspuns_intrebare5 = butonRadioIntrebare51.IsChecked ? 1 : butonRadioIntrebare52.IsChecked ? 2 : butonRadioIntrebare53.IsChecked ? 3 : butonRadioIntrebare54.IsChecked ? 4 : butonRadioIntrebare55.IsChecked ? 5 : butonRadioIntrebare56.IsChecked ? 6 : 0;

                int raspuns_intrebare6 = butonRadioIntrebare61.IsChecked ? 1 : butonRadioIntrebare62.IsChecked ? 2 : butonRadioIntrebare63.IsChecked ? 3 : butonRadioIntrebare64.IsChecked ? 4 : butonRadioIntrebare65.IsChecked ? 5 : butonRadioIntrebare66.IsChecked ? 6 : 0;

                int raspuns_intrebare7 = butonRadioIntrebare71.IsChecked ? 1 : butonRadioIntrebare72.IsChecked ? 2 : butonRadioIntrebare73.IsChecked ? 3 : butonRadioIntrebare74.IsChecked ? 4 : butonRadioIntrebare75.IsChecked ? 5 : butonRadioIntrebare76.IsChecked ? 6 : 0;

                int raspuns_intrebare8 = butonRadioIntrebare81.IsChecked ? 1 : butonRadioIntrebare82.IsChecked ? 2 : butonRadioIntrebare83.IsChecked ? 3 : butonRadioIntrebare84.IsChecked ? 4 : butonRadioIntrebare85.IsChecked ? 5 : butonRadioIntrebare86.IsChecked ? 6 : 0;

                int raspuns_intrebare9 = butonRadioIntrebare91.IsChecked ? 1 : butonRadioIntrebare92.IsChecked ? 2 : butonRadioIntrebare93.IsChecked ? 3 : butonRadioIntrebare94.IsChecked ? 4 : butonRadioIntrebare95.IsChecked ? 5 : butonRadioIntrebare96.IsChecked ? 6 : 0;

                int raspuns_intrebare10 = butonRadioIntrebare101.IsChecked ? 1 : butonRadioIntrebare102.IsChecked ? 2 : butonRadioIntrebare103.IsChecked ? 3 : butonRadioIntrebare104.IsChecked ? 4 : butonRadioIntrebare105.IsChecked ? 5 : butonRadioIntrebare106.IsChecked ? 6 : 0;

                int raspuns_intrebare11 = butonRadioIntrebare111.IsChecked ? 1 : butonRadioIntrebare112.IsChecked ? 2 : butonRadioIntrebare113.IsChecked ? 3 : butonRadioIntrebare114.IsChecked ? 4 : butonRadioIntrebare115.IsChecked ? 5 : butonRadioIntrebare116.IsChecked ? 6 : 0;

                int raspuns_intrebare12 = butonRadioIntrebare121.IsChecked ? 1 : butonRadioIntrebare122.IsChecked ? 2 : butonRadioIntrebare123.IsChecked ? 3 : butonRadioIntrebare124.IsChecked ? 4 : butonRadioIntrebare125.IsChecked ? 5 : 0;

                int raspuns_intrebare13 = butonRadioIntrebare131.IsChecked ? 1 : butonRadioIntrebare132.IsChecked ? 2 : butonRadioIntrebare133.IsChecked ? 3 : butonRadioIntrebare134.IsChecked ? 4 : butonRadioIntrebare135.IsChecked ? 5 : butonRadioIntrebare136.IsChecked ? 6 : 0;

                string raspuns_intrebare14 = (casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text == null) ? "Română" : (!casutaBifatIntrebare14Romana.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text == null) ? "Engleză" : (casutaBifatIntrebare14Romana.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text == null) ? "Română, Engleză" : (casutaBifatIntrebare14Romana.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0) ? ("Română, Engleză, " + campIntrebare14AlteLimbi.Text.ToString()) : (!casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0) ? campIntrebare14AlteLimbi.Text : (!casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && casutaBifatIntrebare14NuSeAplica.IsChecked) ? "Nu se aplică" : (casutaBifatIntrebare14Romana.IsChecked && !casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0) ? ("Română, " + campIntrebare14AlteLimbi.Text) : (!casutaBifatIntrebare14Romana.IsChecked && casutaBifatIntrebare14Engleza.IsChecked && !casutaBifatIntrebare14NuSeAplica.IsChecked && campIntrebare14AlteLimbi.Text != null && campIntrebare14AlteLimbi.Text.Length > 0) ? ("Engleză, " + campIntrebare14AlteLimbi.Text) : "";

                List<string> raspunsuri_intrebarea15 = new List<string>();

                List<string> raspunsuri_intrebarea16 = new List<string>();

                var lista_elemente = PaginaChestionar.Children.ToList();

                for (int j = 0; j < lista_elemente.Count; j++)
                {
                    if (FindByName("grilaIntrebare14") == lista_elemente[j])
                    {
                        for (int k = 1; k <= lista_activitati.Count; k++)
                        {
                            Editor camp_raspuns15 = lista_elemente[j + k + 1] as Editor;
                            raspunsuri_intrebarea15.Add(camp_raspuns15.Text);
                            Editor camp_raspuns16 = lista_elemente[j + k + lista_activitati.Count + 2] as Editor;
                            raspunsuri_intrebarea16.Add(camp_raspuns16.Text);
                        }
                    }
                }

                HttpStatusCode[] statusCod = new HttpStatusCode[lista_activitati.Count];

                for (int i = 0; i < lista_activitati.Count; i++)
                {
                    if (lista_activitati[i] == final)
                    {
                        ChestionarCompletDTO chestionarCompletDTO = new ChestionarCompletDTO();

                        chestionarCompletDTO.id_student = await Xamarin.Essentials.SecureStorage.GetAsync("idUtilizator");
                        chestionarCompletDTO.id_disciplina = disciplina.id_disciplina;
                        chestionarCompletDTO.id_an_de_studiu = anul_de_studiu.id_ani_de_studiu;
                        chestionarCompletDTO.id_program_de_studiu = programul_de_studiu.id_programe_de_studiu;
                        chestionarCompletDTO.id_tip_activitate = tip_activitate.id_tip_activitate;
                        chestionarCompletDTO.numar_activitate = lista_activitati[i];
                        chestionarCompletDTO.text_raspuns1 = lista_prezente.Contains(lista_prezente_total[i]) ? "Da" : "Nu";
                        chestionarCompletDTO.text_raspuns2 = raspuns_intrebare2;
                        chestionarCompletDTO.text_raspuns3 = raspuns_intrebare3;
                        chestionarCompletDTO.text_raspuns4 = raspuns_intrebare4.ToString();
                        chestionarCompletDTO.text_raspuns5 = raspuns_intrebare5.ToString();
                        chestionarCompletDTO.text_raspuns6 = raspuns_intrebare6.ToString();
                        chestionarCompletDTO.text_raspuns7 = raspuns_intrebare7.ToString();
                        chestionarCompletDTO.text_raspuns8 = raspuns_intrebare8.ToString();
                        chestionarCompletDTO.text_raspuns9 = raspuns_intrebare9.ToString();
                        chestionarCompletDTO.text_raspuns10 = raspuns_intrebare10.ToString();
                        chestionarCompletDTO.text_raspuns11 = raspuns_intrebare11.ToString();
                        chestionarCompletDTO.text_raspuns12 = raspuns_intrebare12.ToString();
                        chestionarCompletDTO.text_raspuns13 = raspuns_intrebare13.ToString();
                        chestionarCompletDTO.text_raspuns14 = raspuns_intrebare14;
                        chestionarCompletDTO.text_raspuns15 = raspunsuri_intrebarea15[i];
                        chestionarCompletDTO.text_raspuns16 = raspunsuri_intrebarea16[i];

                        if (chestionarCompletDTO.text_raspuns1 == "Da")
                        {
                            statusCod[i] = await evaluareDisciplineServicii.trimiteChestionarComplet(chestionarCompletDTO, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
                        }                        
                    }
                    else
                    {
                        ChestionarPartialDTO chestionarPartialDTO = new ChestionarPartialDTO();

                        chestionarPartialDTO.id_student = await Xamarin.Essentials.SecureStorage.GetAsync("idUtilizator");
                        chestionarPartialDTO.id_disciplina = disciplina.id_disciplina;
                        chestionarPartialDTO.id_an_de_studiu = anul_de_studiu.id_ani_de_studiu;
                        chestionarPartialDTO.id_program_de_studiu = programul_de_studiu.id_programe_de_studiu;
                        chestionarPartialDTO.id_tip_activitate = tip_activitate.id_tip_activitate;
                        chestionarPartialDTO.numar_activitate = lista_activitati[i];
                        chestionarPartialDTO.text_raspuns1 = lista_prezente.Contains(lista_prezente_total[i]) ? "Da" : "Nu";
                        chestionarPartialDTO.text_raspuns5 = raspuns_intrebare5.ToString();
                        chestionarPartialDTO.text_raspuns6 = raspuns_intrebare6.ToString();
                        chestionarPartialDTO.text_raspuns7 = raspuns_intrebare7.ToString();
                        chestionarPartialDTO.text_raspuns8 = raspuns_intrebare8.ToString();
                        chestionarPartialDTO.text_raspuns10 = raspuns_intrebare10.ToString();
                        chestionarPartialDTO.text_raspuns11 = raspuns_intrebare11.ToString();
                        chestionarPartialDTO.text_raspuns15 = raspunsuri_intrebarea15[i];
                        chestionarPartialDTO.text_raspuns16 = raspunsuri_intrebarea16[i];

                        if (chestionarPartialDTO.text_raspuns1 == "Da")
                        {
                            statusCod[i] = await evaluareDisciplineServicii.trimiteChestionarPartial(chestionarPartialDTO, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
                        }                       
                    }
                }

                StringBuilder mesaj = new StringBuilder();

                mesaj.Append("*Doar evaluările la care ați fost prezent vor fi luate în considerare.\n\n");

                for (int r = 0; r < lista_activitati.Count; r++)
                {
                    if (statusCod[r] == HttpStatusCode.NoContent)
                    {
                        mesaj.Append("Evaluarea activității cu numărul " + lista_activitati[r] + " a fost trimisă cu succes. \n");
                    }

                    if (statusCod[r] == HttpStatusCode.Conflict)
                    {
                        mesaj.Append("Ați evaluat deja activitatea cu numărul " + lista_activitati[r] + ". \n");
                    }

                    if (statusCod[r] != HttpStatusCode.NoContent && statusCod[r] != HttpStatusCode.Conflict)
                    {
                        mesaj.Append("Evaluarea activității cu numărul " + lista_activitati[r] + " nu a fost trimisă. \n");
                    }

                }

                await DisplayAlert("", mesaj.ToString(), "Ok");
            }
            else
            {
                await DisplayAlert("", "Nu ați completat toate câmpurile obligatorii.", "Ok");
            }


        }

        private async void Deconectare(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new Conectare());
        }
    }
}