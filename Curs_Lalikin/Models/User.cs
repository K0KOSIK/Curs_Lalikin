using System;
using System.Collections.Generic;

namespace Curs_Lalikin.Models;

public partial class User
{
    public int Iduser { get; set; }

    public string Password { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Role { get; set; } = null!;
}
