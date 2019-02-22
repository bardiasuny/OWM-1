using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OWM.Application.Services;
using OWM.Application.Services.Interfaces;

namespace OWM.UI.Web.Pages.User
{
    public class CreateTeamModel : PageModel
    {
        private readonly IOccupationInformationService _ocpInformationService;
        public List<SelectListItem> OccupationOptions;

        public CreateTeamModel(IOccupationInformationService ocpInformationService)
        {
            _ocpInformationService = ocpInformationService;
            OccupationOptions = new List<SelectListItem>();
        }

        public void OnGet()
        {
            FillOccupationDropdown();
        }
        public void FillOccupationDropdown()
        {
            OccupationOptions = _ocpInformationService.GetOccupations().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id + ""
            }).ToList().Result;
        }
    }
}