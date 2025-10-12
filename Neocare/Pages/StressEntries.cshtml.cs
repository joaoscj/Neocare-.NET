using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Neocare.Application.DTOs;
using Neocare.Application.Services;

namespace Neocare.Pages
{
    public class StressEntriesModel : PageModel
    {
        private readonly StressEntryService _stressEntryService;

        public StressEntriesModel(StressEntryService stressEntryService)
        {
            _stressEntryService = stressEntryService;
        }

        public IEnumerable<StressEntryDto> StressEntries { get; set; } = Array.Empty<StressEntryDto>();

        public async Task OnGetAsync()
        {
            StressEntries = await _stressEntryService.GetAllAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(Guid id)
        {
            await _stressEntryService.DeleteAsync(id);
            return RedirectToPage();
        }
    }
}