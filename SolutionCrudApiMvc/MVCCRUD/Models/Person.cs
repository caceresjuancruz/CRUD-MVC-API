using System;
using System.Collections.Generic;

namespace MVCCRUD.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public DateTime Date { get; set; }

    public string Password { get; set; } = null!;
}
