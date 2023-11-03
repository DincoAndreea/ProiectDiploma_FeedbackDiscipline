using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class Utilizator
    {
        [Required]
        public string? nume_utilizator { get; set; }
        [Required]
        public string? parola { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? rol { get; set; }
    }

    public class NumeUtilizator
    {
        public string? nume_utilizator { get; set; }
    }
}
