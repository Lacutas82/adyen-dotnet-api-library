/*
* Adyen Recurring API
*
*
* The version of the OpenAPI document: 68
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Model.Recurring;

namespace Adyen.Service
{
    /// <summary>
    /// DefaultService Interface
    /// </summary>
    public interface IRecurringService
    {
        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"><see cref="CreatePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreatePermitResult"/>.</returns>
        Model.Recurring.CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create new permits linked to a recurring contract.
        /// </summary>
        /// <param name="createPermitRequest"><see cref="CreatePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreatePermitResult"/>.</returns>
        Task<Model.Recurring.CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"><see cref="DisableRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DisableResult"/>.</returns>
        Model.Recurring.DisableResult Disable(DisableRequest disableRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Disable stored payment details
        /// </summary>
        /// <param name="disableRequest"><see cref="DisableRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DisableResult"/>.</returns>
        Task<Model.Recurring.DisableResult> DisableAsync(DisableRequest disableRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"><see cref="DisablePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DisablePermitResult"/>.</returns>
        Model.Recurring.DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Disable an existing permit.
        /// </summary>
        /// <param name="disablePermitRequest"><see cref="DisablePermitRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DisablePermitResult"/>.</returns>
        Task<Model.Recurring.DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"><see cref="RecurringDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="RecurringDetailsResult"/>.</returns>
        Model.Recurring.RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest recurringDetailsRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get stored payment details
        /// </summary>
        /// <param name="recurringDetailsRequest"><see cref="RecurringDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="RecurringDetailsResult"/>.</returns>
        Task<Model.Recurring.RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"><see cref="NotifyShopperRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="NotifyShopperResult"/>.</returns>
        Model.Recurring.NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Ask issuer to notify the shopper
        /// </summary>
        /// <param name="notifyShopperRequest"><see cref="NotifyShopperRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="NotifyShopperResult"/>.</returns>
        Task<Model.Recurring.NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"><see cref="ScheduleAccountUpdaterRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ScheduleAccountUpdaterResult"/>.</returns>
        Model.Recurring.ScheduleAccountUpdaterResult ScheduleAccountUpdater(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Schedule running the Account Updater
        /// </summary>
        /// <param name="scheduleAccountUpdaterRequest"><see cref="ScheduleAccountUpdaterRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ScheduleAccountUpdaterResult"/>.</returns>
        Task<Model.Recurring.ScheduleAccountUpdaterResult> ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the RecurringService API endpoints
    /// </summary>
    public class RecurringService : AbstractService, IRecurringService
    {
        private readonly string _baseUrl;
        
        public RecurringService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/Recurring/v68");
        }
        
        public Model.Recurring.CreatePermitResult CreatePermit(CreatePermitRequest createPermitRequest = default, RequestOptions requestOptions = default)
        {
            return CreatePermitAsync(createPermitRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.CreatePermitResult> CreatePermitAsync(CreatePermitRequest createPermitRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/createPermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.CreatePermitResult>(createPermitRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Recurring.DisableResult Disable(DisableRequest disableRequest = default, RequestOptions requestOptions = default)
        {
            return DisableAsync(disableRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.DisableResult> DisableAsync(DisableRequest disableRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/disable";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.DisableResult>(disableRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Recurring.DisablePermitResult DisablePermit(DisablePermitRequest disablePermitRequest = default, RequestOptions requestOptions = default)
        {
            return DisablePermitAsync(disablePermitRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.DisablePermitResult> DisablePermitAsync(DisablePermitRequest disablePermitRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/disablePermit";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.DisablePermitResult>(disablePermitRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Recurring.RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest recurringDetailsRequest = default, RequestOptions requestOptions = default)
        {
            return ListRecurringDetailsAsync(recurringDetailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.RecurringDetailsResult> ListRecurringDetailsAsync(RecurringDetailsRequest recurringDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/listRecurringDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.RecurringDetailsResult>(recurringDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Recurring.NotifyShopperResult NotifyShopper(NotifyShopperRequest notifyShopperRequest = default, RequestOptions requestOptions = default)
        {
            return NotifyShopperAsync(notifyShopperRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.NotifyShopperResult> NotifyShopperAsync(NotifyShopperRequest notifyShopperRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/notifyShopper";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.NotifyShopperResult>(notifyShopperRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Recurring.ScheduleAccountUpdaterResult ScheduleAccountUpdater(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest = default, RequestOptions requestOptions = default)
        {
            return ScheduleAccountUpdaterAsync(scheduleAccountUpdaterRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Recurring.ScheduleAccountUpdaterResult> ScheduleAccountUpdaterAsync(ScheduleAccountUpdaterRequest scheduleAccountUpdaterRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/scheduleAccountUpdater";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Recurring.ScheduleAccountUpdaterResult>(scheduleAccountUpdaterRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}