using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class AutentificareCerere
    {
        [Required]
        public string? email { get; set; }
        [Required]
        public string? parola { get; set; }
    }
}
