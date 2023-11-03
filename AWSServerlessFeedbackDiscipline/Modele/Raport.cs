using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AWSServerlessFeedbackDiscipline.Modele
{
    [Keyless]
    public class Raport
    {
        public string? text_raspuns { get; set; }
    }

    public class RaportComplet
    {
        public List<Raport>? intrebarea1 { get; set; }
        public List<Raport>? intrebarea2 { get; set; }
        public List<Raport>? intrebarea3 { get; set; }
        public List<Raport>? intrebarea4 { get; set; }
        public List<Raport>? intrebarea5 { get; set; }
        public List<Raport>? intrebarea6 { get; set; }
        public List<Raport>? intrebarea7 { get; set; }
        public List<Raport>? intrebarea8 { get; set; }
        public List<Raport>? intrebarea9 { get; set; }
        public List<Raport>? intrebarea10 { get; set; }
        public List<Raport>? intrebarea11 { get; set; }
        public List<Raport>? intrebarea12 { get; set; }
        public List<Raport>? intrebarea13 { get; set; }
        public List<Raport>? intrebarea14 { get; set; }
        public List<Raport>? intrebarea15 { get; set; }
        public List<Raport>? intrebarea16 { get; set; }
    }
}
