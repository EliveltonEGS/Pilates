﻿using System;

namespace Pilates.Model.Entities
{
    public class EntityBase
    {

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
