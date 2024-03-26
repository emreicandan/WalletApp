using System;
namespace Core.Repository;

public abstract class Entity
{
}

public abstract class Entity<PKey>:Entity
{
    public PKey Id { get; set; }
}