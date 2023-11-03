using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class Chestionare
    {
        [Key] public int id_chestionar { get; set; }
        public string? id_student { get; set; }
        public int id_disciplina { get; set; }
        public int id_an_de_studiu { get; set; }
        public int id_program_de_studiu { get; set; }
        public int id_tip_activitate { get; set; }
        public int numar_activitate { get; set; }
    }
}
