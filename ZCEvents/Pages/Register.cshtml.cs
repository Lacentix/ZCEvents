using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Add this namespace for List

namespace ZCEvents.Pages;

public class RegisterModel : PageModel
{
    private readonly ILogger<RegisterModel> _logger;

    public RegisterModel(ILogger<RegisterModel> logger)
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

    [BindProperty] public string name { get; set; }

    [BindProperty] public string phone { get; set; }

    [BindProperty] public string ConfirmPassword { get; set; }

    public void OnGet()
    {
    }


    public IActionResult OnPost()
    {
        var ConString = @"Data Source=DESKTOP-0TH5VGS\SQLEXPRESS;Initial Catalog=DB project;Integrated Security=True";

        using (var con = new SqlConnection(ConString))
        {
            if (Role == "customer" && Password == ConfirmPassword)
            {
                var querystring =
                    "INSERT INTO Customers(CustomerID, customerName, customerEmail, password, customerContactNumber) VALUES (@generatedID, @name, @email, @password,  @phone)";

                try
                {
                    var min = 10000;
                    var max = 99999;
                    var random = new Random();
                    var customerID = random.Next(min, max);
                    var orderID = random.Next(min, max);
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@generatedID", customerID);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    var rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
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

            if (Role == "seller" && Password == ConfirmPassword)
            {
                var querystring =
                    "INSERT INTO Sellers(sellerID, sellerName, sellerEmail, passwordSeller, sellerContactNumber) VALUES (@generatedID, @name, @email, @password, @phone)";

                try
                {
                    var min = 10000;
                    var max = 99999;
                    var random = new Random();
                    var sellerID = random.Next(min, max);
                    con.Open();
                    var cmd = new SqlCommand(querystring, con);
                    cmd.Parameters.AddWithValue("@generatedID", sellerID.ToString());
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    var rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
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