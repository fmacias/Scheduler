﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace fmacias.Components.EventAggregator
{
    public class ProcessEventSubscriptor: EventSubscriptorAbstract
    {
        /// <summary>
        /// Default event name of IProccessEvent Object
        /// </summary>
        private const string EVENT_NAME = "Event";
        public ProcessEventSubscriptor(IEventSubscriptable eventAggregator,IProcessEvent processEvent):base(eventAggregator)
        {           
            if (processEvent.GetType().GetEvent(EVENT_NAME) == null)
                throw new EventAggregatorException(
                    string.Format("Object Type {0} is not subscriptable for event {1}.", typeof(IProcessEvent).ToString(), "Event")
                );
            this.triegger = processEvent;
            this.eventName = EVENT_NAME;
        }
    }
}
