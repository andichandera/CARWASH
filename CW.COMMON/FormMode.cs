using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.Common
{
    public enum FormMode
    {
        New = 1,
        Update = 2,
        View = 3,
    }

    public enum EntityState
    {
        None,
        New,
        Update,
        Delete
    }
}
