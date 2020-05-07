using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class rootController :Controller
    {
       [HttpGet]
       public ActionResult root()
       {
          return View();
       }

       [HttpPost]
       public ActionResult root (string firstnumber , string secondnumber)
       {   
           double numberone = double.Parse(firstnumber);
           double numbertwo = double.Parse(secondnumber);
           if (numberone == numbertwo){
              string result = "The square roots are the same, enter another value";
              ViewBag.Result = result;
              }
           else{    double squarerootone = Math.Sqrt(numberone);
                    double squareroottwo = Math.Sqrt(numbertwo);
                    if (squarerootone > squareroottwo){
                    double result = numberone;
                    ViewBag.Result = "The number with higher square root is "+result;}
                    else if(numbertwo < 1 || numberone < 1 ){
                       string result = "Invalid number input, enter another value";
                       ViewBag.Result = result;
                    }
                    else{
                        double result = numbertwo;
                       ViewBag.Result = "The number with higher square root is "+result;}   
               }
           return View();
       }
           
   }
}
