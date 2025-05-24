using System;
using System.Collections.Generic;

namespace Curs_Lalikin.Models;

public partial class Category
{
    public int IdCategories { get; set; }

    public string CategoriesName { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
