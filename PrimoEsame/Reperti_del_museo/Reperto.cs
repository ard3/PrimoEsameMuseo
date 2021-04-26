using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimoEsame.Reperti_del_museo
{
    public class Reperto
    {
        public int Id { get; set; }

    [Required(ErrorMessage = "Devi scegliere il periodo!")]
    public string NomeReperto { get; set; }

        [Required(ErrorMessage = "Devi scegliere il periodo!")]
    public string Periodo { get; set; }

    [Required(ErrorMessage = "Devi sgegliere la tipologia!")]
    public string Tipologia { get; set; }

    [Required(ErrorMessage = "Aggiungi una breve descrizione!")]
    public string Descrizione { get; set; }
    }
}
