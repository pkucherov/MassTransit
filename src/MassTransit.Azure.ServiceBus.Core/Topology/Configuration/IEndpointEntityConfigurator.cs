// Copyright 2007-2017 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Azure.ServiceBus.Core.Topology.Configuration
{
    using System;


    public interface IEndpointEntityConfigurator :
        IEntityConfigurator
    {
        /// <summary>
        /// Specify the lock duration for messages read from the queue
        /// </summary>
        TimeSpan? LockDuration { set; }

        /// <summary>
        /// Sets the maximum delivery count. A message is automatically deadlettered after this number of deliveries.
        /// </summary>
        int? MaxDeliveryCount { set; }

        /// <summary>
        /// Sets the subscription in session mode, requiring a session for inbound messages
        /// </summary>
        bool? RequiresSession { set; }

        /// <summary>
        /// Move messages to the dead letter queue on expiration (time to live exceeded)
        /// </summary>
        bool? EnableDeadLetteringOnMessageExpiration { set; }

        /// <summary>
        /// Sets the path to the recipient to which the dead lettered message is forwarded.
        /// </summary>
        string ForwardDeadLetteredMessagesTo { set; }
    }
}