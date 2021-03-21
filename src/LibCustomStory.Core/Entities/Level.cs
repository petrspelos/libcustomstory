using System.Xml.Serialization;
using LibCustomStory.Core.Entities.Map;

namespace LibCustomStory.Core.Entities
{
    [XmlRoot("Level")]
    public class Level
    {
        [XmlElement("EditorSession")]
        public EditorSession EditorSession { get; set; }

        [XmlElement("MapData")]
        public MapData MapData { get; set; }
    }
}
