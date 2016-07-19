using Nancy;
using System.Collections.Generic;


namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/anagram_generated"] = _ =>
      {
        List<string> inputWords = new List<string>() {Request.Form["anagram1"], Request.Form["anagram2"], Request.Form["anagram3"], Request.Form["anagram4"], Request.Form["anagram5"],};
        Anagram newAnagram = new Anagram() {};
        List<string> results = new List<string>() {};
        results = newAnagram.IsAnagramMultipleWords(inputWords);
        return View["anagram_generated.cshtml", results];
      };

      Post["/partial_anagram_generated"] = _ =>
      {
        string results;
        Anagram newAnagram = new Anagram() {};
        if (newAnagram.IsAnagramPartial(Request.Form["partial1"], Request.Form["partial2"]))
        {
          results = "true";
        }
        else
        {
          results = "false";
        }
        return View["/partial_anagram_generated.cshtml", results];
      };
    }
  }
}
