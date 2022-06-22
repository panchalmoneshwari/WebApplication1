using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [MaxLength(20)]
        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Author Name is Required")]
        public string AuthorName { get; set; }

        [MaxLength(40)]
        [Display(Name = "Publisher Name")]
        [Required(ErrorMessage = "Publisher Name is Required")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Published Date is Required")]
        [DataType(DataType.Date)]
        [Display(Name="Published Date")]
        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(minimum:100,maximum:1000,ErrorMessage ="Price should be in Between 100-1000")]
        public int Price { get; set; }
    }
}