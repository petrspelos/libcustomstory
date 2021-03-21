using System.Collections.Generic;
using System.Xml.Serialization;

namespace LibCustomStory.Core.Entities.Map
{
    public class ViewportConfig
    {
        [XmlAttribute("BGColor")]
        public string BgColor { get; set; }

        [XmlAttribute("GAmbientLight")]
        public bool GAmbientLight { get; set; }

        [XmlAttribute("GPointLight")]
        public bool GPointLight { get; set; }

        [XmlAttribute("GridSnap")]
        public bool GridSnap { get; set; }

        [XmlAttribute("GridSnapSeparation")]
        public float GridSnapSeparation { get; set; }

        [XmlAttribute("SelectedViewport")]
        public int SelectedViewport { get; set; }

        [XmlAttribute("UsingEnlargedViewport")]
        public bool UsingEnlargedViewport { get; set; }

        [XmlElement("Viewport")]
        public List<Viewport> Viewports { get; set; }
    }
}
