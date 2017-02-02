using Shouldly;
using Xunit;

namespace WebApplication.EventStorage
{
    public class EventStore
    {
        public void EventHinzufügen(AngelegtEvent @event)
        {
            throw new System.NotImplementedException();
        }

        public BuchEvent[] LadeAlleEvents()
        {
            throw new System.NotImplementedException();
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
    }
}