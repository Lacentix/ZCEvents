using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZCEvents.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    // Add the ReturnUrl property
    [BindProperty(SupportsGet = true)] public string ReturnUrl { get; set; }

    // Add the ExternalLogins property
    public List<ExternalLogin> ExternalLogins { get; set; }

    [BindProperty] public string Email { get; set; }

    [BindProperty] public string Password { get; set; }

    [BindProperty] public string Role { get; set; }

    public void OnGet()
    {
    }


    public IActionResult OnPost()
    {
        var ConString = @"Data Source=DESKTOP-0TH5VGS\SQLEXPRESS;Initial Catalog=DB project;Integrated Security=True";

        using (var con = new SqlConnection(ConString))
        {
            if (Role == "Customer")
            {
                var querystring =
                    "SELECT customerEmail, password FROM Customers WHERE customerEmail = @inputEmail AND password = @inputPassword";

                try
                {
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@inputEmail", Email);
                    cmd.Parameters.AddWithValue("@inputPassword", Password);

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        return RedirectToPage("/products");
                    // Handle invalid credentials or redirect to a specific page
                    return Page(); // Or return a specific error page
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions (log the error, redirect to an error page, etc.)
                    Console.WriteLine(ex.ToString());
                    return RedirectToPage("/Error"); // Redirect to an error page
                }
            }

            if (Role == "Seller")
            {
                var querystring =
                    "SELECT sellerEmail, passwordSeller FROM Sellers WHERE sellerEmail = @inputEmail AND passwordSeller = @inputPassword";

                try
                {
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@inputEmail", Email);
                    cmd.Parameters.AddWithValue("@inputPassword", Password);

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        return RedirectToPage("/Sellers");
                    // Handle invalid credentials or redirect to a specific page
                    return Page(); // Or return a specific error page
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions (log the error, redirect to an error page, etc.)
                    Console.WriteLine(ex.ToString());
                    return RedirectToPage("/Error"); // Redirect to an error page
                }
            }

            if (Role == "Employee")
            {
                var querystring =
                    "SELECT Email, password FROM Employee WHERE Email = @inputEmail AND password = @inputPassword";

                try
                {
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@inputEmail", Email);
                    cmd.Parameters.AddWithValue("@inputPassword", Password);

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        return RedirectToPage("/Employees");
                    // Handle invalid credentials or redirect to a specific page
                    return Page(); // Or return a specific error page
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions (log the error, redirect to an error page, etc.)
                    Console.WriteLine(ex.ToString());
                    return RedirectToPage("/Error"); // Redirect to an error page
                }
            }

            if (Role == "Admin")
            {
                var querystring =
                    "SELECT adminEmail, adminPassword FROM Administrators WHERE adminEmail = @inputEmail AND adminPassword = @inputPassword";

                try
                {
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@inputEmail", Email);
                    cmd.Parameters.AddWithValue("@inputPassword", Password);

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        return RedirectToPage("/Customer");
                    // Handle invalid credentials or redirect to a specific page
                    return Page(); // Or return a specific error page
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions (log the error, redirect to an error page, etc.)
                    Console.WriteLine(ex.ToString());
                    return RedirectToPage("/Error"); // Redirect to an error page
                }
            }

            return Page();
        }
    }

    public class ExternalLogin
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }

        // Additional properties or methods as needed
    }
}