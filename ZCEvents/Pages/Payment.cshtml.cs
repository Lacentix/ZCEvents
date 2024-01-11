using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZCEvents.Pages;

public class PaymentModel : PageModel
{
    public void OnGet()
    {
    }

    public IActionResult OnPost(string submitType)
    {
        if (submitType == "submit")
            return RedirectToPage("/Index");
        return Page();
    }
}