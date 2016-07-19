using Nancy;
using System.Collections.Generic;


namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomModule() {
      Get["/"] = _ => {
        return View["/index.cshtml"];

        
      }
    }
  }
}
