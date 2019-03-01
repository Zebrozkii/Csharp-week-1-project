using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
        List<CountWords> allItems = CountWords.GetAll();
        return View(allItems);
    }

    [HttpPost("/items")]
    public ActionResult Create(string sentence, string word)
    {
        CountWords myItem = new CountWords(word,sentence);
        int number = myItem.WordCount();
        return RedirectToAction("Index");
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
        CountWords.ClearAll();
        return View();
    }

    // [HttpGet("/items/{id}")]
    // public ActionResult Show(int id)
    // {
    //     CountWords item = CountWords.Find(id);
    //     return View(item);
    // }

  }
}
