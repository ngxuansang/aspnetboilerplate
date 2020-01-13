﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Abp.WebHooks
{
    /// <summary>
    /// Store created web hooks. To see who get that webhook check with <see cref="WebhookSendAttempt.WebHookId"/> and you can get <see cref="WebhookSendAttempt.WebHookSubscriptionId"/>
    /// </summary>
    [Table("AbpWebHooks")]
    public class WebHookInfo : Entity<Guid>, IMayHaveTenant, IHasCreationTime, ISoftDelete, IHasDeletionTime
    {
        /// <summary>
        /// Webhook unique name id
        /// </summary>
        public string WebHookDefinition { get; set; }

        /// <summary>
        /// WebHook data as JSON string.
        /// </summary>
        public string Data { get; set; }

        public DateTime CreationTime { get; set; }

        public int? TenantId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }
    }
}
