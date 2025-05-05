using System;
using System.Collections.Generic;

namespace DraftAboutReserveEngineer.Models;

public partial class Asset
{
    public int Id { get; set; }

    public DateOnly? PawnDate { get; set; }

    public string VehicleNumber { get; set; } = null!;

    public int? PawnPrice { get; set; }

    public string? PhoneNumber { get; set; }

    public string? StorageLocation { get; set; }

    public string? FullName { get; set; }

    public string? Brand { get; set; }

    public int? PawnedDays { get; set; }
}
