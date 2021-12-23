namespace EpicAkS.Net.BasicJsonParser
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyNameAliasAttribute : Attribute
    {
        public string Alias { get; set; } = string.Empty;

        public PropertyNameAliasAttribute(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Alias = name;
        }
    }
}
