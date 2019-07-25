using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoPlasticFreeOceans2.Models;
using DemoPlasticFreeOceans2.Utilities;

namespace DemoPlasticFreeOceans2.Pages.Schedules
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public FileUpload FileUpload { get; set; }

        public IList<Schedule> Schedule { get; private set; }



        public async Task<IActionResult> OnPostAsync()
        {

            var publicScheduleData =
                await FileHelpers.ProcessFormFile(FileUpload.UploadPublicSchedule, ModelState);
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var schedule = new Schedule()
            {
                PublicSchedule = publicScheduleData,
                PublicScheduleSize = FileUpload.UploadPublicSchedule.Length,
                Title = FileUpload.Title,
                UploadDT = DateTime.UtcNow
            };


            return RedirectToPage("./Index");
        }
    }
}