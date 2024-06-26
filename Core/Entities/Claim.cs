﻿using System;
using Core.Repository;

namespace Core.Entities;

public class Claim:Entity<Guid>
{
    public string Group { get; set; }
    public string Name { get; set; }
    public virtual UserClaim UserClaim { get; set; }
}

