using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary
{
    /// <remarks/>
    public class LockedPeriod : IDummyInterface
    {
        /// <remarks/>
        [ReadOnly(true)]
        public string EndDate { get; set; }
    }
}
