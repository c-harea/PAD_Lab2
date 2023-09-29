using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Models
{
    public abstract class DbDocument
    {
        public Guid Id { get; set; }
        public DateTime LastChangedAt { get; set; }

    }
}
