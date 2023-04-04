﻿using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.Application.CarWorkshop;

public class CarWorkshopDto
{
    [Required(ErrorMessage = "Please insert name")]
    [StringLength(20, MinimumLength = 2)]
    public string Name { get; set; } = default!;

    [Required(ErrorMessage = "Please insert description")]
    public string? Description { get; set; }

    public string? About { get; set; }

    [StringLength(12, MinimumLength = 8)]
    public string? PhoneNumber { get; set; }

    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? EncodedName { get; set; }
}