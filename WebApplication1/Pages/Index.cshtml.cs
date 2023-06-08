using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=ServerName;" +
              "Initial Catalog=DataBaseName;" +
              "User id=UserName;" +
              "Password=Secret;";
            conn.Open();
        }
    }
}
