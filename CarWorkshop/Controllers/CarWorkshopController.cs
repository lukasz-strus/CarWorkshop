﻿using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using CarWorkshop.Application.CarWorkshop.Queries.CreateCarWorkshop;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers;

public class CarWorkshopController : Controller
{
    private readonly IMediator _mediator;

    public CarWorkshopController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<ActionResult> Index()
    {
        var carWorkshops = await _mediator.Send(new GetAllCarWorkshopQuery());

        return View(carWorkshops);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCarWorkshopCommand command)
    {
        if (!ModelState.IsValid)
        {
            return View(command);
        }

        await _mediator.Send(command);

        return RedirectToAction(nameof(Index));
    }
}