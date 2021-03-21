using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class Entities
    {
        [XmlElement("Area")]
        public List<Area> Areas { get; set; }

        [XmlElement("Entity")]
        public List<Entity> EntityObjects { get; set; }
    }
}
