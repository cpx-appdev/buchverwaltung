using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace WebApplication.EventStorage
{
    public class EventStore : IEventStorage
    {
        private static readonly List<BuchEvent> _events = new List<BuchEvent>();

        public void EventHinzufügen(BuchEvent @event)
        {
            _events.Add(@event);
        }

        public BuchEvent[] LadeAlleEvents()
        {
            return _events.ToArray();
        }

        public BuchEvent[] LadeEventsByBuchId(Guid buchId)
        {
            return _events.Where(x => x.BuchId == buchId).ToArray();
        }
    }

    public class EventStoreTests
    {
        [Fact]
        public void Events_werden_hinzugefügt()
        {
            // Arrange
            var eventStore = new EventStore();
            var @event = new AngelegtEvent();

            // Act
            eventStore.EventHinzufügen(@event);

            // Assert
            eventStore.LadeAlleEvents().ShouldContain(@event);
        }

        [Fact]
        public void Sollte_alle_Events_zurückgeben()
        {
            // Arrange
            var eventStore = new EventStore();
            var @event = new AngelegtEvent();
            eventStore.EventHinzufügen(@event);
            eventStore.EventHinzufügen(@event);

            // Act
            var events = eventStore.LadeAlleEvents();

            // Assert
            events.ShouldNotBeNull();
            events.Length.ShouldBe(2);
        }

        [Fact]
        public void Sollte_Event_bei_BuchId_zurückgeben()
        {
            // Arrange
            var eventStore = new EventStore();
            var buchId = Guid.NewGuid();
            var @event = new AngelegtEvent {BuchId = buchId};
            eventStore.EventHinzufügen(@event);

            // Act
            var events = eventStore.LadeEventsByBuchId(buchId);

            // Assert
            events.ShouldNotBeNull();
            events.Length.ShouldBe(1);
            events[0].ShouldBe(@event);
        }
    }
}