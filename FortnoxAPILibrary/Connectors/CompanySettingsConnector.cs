using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary
{
    /// <remarks />
    public class CompanySettingsConnector : EntityConnector<CompanySettings, CompanySettings, Sort.By.CompanySettings>
    {
        /// <remarks />
        public CompanySettingsConnector()
        {
            base.Resource = "settings/company";
        }

        /// <summary>
        /// Gets the company settings
        /// </summary>
        /// <returns>The company settings</returns>
        public CompanySettings Get()
        {
            return base.BaseFind();
        }

        public override IDummyInterface Find()
        {
            throw new NotImplementedException("This connector does not support Find");
        }
    }
}
