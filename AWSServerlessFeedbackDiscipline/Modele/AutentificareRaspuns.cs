namespace AWSServerlessFeedbackDiscipline.Modele
{
    public class AutentificareRaspuns
    {
        public string? token { get; set; }
        public DateTime data_expirare_token { get; set; }
        public string? id_utilizator { get; set; }
        public string? token_reimprospatare { get; set; }
        public DateTime data_expirare_token_reimprospatare { get; set; }
        public string? nume_utilizator { get; set; }
        public string? rol { get; set; }
    }
}
