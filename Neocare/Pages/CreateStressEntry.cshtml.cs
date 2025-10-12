using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Neocare.Application.DTOs;
using Neocare.Application.Services;

namespace Neocare.Pages
{
    public class CreateStressEntryModel : PageModel
    {
        private readonly StressEntryService _stressEntryService;

        public CreateStressEntryModel(StressEntryService stressEntryService)
        {
            _stressEntryService = stressEntryService;
        }

        [BindProperty]
        public CreateStressEntryDto Entry { get; set; } = new();

        [BindProperty]
        public string SymptomsInput { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Entry.Symptoms = SymptomsInput.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
            Entry.UserId = "demo-user"; // In a real app, this would come from authentication

            await _stressEntryService.CreateAsync(Entry);
            return RedirectToPage("./StressEntries");
        }
    }
}