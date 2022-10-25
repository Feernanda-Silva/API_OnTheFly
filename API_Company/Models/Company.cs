using System.ComponentModel.DataAnnotations;

namespace API_Company.Models
{
    public class Company
    {
        [Required (ErrorMessage = "Cpnj é um campo obrigatório")]
        [StringLength (19)]
        public string Cnpj { get; set; } //mascara
        [Required (ErrorMessage ="Nome é um campo obrigatório")]
        [StringLength (30)]
        public string Name { get; set; } 
        [StringLength(30)]
        public string NameOpt { get; set; } 
        public string DtOpen { get; set; } 
        public bool Status { get; set; }
        //public Address address { get; set; }
    }
}
