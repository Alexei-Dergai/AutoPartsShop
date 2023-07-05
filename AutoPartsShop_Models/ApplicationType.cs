using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop_Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
    }
}
