using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class AniDeStudiu
    {
        [Key] public int id_ani_de_studiu { get; set; }
        public string? anul_de_studiu { get; set; }
        public int ciclul_de_studii { get; set; }
    }
}
