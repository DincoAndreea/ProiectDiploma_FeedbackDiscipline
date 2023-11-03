using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class CiclulDeStudii
    {
        [Key] public int id_ciclu_de_studii { get; set; }
        public string? nume_ciclu_de_studii { get; set; }
    }
}
