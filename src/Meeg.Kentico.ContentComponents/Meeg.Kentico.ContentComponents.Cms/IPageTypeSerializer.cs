using CMS.DocumentEngine;

namespace Meeg.Kentico.ContentComponents.Cms
{
    /// <summary>
    /// This class can be used to serialise Page Type Component data.
    /// </summary>
    public interface IPageTypeSerializer
    {
        /// <summary>
        /// Serialises a Page Type Component.
        /// </summary>
        /// <param name="component">The Page Type Component to serialise - can be an instance of any type derived from TreeNode.</param>
        /// <returns>The component serialised; or an empty string if the component is null.</returns>
        string Serialize(TreeNode component);
    }
}
