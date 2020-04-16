using CMS.DocumentEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Meeg.Kentico.ContentComponents.Cms
{
    /// <summary>
    /// This class can be used to serialise Page Type Component data to JSON.
    /// </summary>
    public class PageTypeComponentJsonSerializer : IPageTypeSerializer
    {
        /// <summary>
        /// Serialises a Page Type Component to JSON.
        /// </summary>
        /// <param name="component">The Page Type Component to serialise - can be an instance of any type derived from TreeNode.</param>
        /// <returns>The component serialised to JSON; or an empty string if the component is null.</returns>
        public string Serialize(TreeNode component)
        {
            if (component == null)
            {
                return string.Empty;
            }
            
            var json = new JObject();

            foreach (var field in component.Generalized.PrioritizedProperties)
            {
                var value = component.GetProperty(field);

                if (value is string strValue)
                {
                    json.Add(field, strValue);
                }
                else
                {
                    json.Add(field, JsonConvert.SerializeObject(value));
                }
            }
            
            return json.ToString();
        }
    }
}
