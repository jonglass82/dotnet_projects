using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet_projects.Pages
{
    public class CalculatorModel : PageModel
    {
        public float Val1 { get; set; }
        public float Val2 { get; set; }
        public string Operator { get; set; }
        public string Result { get; set; }

        public void OnGet()
        {
            Console.WriteLine("Hello from the Calculator Model");
            //Val1 = 0;
            //Val2 = 0;
            //Operator = String.Empty;
            //Result = "0";
            Operator = String.Empty;

        }

        public ActionResult OnPostCalculate()
        {
            if (HttpContext.Request.Form["Val1"] == "" || HttpContext.Request.Form["Val2"] == "" || HttpContext.Request.Form["Operator"] == "")
            {
                //Val1 = 0;
                //Val2 = 0;
                //Operator = "";
                Result = "0";
                return Page();
            }
            else
            {

                if (HttpContext.Request.Form["Val1"] == "")
                {
                    Val1 = float.Parse(Result);
                }
                else
                {
                    Val1 = float.Parse(HttpContext.Request.Form["Val1"]);
                    Val2 = float.Parse(HttpContext.Request.Form["Val2"]);
                    Operator = HttpContext.Request.Form["Operator"];
                }

                switch (Operator)
                {
                    case ("+"):
                        Result = (Val1 + Val2).ToString();
                        break;
                    case ("x"):
                        Result = (Val1 * Val2).ToString();
                        break;
                    case ("/"):
                        Result = (Val1 / Val2).ToString();
                        break;
                    case ("-"):
                        Result = (Val1 - Val2).ToString();
                        break;
                }

                return Page();
            }
        }

        public ActionResult OnPostClear()
        {
            Val1 = 0;
            Val2 = 0;
            Operator = "";
            Result = "0";
            return Page();
        }

    }
}
