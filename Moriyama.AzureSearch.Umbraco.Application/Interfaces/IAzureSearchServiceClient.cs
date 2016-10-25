﻿using Microsoft.Azure.Search.Models;
using Moriyama.AzureSearch.Umbraco.Application.Models;

namespace Moriyama.AzureSearch.Umbraco.Application.Interfaces
{
    public interface IAzureSearchServiceClient
    {
        AzureSearchConfig GetConfiguration();

        Field[] GetStandardUmbracoFields();
        Index[] GetSearchIndexes();

        string DropCreateIndex();
        
        AzureSearchReindexStatus ReIndexContent(string sessionId);
        AzureSearchReindexStatus ReIndexContent(string sessionId, int page);
    }
}
