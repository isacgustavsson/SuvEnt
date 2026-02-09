using Microsoft.AspNetCore.Mvc;
using EventUI.Models;
using EventCore.Interfaces;
using EventCore.Entities;

namespace EventUI.Controllers;

public class EventController(IEventRepository repo) : Controller
{
    //TODO replace repository with service
    private readonly IEventRepository _repo = repo;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateEventViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        Event eventToAdd = new
        (
            model.Name,
            model.Description,
            model.StartDateTime,
            model.EndDateTime,
            model.Location,
            model.MaxParticipants
        );

        _repo.Add(eventToAdd);

        return RedirectToAction("Index");
    }
}