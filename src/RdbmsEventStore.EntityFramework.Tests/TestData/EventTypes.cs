﻿using System;

namespace RdbmsEventStore.EntityFramework.Tests.TestData
{
    public class GuidEvent : Event<Guid> { }
    public class GuidGuidPersistedEvent : EntityFrameworkEvent<Guid, Guid> { }
    public class StringEvent : Event<string> { }
    public class LongStringPersistedEvent : EntityFrameworkEvent<long, string> { }
    public class LongEvent : Event<long> { }
    public class LongLongPersistedEvent : EntityFrameworkEvent<long, long> { }

    public interface IExtraMeta : IEventMetadata<string>
    {
        string ExtraMeta { get; set; }
    }

    public class ExtraMetaStringEvent : Event<string>, IExtraMeta
    {
        public string ExtraMeta { get; set; }
    }

    public class ExtraMetaLongStringPersistedEventMetadata : EntityFrameworkEvent<long, string>, IExtraMeta
    {
        public string ExtraMeta { get; set; }
    }

    public class FooEvent
    {
        public string Foo { get; set; }
    }

    public class BarEvent
    {
        public string Bar { get; set; }
    }
}