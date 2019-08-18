using System;
using Microsoft.AspNetCore.Mvc;
namespace ProjeDeneme.Controllers

{
    public class HomeController:Controller
    {
        public IActionResult index(){
            ViewBag.Hi="mustafa";
            int x=DateTime.Now.Hour;
            ViewBag.Time=x <12 ? "Günaydın" : "İyi günler";// eğer x saat 12 den küçükse gün.. değilse iyi g...

            return View();
        }

        public IActionResult about(){
            return View();
        }
    }
}