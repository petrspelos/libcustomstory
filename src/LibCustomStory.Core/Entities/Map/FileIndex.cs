using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class FileIndex
    {
        [XmlAttribute("NumOfFiles")]
        public int NumOfFiles { get; set; }
        
        [XmlElement("File")]
        public List<File> Files { get; set; }
    }
}
