using Calc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int n1, int n2)
        {
            Nums nums = new Nums();
            nums.Num1 = n1;
            nums.Num2 = n2;
            return View(nums);
        }

        public IActionResult Mul(int n1, int n2)
        {
            Nums nums = new Nums();
            nums.Num1 = n1;
            nums.Num2 = n2;
            return View(nums);
        }

        public IActionResult Div(int n1, int n2)
        {
            Nums nums = new Nums();
            nums.Num1 = n1;
            nums.Num2 = n2;
            return View(nums);
        }

        public IActionResult Sub(int n1, int n2)
        {
            Nums nums = new Nums();
            nums.Num1 = n1;
            nums.Num2 = n2;
            return View(nums);
        }
    }
}
