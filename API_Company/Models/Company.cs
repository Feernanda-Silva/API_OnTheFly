using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace API_Company.Models
{
    [BsonIgnoreExtraElements] // Para ignorar o Id do mongo 

    public class Company
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
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
