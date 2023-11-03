using System;
using System.Collections.Generic;
using System.Text;

namespace FeedbackDiscipline.Modele
{
    public class Chestionare
    {
        public int id_chestionar { get; set; }
        public int id_student { get; set; }
        public int id_disciplina { get; set; }
        public int id_an_de_studiu { get; set; }
        public int id_program_de_studiu { get; set; }
        public int id_tip_activitate { get; set; }
        public int numar_activitate { get; set; }
    }
}
