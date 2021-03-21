using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class MapContents
    {
        [XmlElement("FileIndex_StaticObjects")]
        public FileIndex StaticObjectsFileIndex { get; set; }

        [XmlElement("FileIndex_Entities")]
        public FileIndex EntitiesFileIndex { get; set; }

        [XmlElement("FileIndex_Decals")]
        public FileIndex DecalsFileIndex { get; set; }

        [XmlArray("StaticObjects")]
        [XmlArrayItem("StaticObject")]
        public List<StaticObject> StaticObjects { get; set; }

        [XmlArray("Primitives")]
        [XmlArrayItem("Plane")]
        public List<Plane> Primitives { get; set; }

        [XmlArray("Decals")]
        [XmlArrayItem("Decal")]
        public List<Decal> Decals { get; set; }

        [XmlElement("Entities")]
        public Entities Entities { get; set; }
    }
}
