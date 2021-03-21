using System.IO;
using System.Linq;
using System.Xml.Serialization;
using LibCustomStory.Core;
using LibCustomStory.Core.Entities;
using Xunit;

namespace LibCustomStory.Tests
{
    public class XmlParseTests
    {
        private const string customStorySettingsFile = "samples/custom_story_settings.cfg";
        private const string sampleLanguageFile = "samples/extra_english.lang";

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

        [Fact]
        public void LanguageFileParseTest()
        {
            var serializer = new XmlSerializer(typeof(LanguageResources));
            var lang = (LanguageResources)serializer.Deserialize(File.OpenRead(sampleLanguageFile));

            Assert.NotNull(lang);
            Assert.NotNull(lang.Resources);
            Assert.Equal(5, lang.Categories.Count);
            Assert.Equal("Description", lang.Categories.First(c => c.Name == "CustomStoryMain").Entries.First().Name);
            Assert.Equal("Custom Story Description", lang.Categories.First(c => c.Name == "CustomStoryMain").Entries.First().Content);

            AmnesiaResources.WriteToFile(lang, "sample.lang");
        }
    }
}
