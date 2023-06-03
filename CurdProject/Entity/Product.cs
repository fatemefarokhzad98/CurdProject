using System.ComponentModel.DataAnnotations;

namespace CurdProject.Entity
{
    public class Product
    {
        
        public int Id { get; set; }
        [Display(Name ="Name")]
        [Required (ErrorMessage ="enter nameProduct" )]
        [MaxLength(100)]

        public string Name { get; set; }
        [Required(ErrorMessage ="enter Price")]
        [Display(Name ="Price")]
        public int Price { get; set; }
        [Display(Name="Count")]
        [Range(0,100) ]
        public int? Count { get; set; }




    }
}
