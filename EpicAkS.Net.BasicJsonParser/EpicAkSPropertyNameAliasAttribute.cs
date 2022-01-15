namespace EpicAkS.Net.BasicJsonParser
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EpicAkSPropertyNameAliasAttribute : Attribute
    {
        public string Alias { get; set; } = string.Empty;

        public EpicAkSPropertyNameAliasAttribute(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Alias = name;
        }
    }
}
