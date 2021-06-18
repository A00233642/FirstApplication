using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApplication.Pages
{
    public class introModel : PageModel
    {
        public void OnGet()
        {
            if (firstValue > 0 && secondValue > 0)
            {
                nResult = firstValue * secondValue;
                Resultset = true;
            }
        }

        [FromQuery(Name = "firstvalue")]

        public int firstValue { get; set; }

        [FromQuery(Name = "secondvalue")]

        public int secondValue { get; set; }

        public int nResult { get; set; }

        public bool Resultset { get; set; }
    }
    }

