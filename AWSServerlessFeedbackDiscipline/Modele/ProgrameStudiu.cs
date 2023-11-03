using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class ProgrameStudiu
    {
        [Key] public int id_programe_de_studiu { get; set; }
        public string? nume_programe_de_studiu { get; set; }
        public int id_ciclul_de_studii { get; set; }

    }
}
