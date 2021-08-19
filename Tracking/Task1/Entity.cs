namespace Tracking
{
    [TrackingEntity]
    public class Entity
    {
        [TrackingProperty("MyProperty")]
        public int Number { get; set; }

        [TrackingProperty("MyProperty1")]
        public int number;

        public string fullName;
    }
}
