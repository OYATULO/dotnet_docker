using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fordocker.Pages
{
    public class ContactModel : PageModel
    {
        public string phone { get; set; }

        public int count { get; set; }
        public void OnGet()
        {
          phone = "+79000123123";
        }
        public int GetCount()
        {
            return  count+=2;
        }
        public void check()
        {
            count=10;
        }
    }
}
