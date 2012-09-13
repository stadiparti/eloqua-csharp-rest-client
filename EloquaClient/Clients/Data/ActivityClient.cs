﻿using System;
using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Activities;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Data
{
    public class ActivityClient
    {
        public ActivityClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public List<Activity> Get(int? id, string type, int count, long startDate, long endDate)
        {
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Resource = string.Format("/data/activities/contact/{0}?type={1}&count={2}&startDate={3}&endDate={4}", id, type, count, startDate, endDate) 
            };

            return _baseClient.Execute<List<Activity>>(request);
        }
    }
}
