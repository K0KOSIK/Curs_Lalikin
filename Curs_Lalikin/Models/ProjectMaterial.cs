using System;
using System.Collections.Generic;

namespace Curs_Lalikin.Models;

public partial class ProjectMaterial
{
    public int ProjectId { get; set; }

    public int MaterialId { get; set; }

    public decimal Quantity { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
