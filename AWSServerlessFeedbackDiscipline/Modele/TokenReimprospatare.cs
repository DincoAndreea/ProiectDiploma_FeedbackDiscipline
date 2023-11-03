using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class TokenReimprospatare
    {
        [Key] public int id_token_reimprospatare { get; set; }
        public string? id_utilizator { get; set; }
        public string? valoare { get; set; }
        public DateTime data_expirare { get; set; }
    }
}
