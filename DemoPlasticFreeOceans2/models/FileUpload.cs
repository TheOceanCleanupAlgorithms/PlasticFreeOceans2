using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DemoPlasticFreeOceans2.Models
{
    public class FileUpload
    {
        [Required]
        [Display(Name = "Title")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Picture")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [Display(Name = "update")]
        public IFormFile UploadPicture { get; set; }
    }
}