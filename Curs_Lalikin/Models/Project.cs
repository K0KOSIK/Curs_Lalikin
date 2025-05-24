using System;
using System.Collections.Generic;

namespace Curs_Lalikin.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public DateOnly StartDate { get; set; } 

    public DateOnly? EndDate { get; set; }

    public decimal Budget { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<ProjectMaterial> ProjectMaterials { get; set; } = new List<ProjectMaterial>();
}
