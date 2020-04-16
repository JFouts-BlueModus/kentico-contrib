using CMS.DocumentEngine;

namespace Meeg.Kentico.ContentComponents.Cms
{
    /// <summary>
    /// This class can be used to deserialise Page Type Component data that has been serialised.
    /// </summary>
    public interface IPageTypeDeserializer
    {
        /// <summary>
        /// Deserialises Page Type Component and returns a new TreeNode instance containing component data.
        /// </summary>
        /// <param name="pageType">The full class name of the component Page Type.</param>
        /// <param name="componentSerialized">The Page Type Component to deserialise.</param>
        /// <returns>A new TreeNode instance containing the deserialised component data.</returns>
        TreeNode Deserialize(string pageType, string componentSerialized);

        /// <summary>
        /// Deserialises Page Type Component and returns a new TreeNode instance of type T containing component data.
        /// </summary>
        /// <typeparam name="T">A type representing the Page Type of the component.</typeparam>
        /// <param name="componentSerialized">The Page Type Component to deserialise.</param>
        /// <returns>A new TreeNode instance of Type T containing the deserialised component data.</returns>
        T Deserialize<T>(string componentSerialized) where T : TreeNode, new();
    }
}
