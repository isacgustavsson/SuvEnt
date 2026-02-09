using Microsoft.AspNetCore.Mvc;
using EventCore.DTOs;
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

    public IActionResult Create(CreateEventDto dto)
    {
        if (!ModelState.IsValid)
        {
            return View(dto);
        }

        Event eventToAdd = new
        (
            dto.Name,
            dto.Description,
            dto.StartDateTime,
            dto.EndDateTime,
            dto.Location,
            dto.MaxParticipants
        );

        _repo.Add(eventToAdd);

        return View();
    }
}