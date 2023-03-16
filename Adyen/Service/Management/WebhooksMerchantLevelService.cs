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
    public class WebhooksMerchantLevelService : AbstractService
    {
        private readonly string _baseUrl;
        
        public WebhooksMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = client.Config.ManagementEndpoint + "/" + ClientConfig.ManagementVersion;
        }
    
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public void RemoveWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            RemoveWebhookAsync(merchantId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        public async Task RemoveWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"));
        }

        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ListWebhooksResponse</returns>
        public ListWebhooksResponse ListAllWebhooks(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListAllWebhooksAsync(merchantId, pageNumber, pageSize, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="pageNumber">The number of the page to fetch.</param>
        /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ListWebhooksResponse</returns>
        public async Task<ListWebhooksResponse> ListAllWebhooksAsync(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListWebhooksResponse>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook GetWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return GetWebhookAsync(merchantId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> GetWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(null, requestOptions, new HttpMethod("GET"));
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook UpdateWebhook(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return UpdateWebhookAsync(merchantId, webhookId, updateMerchantWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> UpdateWebhookAsync(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(updateMerchantWebhookRequest.ToJson(), requestOptions, new HttpMethod("PATCH"));
        }

        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Webhook</returns>
        public Webhook SetUpWebhook(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return SetUpWebhookAsync(merchantId, createMerchantWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Webhook</returns>
        public async Task<Webhook> SetUpWebhookAsync(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(createMerchantWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GenerateHmacKeyResponse</returns>
        public GenerateHmacKeyResponse GenerateHmacKey(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return GenerateHmacKeyAsync(merchantId, webhookId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GenerateHmacKeyResponse</returns>
        public async Task<GenerateHmacKeyResponse> GenerateHmacKeyAsync(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}/generateHmac";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GenerateHmacKeyResponse>(null, requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TestWebhookResponse</returns>
        public TestWebhookResponse TestWebhook(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default)
        {
            return TestWebhookAsync(merchantId, webhookId, testWebhookRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TestWebhookResponse</returns>
        public async Task<TestWebhookResponse> TestWebhookAsync(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}/test";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TestWebhookResponse>(testWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
