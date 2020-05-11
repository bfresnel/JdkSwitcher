using System.Text.Json.Serialization;

namespace JdkSwitcher
{
    class PathConfiguration
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("PathValue")]
        public string PathValue { get; set; }

        public PathConfiguration()
        {
        }

        public PathConfiguration(string name, string pathValue)
        {
            this.Name = name;
            this.PathValue = pathValue;
        }

        public override string ToString()
        {
            return this.Name + " - " + this.PathValue;
        }
    }
}
