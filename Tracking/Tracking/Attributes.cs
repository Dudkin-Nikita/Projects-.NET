using System;

namespace Tracking
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public class TrackingEntityAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
    public class TrackingPropertyAttribute : Attribute
    {
        public string PropertyName { get; set; }

        public TrackingPropertyAttribute(string name)
        {
            PropertyName = name;
        }
    }
}
