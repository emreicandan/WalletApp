using System;
using Core.Repository;

namespace Entities.Models;

public class Category:Entity<Guid>
{
    public string Name { get; set; }
    public string Type { get; set; }
}

