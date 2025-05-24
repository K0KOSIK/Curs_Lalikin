using System;
using System.Collections.Generic;

namespace Curs_Lalikin.Models;

public partial class Material
{
    public int MaterialId { get; set; }

    public string MaterialName { get; set; } = null!;

    public string UnitOfMeasure { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int CategoriesIdCategories { get; set; }

    public virtual Category CategoriesIdCategoriesNavigation { get; set; } = null!;

    public virtual ICollection<ProjectMaterial> ProjectMaterials { get; set; } = new List<ProjectMaterial>();
}
