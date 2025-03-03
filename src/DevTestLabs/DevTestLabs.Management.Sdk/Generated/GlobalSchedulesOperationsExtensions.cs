// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GlobalSchedulesOperations
    /// </summary>
    public static partial class GlobalSchedulesOperationsExtensions
    {
        /// <summary>
        /// List schedules in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListBySubscription(this IGlobalSchedulesOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>))
        {
                return ((IGlobalSchedulesOperations)operations).ListBySubscriptionAsync(odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListBySubscriptionAsync(this IGlobalSchedulesOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List schedules in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListByResourceGroup(this IGlobalSchedulesOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>))
        {
                return ((IGlobalSchedulesOperations)operations).ListByResourceGroupAsync(odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListByResourceGroupAsync(this IGlobalSchedulesOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: &#39;properties($select=status)&#39;
        /// </param>
        public static Schedule Get(this IGlobalSchedulesOperations operations, string name, string expand = default(string))
        {
                return ((IGlobalSchedulesOperations)operations).GetAsync(name, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: &#39;properties($select=status)&#39;
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> GetAsync(this IGlobalSchedulesOperations operations, string name, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(name, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create or replace an existing schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static Schedule CreateOrUpdate(this IGlobalSchedulesOperations operations, string name, Schedule schedule)
        {
                return ((IGlobalSchedulesOperations)operations).CreateOrUpdateAsync(name, schedule).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> CreateOrUpdateAsync(this IGlobalSchedulesOperations operations, string name, Schedule schedule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(name, schedule, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void Delete(this IGlobalSchedulesOperations operations, string name)
        {
                ((IGlobalSchedulesOperations)operations).DeleteAsync(name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IGlobalSchedulesOperations operations, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Modify properties of schedules.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static Schedule Update(this IGlobalSchedulesOperations operations, string name, ScheduleFragment schedule)
        {
                return ((IGlobalSchedulesOperations)operations).UpdateAsync(name, schedule).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify properties of schedules.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> UpdateAsync(this IGlobalSchedulesOperations operations, string name, ScheduleFragment schedule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(name, schedule, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void Execute(this IGlobalSchedulesOperations operations, string name)
        {
                ((IGlobalSchedulesOperations)operations).ExecuteAsync(name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task ExecuteAsync(this IGlobalSchedulesOperations operations, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.ExecuteWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Updates a schedule&#39;s target resource Id. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void Retarget(this IGlobalSchedulesOperations operations, string name, RetargetScheduleProperties retargetScheduleProperties)
        {
                ((IGlobalSchedulesOperations)operations).RetargetAsync(name, retargetScheduleProperties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates a schedule&#39;s target resource Id. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task RetargetAsync(this IGlobalSchedulesOperations operations, string name, RetargetScheduleProperties retargetScheduleProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.RetargetWithHttpMessagesAsync(name, retargetScheduleProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void BeginExecute(this IGlobalSchedulesOperations operations, string name)
        {
                ((IGlobalSchedulesOperations)operations).BeginExecuteAsync(name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginExecuteAsync(this IGlobalSchedulesOperations operations, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginExecuteWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Updates a schedule&#39;s target resource Id. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void BeginRetarget(this IGlobalSchedulesOperations operations, string name, RetargetScheduleProperties retargetScheduleProperties)
        {
                ((IGlobalSchedulesOperations)operations).BeginRetargetAsync(name, retargetScheduleProperties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates a schedule&#39;s target resource Id. This operation can take a while to
        /// complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginRetargetAsync(this IGlobalSchedulesOperations operations, string name, RetargetScheduleProperties retargetScheduleProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginRetargetWithHttpMessagesAsync(name, retargetScheduleProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// List schedules in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListBySubscriptionNext(this IGlobalSchedulesOperations operations, string nextPageLink)
        {
                return ((IGlobalSchedulesOperations)operations).ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListBySubscriptionNextAsync(this IGlobalSchedulesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List schedules in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListByResourceGroupNext(this IGlobalSchedulesOperations operations, string nextPageLink)
        {
                return ((IGlobalSchedulesOperations)operations).ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListByResourceGroupNextAsync(this IGlobalSchedulesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
