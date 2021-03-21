using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    [XmlType("Var")]
    public class UserVariable
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
