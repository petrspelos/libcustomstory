using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities
{
    [XmlRoot("LANGUAGE")]
    public class LanguageResources
    {
        /// <summary>
        /// An object required by Amnesia.
        /// Doesn't contain any data and will be an empty object.
        /// </summary>
        [XmlElement("RESOURCES")]
        public object Resources { get; set; }

        [XmlElement("CATEGORY")]
        public List<LanguageCategory> Categories { get; set; }
    }
}
