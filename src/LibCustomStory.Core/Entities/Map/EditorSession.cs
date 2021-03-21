using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class EditorSession
    {
        [XmlElement("Performance")]
        public Performance Performance { get; set; }

        [XmlElement("ViewportConfig")]
        public ViewportConfig ViewportConfig { get; set; }

        [XmlArray("Groups")]
        [XmlArrayItem("Group")] 
        public List<Group> Groups { get; set; }
    }
}
