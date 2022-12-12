// access ASP.Net Core's built-in controller class
using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  // extends or inherits functionality from Asp.Net Core's built-in controller class
  public class HomeController : Controller
  {
    // route (routes are URL path) example: www.learnhowtoprogram.com/home/hello
    // /home = HomeController /hello = Hello()
    [Route("/hello")] // route decorator specifics a route we define. no /home/hello just our route /hello
    public string Hello() { return "Hello friend!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    [Route("/")] // "/" is our ROOT PATH or home page
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable); 
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    } 
  }
}