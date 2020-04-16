namespace Meeg.Kentico.ContentComponents.Cms
{
    /// <summary>
    /// Used to create a serializer/deserializer for a page
    /// </summary>
    public class PageTypeSerializationFactory
    {
        /// <summary>
        /// Create a serializer for a page based on the passed type.
        /// Defaults to XML
        /// </summary>
        public IPageTypeSerializer CreateSerializer(string serializationType)
        {
            if (serializationType == PageTypeSerializationType.Json)
            {
                return new PageTypeComponentJsonSerializer();
            }

            return new PageTypeComponentSerializer();
        }

        /// <summary>
        /// Create a deserializer for a page based on the passed type.
        /// Defaults to XML
        /// </summary>
        public IPageTypeDeserializer CreateDeserializer(string serializationType)
        {
            if (serializationType == PageTypeSerializationType.Json)
            {
                return new PageTypeComponentJsonDeserializer();
            }

            return new PageTypeComponentDeserializer();
        }
    }
}
