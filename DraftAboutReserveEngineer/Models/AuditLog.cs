using System;
using System.Collections.Generic;

namespace DraftAboutReserveEngineer.Models;

public partial class AuditLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Action { get; set; } = null!;

    public DateTime DateTime { get; set; }
}
