using System;
using System.Collections.Generic;

namespace Kuarasy.Models.Entidades
{
    public abstract class EntidadeBase
    {
        public string Id { get; set; }

        public EntidadeBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

}