using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class TipuriActivitati
    {
        [Key] public int id_tip_activitate { get; set; }
        public string? nume_activitate { get; set; }
    }
}
