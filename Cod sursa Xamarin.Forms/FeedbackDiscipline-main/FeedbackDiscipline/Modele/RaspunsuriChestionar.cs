using System;
using System.Collections.Generic;
using System.Text;

namespace FeedbackDiscipline.Modele
{
    public class RaspunsuriChestionar
    {
        public int id_raspuns { get; set; }
        public int id_chestionar { get; set; }
        public int id_intrebare { get; set; }
        public string text_raspuns { get; set; }

        public RaspunsuriChestionar(int id_raspuns, int id_chestionar, int id_intrebare, string text_raspuns) 
        { 
            this.id_raspuns = id_raspuns;
            this.id_chestionar = id_chestionar;
            this.id_intrebare = id_intrebare;
            this.text_raspuns= text_raspuns;
        }
    }
}
