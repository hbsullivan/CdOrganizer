using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class RecordController : Controller
  {

    [HttpGet("/records")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetAll();
      return View(allRecords);
    }

    [HttpGet("records/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/records")]
    public ActionResult Create(string recordTitle)
    {
      Record newRecord = new Record(recordTitle);
      return RedirectToAction("Index");
    }
  }
}