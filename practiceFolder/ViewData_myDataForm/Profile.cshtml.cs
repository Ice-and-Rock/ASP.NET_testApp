using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ProfileModel : PageModel
  {
    public void OnGet()

    // The following ViewData can be transfered to the ViewPage ✅
    {
      ViewData["myName"] = "N Vale";
      ViewData["username"] = "NV";
      ViewData["myOccupation"] = "Engineer";
      ViewData["myAge"] = 33;
      ViewData["currentDate"] = "02/08/24";
    }
  }
}
