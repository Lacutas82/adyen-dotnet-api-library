/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TerminalActionsTerminalLevelService : AbstractService
    {
        private readonly string _baseUrl;
        
        public TerminalActionsTerminalLevelService(Client client) : base(client)
        {
            _baseUrl = client.Config.ManagementEndpoint + "/" + ClientConfig.ManagementVersion;
        }
    
        /// <summary>
        /// Create a terminal action
        /// </summary>
        /// <param name="scheduleTerminalActionsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ScheduleTerminalActionsResponse</returns>
        public ScheduleTerminalActionsResponse CreateTerminalAction(ScheduleTerminalActionsRequest scheduleTerminalActionsRequest, RequestOptions requestOptions = default)
        {
            return CreateTerminalActionAsync(scheduleTerminalActionsRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a terminal action
        /// </summary>
        /// <param name="scheduleTerminalActionsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ScheduleTerminalActionsResponse</returns>
        public async Task<ScheduleTerminalActionsResponse> CreateTerminalActionAsync(ScheduleTerminalActionsRequest scheduleTerminalActionsRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/terminals/scheduleActions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ScheduleTerminalActionsResponse>(scheduleTerminalActionsRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
