﻿using System;

namespace FortnoxAPILibrary
{
    public interface IEntityConnector
    {
        Sort.Order SortOrder { get; set; }
        int Limit { get; set; }
        DateTime LastModified { get; set; }
        int Page { get; set; }
        int Offset { get; set; }

        bool HasError { get; }
        FortnoxError.ErrorInformation Error { get; }

        IDummyInterface Find();
    }
}