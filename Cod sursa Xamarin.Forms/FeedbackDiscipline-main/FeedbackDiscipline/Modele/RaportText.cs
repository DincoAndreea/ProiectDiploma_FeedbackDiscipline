using System;
using System.Collections.Generic;
using System.Text;

namespace FeedbackDiscipline.Modele
{
    public class RaportText
    {
        public string text_raspuns { get; set; }
    }

    public class RaportComplet : Dictionary<string, List<RaportText>>
    {
        List<RaportText> intrebarea1 => this["intrebarea1"];
        List<RaportText> intrebarea2 => this["intrebarea2"];
        List<RaportText> intrebarea3 => this["intrebarea3"];
        List<RaportText> intrebarea4 => this["intrebarea4"];
        List<RaportText> intrebarea5 => this["intrebarea5"];
        List<RaportText> intrebarea6 => this["intrebarea6"];
        List<RaportText> intrebarea7 => this["intrebarea7"];
        List<RaportText> intrebarea8 => this["intrebarea8"];
        List<RaportText> intrebarea9 => this["intrebarea9"];
        List<RaportText> intrebarea10 => this["intrebarea10"];
        List<RaportText> intrebarea11 => this["intrebarea11"];
        List<RaportText> intrebarea12 => this["intrebarea12"];
        List<RaportText> intrebarea13 => this["intrebarea13"];
        List<RaportText> intrebarea14 => this["intrebarea14"];
        List<RaportText> intrebarea15 => this["intrebarea15"];
        List<RaportText> intrebarea16 => this["intrebarea16"];

    }


}
