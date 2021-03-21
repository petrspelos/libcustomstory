using System;
using System.IO;
using System.Xml.Serialization;
using LibCustomStory.Core.Entities;
using Xunit;

namespace LibCustomStory.Tests
{
    public class XmlParseTests
    {
        private const string customStorySettingsFile = "samples/custom_story_settings.cfg";

        [Fact]
        public void ConfigParseTest()
        {
            var serializer = new XmlSerializer(typeof(CustomStorySettings));
            var settings = (CustomStorySettings)serializer.Deserialize(File.OpenRead(customStorySettingsFile));

            Assert.NotNull(settings);
            Assert.Equal("My Custom Story", settings.Name);
            Assert.Equal("Author's Name", settings.Author);
            Assert.Equal("image.png", settings.ImgFile);
            Assert.Equal("maps/", settings.MapsFolder);
            Assert.Equal("mapname.map", settings.StartMap);
            Assert.Equal("PlayerStartArea_1", settings.StartPos);
            Assert.Equal("extra_", settings.ExtraLangFilePrefix);
            Assert.Equal("english.lang", settings.DefaultExtraLangFile);
        }
    }
}
