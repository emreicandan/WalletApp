using System;
using Core.Repository;

namespace Entities.Models;

public class Currency:Entity<Guid>
{
    public string Name { get; set; }
}

