using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary
{
    /// <remarks/>
    public class LockedPeriodConnector : EntityConnector<LockedPeriod, LockedPeriod, Sort.By.LockedPeriod>
    {
        /// <remarks/>
        public LockedPeriodConnector()
        {
            base.Resource = "settings/lockedperiod";
        }

        /// <summary>
        /// Gets the locked period setting
        /// </summary>
        /// <returns>The locked period setting</returns>
        public LockedPeriod Get()
        {
            return base.BaseFind();
        }

        public override IDummyInterface Find()
        {
            throw new NotImplementedException("This connector does not support Find");
        }
    }
}
