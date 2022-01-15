namespace EpicAkS.Net.BasicJsonParser
{
    /// <summary>
    /// <c>EpicAkSPropertyNameAliasAttribute</c> Used to rename a property for json purposes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class EpicAkSPropertyNameAliasAttribute : Attribute
    {
        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public string Alias { get; set; } = string.Empty;

        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public EpicAkSPropertyNameAliasAttribute(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Alias = name;
        }
    }
}
