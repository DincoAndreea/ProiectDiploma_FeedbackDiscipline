using FeedbackDiscipline.Modele;
using FeedbackDiscipline.ServiciiAPI;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace FeedbackDiscipline.Pagini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RaportEvaluari : ContentPage
    {
        public List<TipuriActivitati> tipactivitati { get; set; }

        IEvaluareDisciplineServicii evaluareDisciplineServicii = new EvaluareDisciplineServicii();

        IRaportEvaluariServicii raportEvaluariServicii = new RaportEvaluariServicii();
        public RaportEvaluari()
        {
            InitializeComponent();
            CicluriStudii();
            TipuriActivitati();
        }

        private async void CicluriStudii()
        {
            raportCicluStudii.ItemsSource = await evaluareDisciplineServicii.preiaCicluriStudii(await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
            raportCicluStudii.ItemDisplayBinding = new Binding("nume_ciclu_de_studii");
        }

        private async void TipuriActivitati()
        {
            tipactivitati = await evaluareDisciplineServicii.preiaTipuriActivitati(await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
        }

        private async void getRaport(RaportDTO raport)
        {
            var raport_complet = await raportEvaluariServicii.preiaRaport(raport, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));

            if (raport_complet != null || raport_complet.Count > 0)
            {
                StringBuilder raport_afisare_intrebarea15 = new StringBuilder();

                StringBuilder raport_afisare_intrebarea16 = new StringBuilder();

                StringBuilder legenda = new StringBuilder();

                int[,] raspunsuri_intrebari_4_13 = new int[10, 6];
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        raspunsuri_intrebari_4_13[j, k] = 0;
                    }
                }

                List<List<Entry>> date = new List<List<Entry>>();

                for (int l = 0; l < 10; l++)
                {
                    string intrebare = "intrebarea" + (l + 4);
                    foreach (RaportText raspuns in raport_complet[intrebare])
                    {
                        raspunsuri_intrebari_4_13[l, Convert.ToInt32(raspuns.text_raspuns) - 1]++;
                    }

                    List<Entry> date_diagrama = new List<Entry>();
                    for (int j = 0; j < 6; j++)
                    {
                        if (j == 5 && l != 8)
                        {
                            date_diagrama.Add(new Entry(raspunsuri_intrebari_4_13[l, j])
                            {
                                Color = SKColor.Parse("#4992EF"),
                                Label = "Nu se aplică",
                                ValueLabel = raspunsuri_intrebari_4_13[l, j].ToString()
                            });
                        }
                        else
                        {
                            if (j < 5)
                            {
                                date_diagrama.Add(new Entry(raspunsuri_intrebari_4_13[l, j])
                                {
                                    Color = SKColor.Parse("#4992EF"),
                                    Label = (j + 1).ToString(),
                                    ValueLabel = raspunsuri_intrebari_4_13[l, j].ToString()
                                });
                            }
                        }
                    }
                    date.Add(date_diagrama);
                }

                int fara_raspuns1 = 0;

                if (raport_complet["intrebarea15"].Count > 0)
                {
                    foreach (RaportText raspuns in raport_complet["intrebarea15"])
                    {
                        if (!string.IsNullOrWhiteSpace(raspuns.text_raspuns))
                        {
                            raport_afisare_intrebarea15.Append("- " + raspuns.text_raspuns + "\n");
                        }

                        if(string.IsNullOrWhiteSpace(raspuns.text_raspuns))
                        {
                            fara_raspuns1++;
                        }
                    }

                    if(fara_raspuns1 == raport_complet["intrebarea15"].Count)
                    {
                        raport_afisare_intrebarea15.Append("-\n");
                    }
                }
                else
                {
                    raport_afisare_intrebarea15.Append("-\n");
                }

                int fara_raspuns2 = 0;

                if (raport_complet["intrebarea16"].Count > 0)
                {
                    foreach (RaportText raspuns in raport_complet["intrebarea16"])
                    {
                        if (!string.IsNullOrWhiteSpace(raspuns.text_raspuns))
                        {
                            raport_afisare_intrebarea16.Append("- " + raspuns.text_raspuns + "\n");
                        }

                        if (string.IsNullOrWhiteSpace(raspuns.text_raspuns))
                        {
                            fara_raspuns2++;
                        }
                    }

                    if (fara_raspuns2 == raport_complet["intrebarea16"].Count)
                    {
                        raport_afisare_intrebarea16.Append("-\n");
                    }
                }
                else
                {
                    raport_afisare_intrebarea16.Append("-\n");
                }

                legenda.Append("Legendă:\n\n1 - Nu sunt de acord\n\n5 - Sunt de acord\n\n\n");

                etichetaIntrebarea15.IsVisible = true;
                etichetaIntrebarea16.IsVisible = true;

                raportEtichetaIntrebarea15.Text = raport_afisare_intrebarea15.ToString();

                raportEtichetaIntrebarea16.Text = raport_afisare_intrebarea16.ToString();

                raportEtichetaLegenda.Text = legenda.ToString();

                raportIntrebarea4.IsVisible = true;
                raportIntrebarea5.IsVisible = true;
                raportIntrebarea6.IsVisible = true;
                raportIntrebarea7.IsVisible = true;
                raportIntrebarea8.IsVisible = true;
                raportIntrebarea9.IsVisible = true;
                raportIntrebarea10.IsVisible = true;
                raportIntrebarea11.IsVisible = true;
                raportIntrebarea12.IsVisible = true;
                raportIntrebarea13.IsVisible = true;

                diagramaIntrebarea4.IsVisible = true;
                diagramaIntrebarea5.IsVisible = true;
                diagramaIntrebarea6.IsVisible = true;
                diagramaIntrebarea7.IsVisible = true;
                diagramaIntrebarea8.IsVisible = true;
                diagramaIntrebarea9.IsVisible = true;
                diagramaIntrebarea10.IsVisible = true;
                diagramaIntrebarea11.IsVisible = true;
                diagramaIntrebarea12.IsVisible = true;
                diagramaIntrebarea13.IsVisible = true;

                diagramaIntrebarea4.Chart = new LineChart { Entries = date.ElementAt(0), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea5.Chart = new LineChart { Entries = date.ElementAt(1), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea6.Chart = new LineChart { Entries = date.ElementAt(2), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea7.Chart = new LineChart { Entries = date.ElementAt(3), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea8.Chart = new LineChart { Entries = date.ElementAt(4), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea9.Chart = new LineChart { Entries = date.ElementAt(5), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea10.Chart = new LineChart { Entries = date.ElementAt(6), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea11.Chart = new LineChart { Entries = date.ElementAt(7), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea12.Chart = new LineChart { Entries = date.ElementAt(8), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
                diagramaIntrebarea13.Chart = new LineChart { Entries = date.ElementAt(9), LabelTextSize = 45f, ValueLabelOrientation = Orientation.Horizontal, BackgroundColor = SKColors.Transparent, LabelColor = SKColors.Black, PointSize = 30f };
            }
        }

        private async void raportCicluStudiiSelectare(object sender, EventArgs e)
        {
            Picker pick = sender as Picker;
            CiclulDeStudii ciclu = pick.SelectedItem as CiclulDeStudii;
            raportProgramStudiu.ItemsSource = await evaluareDisciplineServicii.preiaProgrameStudiiDupaCiclulDeStudii(ciclu.id_ciclu_de_studii, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
            raportProgramStudiu.ItemDisplayBinding = new Binding("nume_programe_de_studiu");
            raportDisciplina.ItemsSource = null;
            raportTipActivitate.ItemsSource = null;

            etichetaIntrebarea15.IsVisible = false;
            etichetaIntrebarea16.IsVisible = false;

            raportEtichetaIntrebarea15.Text = "";

            raportEtichetaIntrebarea16.Text = "";

            raportEtichetaLegenda.Text = "";

            raportIntrebarea4.IsVisible = false;
            raportIntrebarea5.IsVisible = false;
            raportIntrebarea6.IsVisible = false;
            raportIntrebarea7.IsVisible = false;
            raportIntrebarea8.IsVisible = false;
            raportIntrebarea9.IsVisible = false;
            raportIntrebarea10.IsVisible = false;
            raportIntrebarea11.IsVisible = false;
            raportIntrebarea12.IsVisible = false;
            raportIntrebarea13.IsVisible = false;

            diagramaIntrebarea4.IsVisible = false;
            diagramaIntrebarea5.IsVisible = false;
            diagramaIntrebarea6.IsVisible = false;
            diagramaIntrebarea7.IsVisible = false;
            diagramaIntrebarea8.IsVisible = false;
            diagramaIntrebarea9.IsVisible = false;
            diagramaIntrebarea10.IsVisible = false;
            diagramaIntrebarea11.IsVisible = false;
            diagramaIntrebarea12.IsVisible = false;
            diagramaIntrebarea13.IsVisible = false;
        }

        private async void raportProgramStudiuSelectare(object sender, EventArgs e)
        {
            Picker pick = sender as Picker;
            ProgrameStudiu program = pick.SelectedItem as ProgrameStudiu;
            if (program != null)
            {
                raportDisciplina.ItemsSource = await evaluareDisciplineServicii.preiaDisciplineDupaProgramulDeStudiu(program.id_programe_de_studiu, await Xamarin.Essentials.SecureStorage.GetAsync("token"), await Xamarin.Essentials.SecureStorage.GetAsync("tokenReimprospatare"));
                raportDisciplina.ItemDisplayBinding = new Binding("nume_disciplina");
            }

            etichetaIntrebarea15.IsVisible = false;
            etichetaIntrebarea16.IsVisible = false;

            raportEtichetaIntrebarea15.Text = "";

            raportEtichetaIntrebarea16.Text = "";

            raportEtichetaLegenda.Text = "";

            raportIntrebarea4.IsVisible = false;
            raportIntrebarea5.IsVisible = false;
            raportIntrebarea6.IsVisible = false;
            raportIntrebarea7.IsVisible = false;
            raportIntrebarea8.IsVisible = false;
            raportIntrebarea9.IsVisible = false;
            raportIntrebarea10.IsVisible = false;
            raportIntrebarea11.IsVisible = false;
            raportIntrebarea12.IsVisible = false;
            raportIntrebarea13.IsVisible = false;

            diagramaIntrebarea4.IsVisible = false;
            diagramaIntrebarea5.IsVisible = false;
            diagramaIntrebarea6.IsVisible = false;
            diagramaIntrebarea7.IsVisible = false;
            diagramaIntrebarea8.IsVisible = false;
            diagramaIntrebarea9.IsVisible = false;
            diagramaIntrebarea10.IsVisible = false;
            diagramaIntrebarea11.IsVisible = false;
            diagramaIntrebarea12.IsVisible = false;
            diagramaIntrebarea13.IsVisible = false;
        }

        private void raportDisciplinaSelectare(object sender, EventArgs e)
        {
            raportTipActivitate.ItemsSource = tipactivitati;
            raportTipActivitate.ItemDisplayBinding = new Binding("nume_activitate");

            etichetaIntrebarea15.IsVisible = false;
            etichetaIntrebarea16.IsVisible = false;

            raportEtichetaIntrebarea15.Text = "";

            raportEtichetaIntrebarea16.Text = "";

            raportEtichetaLegenda.Text = "";

            raportIntrebarea4.IsVisible = false;
            raportIntrebarea5.IsVisible = false;
            raportIntrebarea6.IsVisible = false;
            raportIntrebarea7.IsVisible = false;
            raportIntrebarea8.IsVisible = false;
            raportIntrebarea9.IsVisible = false;
            raportIntrebarea10.IsVisible = false;
            raportIntrebarea11.IsVisible = false;
            raportIntrebarea12.IsVisible = false;
            raportIntrebarea13.IsVisible = false;

            diagramaIntrebarea4.IsVisible = false;
            diagramaIntrebarea5.IsVisible = false;
            diagramaIntrebarea6.IsVisible = false;
            diagramaIntrebarea7.IsVisible = false;
            diagramaIntrebarea8.IsVisible = false;
            diagramaIntrebarea9.IsVisible = false;
            diagramaIntrebarea10.IsVisible = false;
            diagramaIntrebarea11.IsVisible = false;
            diagramaIntrebarea12.IsVisible = false;
            diagramaIntrebarea13.IsVisible = false;
        }

        private void resetareAfisareRaport()
        {
            etichetaIntrebarea15.IsVisible = false;
            etichetaIntrebarea16.IsVisible = false;

            raportEtichetaIntrebarea15.Text = "";

            raportEtichetaIntrebarea16.Text = "";

            raportEtichetaLegenda.Text = "";

            raportIntrebarea4.IsVisible = false;
            raportIntrebarea5.IsVisible = false;
            raportIntrebarea6.IsVisible = false;
            raportIntrebarea7.IsVisible = false;
            raportIntrebarea8.IsVisible = false;
            raportIntrebarea9.IsVisible = false;
            raportIntrebarea10.IsVisible = false;
            raportIntrebarea11.IsVisible = false;
            raportIntrebarea12.IsVisible = false;
            raportIntrebarea13.IsVisible = false;

            diagramaIntrebarea4.IsVisible = false;
            diagramaIntrebarea5.IsVisible = false;
            diagramaIntrebarea6.IsVisible = false;
            diagramaIntrebarea7.IsVisible = false;
            diagramaIntrebarea8.IsVisible = false;
            diagramaIntrebarea9.IsVisible = false;
            diagramaIntrebarea10.IsVisible = false;
            diagramaIntrebarea11.IsVisible = false;
            diagramaIntrebarea12.IsVisible = false;
            diagramaIntrebarea13.IsVisible = false;
        }

        private void raportTipActivitateSelectare(object sender, EventArgs e)
        {
            RaportDTO raport = new RaportDTO();
            Disciplina disciplina = raportDisciplina.SelectedItem as Disciplina;
            TipuriActivitati tipActivitate = raportTipActivitate.SelectedItem as TipuriActivitati;
            if (tipActivitate != null && disciplina != null)
            {
                raport.id_disciplina = disciplina.id_disciplina;
                raport.id_tip_activitate = tipActivitate.id_tip_activitate;

                if (raport != null && disciplina.nr_cursuri > 0 && tipActivitate.nume_activitate == "Curs")
                {
                    getRaport(raport);
                }
                else
                {
                    resetareAfisareRaport();
                }

                if (raport != null && disciplina.nr_seminare > 0 && tipActivitate.nume_activitate == "Seminar")
                {
                    getRaport(raport);
                }
                else
                {
                    resetareAfisareRaport();
                }

                if (raport != null && disciplina.nr_laboratoare > 0 && tipActivitate.nume_activitate == "Laborator")
                {
                    getRaport(raport);
                }
                else
                {
                    resetareAfisareRaport();
                }

                if (raport != null && disciplina.nr_intalniri_proiect > 0 && tipActivitate.nume_activitate == "Proiect")
                {
                    getRaport(raport);
                }
                else
                {
                    resetareAfisareRaport();
                }
            }

        }

        private async void Deconectare(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new Conectare());
        }
    }
}