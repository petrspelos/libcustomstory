using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    [XmlType("Group")]
    public class Group
    {
        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Visible")]
        public bool Visible { get; set; }
    }
}
