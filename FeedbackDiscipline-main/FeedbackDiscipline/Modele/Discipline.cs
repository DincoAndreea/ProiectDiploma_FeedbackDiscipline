using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FeedbackDiscipline.Modele
{
    public class Disciplina
    {
        public int id_disciplina { get; set; }
        public string nume_disciplina { get; set; }
        public int ciclul_de_studii { get; set; }
        public int program_de_studii { get; set; }
        public int anul_de_studiu { get; set; }
        public int semestrul { get; set; }
        public int nr_cursuri { get; set; }
        public int nr_laboratoare { get; set; }
        public int nr_seminare { get; set; }
        public int nr_intalniri_proiect { get; set; }
    }

}
