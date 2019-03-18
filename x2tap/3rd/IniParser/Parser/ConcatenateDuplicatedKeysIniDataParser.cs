using IniParser.Model;
using IniParser.Model.Configuration;

namespace IniParser.Parser
{
    public class ConcatenateDuplicatedKeysIniDataParser : IniDataParser
    {
        public ConcatenateDuplicatedKeysIniDataParser()
            : this(new ConcatenateDuplicatedKeysIniParserConfiguration())
        {
        }

        public ConcatenateDuplicatedKeysIniDataParser(ConcatenateDuplicatedKeysIniParserConfiguration parserConfiguration)
            : base(parserConfiguration)
        {
        }

        public new ConcatenateDuplicatedKeysIniParserConfiguration Configuration
        {
            get => (ConcatenateDuplicatedKeysIniParserConfiguration) base.Configuration;
            set => base.Configuration = value;
        }

        protected override void HandleDuplicatedKeyInCollection(string key, string value, KeyDataCollection keyDataCollection, string sectionName)
        {
            keyDataCollection[key] += Configuration.ConcatenateSeparator + value;
        }
    }
}