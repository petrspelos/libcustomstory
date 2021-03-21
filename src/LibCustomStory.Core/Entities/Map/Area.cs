using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class Area
    {
        [XmlAttribute("Active")]
        public bool Active { get; set; }

        [XmlAttribute("AreaType")]
        public string AreaType { get; set; }

        [XmlAttribute("Group")]
        public int Group { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("Mesh")]
        public string Mesh { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Rotation")]
        public string Rotation { get; set; }

        [XmlAttribute("Scale")]
        public string Scale { get; set; }

        [XmlAttribute("Tag")]
        public string Tag { get; set; }

        [XmlAttribute("WorldPos")]
        public string WorldPos { get; set; }

        [XmlArray("UserVariables")]
        [XmlArrayItem("Var")]
        public List<UserVariable> UserVariables { get; set; }
    }
}
