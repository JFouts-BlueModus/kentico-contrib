using CMS.DocumentEngine;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Meeg.Kentico.ContentComponents.Cms
{
    /// <summary>
    /// This class can be used to deserialise Page Type Component data that has been serialised to JSON.
    /// </summary>
    public class PageTypeComponentJsonDeserializer : IPageTypeDeserializer
    {
        /// <summary>
        /// Deserialises Page Type Component JSON and returns a new TreeNode instance containing component data.
        /// </summary>
        /// <param name="pageType">The full class name of the component Page Type.</param>
        /// <param name="componentSerialized">The Page Type Component JSON to deserialise.</param>
        /// <returns>A new TreeNode instance containing the deserialised component data.</returns>
        public TreeNode Deserialize(string pageType, string componentSerialized)
        {
            if (string.IsNullOrEmpty(pageType))
            {
                return null;
            }

            var page = TreeNode.New(pageType);

            LoadJsonIntoPage(page, componentSerialized);

            return page;
        }

        /// <summary>
        /// Deserialises Page Type Component JSON and returns a new TreeNode instance of type T containing component data.
        /// </summary>
        /// <typeparam name="T">A type representing the Page Type of the component.</typeparam>
        /// <param name="componentSerialized">The Page Type Component JSON to deserialise.</param>
        /// <returns>A new TreeNode instance of Type T containing the deserialised component data.</returns>
        public T Deserialize<T>(string componentSerialized) where T : TreeNode, new()
        {
            var page = TreeNode.New<T>();

            LoadJsonIntoPage(page, componentSerialized);

            return page;
        }

        private void LoadJsonIntoPage(TreeNode page, string json)
        {
            if (json != null)
            {
                var values = GetDictionaryFromJson(json);

                foreach (var value in values)
                {
                    page.SetValue(value.Key, value.Value);
                }
            }
        }

        private Dictionary<string, object> GetDictionaryFromJson(object json)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(json.ToString());
        }
    }
}
