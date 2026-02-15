using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PensionSystem.Database;

namespace PensionSystem.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IConfiguration _configuration;
         private readonly AppDBConnection _context;


        public PrivacyModel(ILogger<PrivacyModel> logger,IConfiguration configuration, AppDBConnection appDBConnection)
        {
            _logger = logger;
            _configuration = configuration;
            _context = appDBConnection;
        }

        public void OnGet()
        {
            ViewData["Value"] = _configuration["DefaultValue"].ToString();

            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
            _context.Add(person);
           _context.SaveChanges();
        }
    }

}
