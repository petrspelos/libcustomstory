using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class ArrayProperty
    {
        [XmlAttribute("Array")]
        public string Array { get; set; }
    }
}
