namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.Google
{
    /// <summary>
    /// <c>GoogleAccessToken</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developers.google.com/identity/protocols/oauth2</seealso>
    public class GoogleAccessToken
    {
        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2</seealso>
        [EpicAkSPropertyNameAliasAttribute("access_token")]
        public string? AccessToken { get; set; }

        /// <value>
        /// <c>TokenType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2</seealso>
        [EpicAkSPropertyNameAliasAttribute("token_type")]
        public string? TokenType { get; set; }

        /// <value>
        /// <c>ExpiresIn</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2</seealso>
        [EpicAkSPropertyNameAliasAttribute("expires_in")]
        public long? ExpiresIn { get; set; }
    }

    /// <summary>
    /// <c>GoogleOpenIdConfiguration</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
    public class GoogleOpenIdConfiguration
    {
        /// <value>
        /// <c>Issuer</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("issuer")]
        public string? Issuer { get; set; }

        /// <value>
        /// <c>AuthorizationEndpoint</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <value>
        /// <c>DeviceAuthorizationEndpoint</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("device_authorization_endpoint")]
        public string? DeviceAuthorizationEndpoint { get; set; }

        /// <value>
        /// <c>TokenEndpoint</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        /// <value>
        /// <c>UserinfoEndpoint</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }

        /// <value>
        /// <c>RevocationEndpoint</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        /// <value>
        /// <c>Jwks_Uri</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("jwks_uri")]
        public string? Jwks_Uri { get; set; }

        /// <value>
        /// <c>ResponseTypesSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("response_types_supported")]
        public string[]? ResponseTypesSupported { get; set; }

        /// <value>
        /// <c>SubjectTypesSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("subject_types_supported")]
        public string[]? SubjectTypesSupported { get; set; }

        /// <value>
        /// <c>IdTokenSigningAlgValuesSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("id_token_signing_alg_values_supported")]
        public string[]? IdTokenSigningAlgValuesSupported { get; set; }

        /// <value>
        /// <c>ScopesSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("scopes_supported")]
        public string[]? ScopesSupported { get; set; }

        /// <value>
        /// <c>TokenEndpointAuthMethodsSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("token_endpoint_auth_methods_supported")]
        public string[]? TokenEndpointAuthMethodsSupported { get; set; }

        /// <value>
        /// <c>ClaimsSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("claims_supported")]
        public string[]? ClaimsSupported { get; set; }

        /// <value>
        /// <c>CodeChallengeMethodsSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("code_challenge_methods_supported")]
        public string[]? CodeChallengeMethodsSupported { get; set; }

        /// <value>
        /// <c>GrantTypesSupported</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect</seealso>
        [EpicAkSPropertyNameAliasAttribute("grant_types_supported")]
        public string[]? GrantTypesSupported { get; set; }
    }


    /// <summary>
    /// <c>GoogleUserInfo</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
    public class GoogleUserInfo
    {
        /// <value>
        /// <c>Sub</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("sub")]
        public string? Sub { get; set; }

        /// <value>
        /// <c>Name</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>GivenName</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("given_name")]
        public string? GivenName { get; set; }

        /// <value>
        /// <c>FamilyName</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("family_name")]
        public string? FamilyName { get; set; }

        /// <value>
        /// <c>Picture</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("picture")]
        public string? Picture { get; set; }

        /// <value>
        /// <c>Email</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("email")]
        public string? Email { get; set; }

        /// <value>
        /// <c>EmailVerified</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <value>
        /// <c>Locale</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developers.google.com/identity/protocols/oauth2/openid-connect#obtainuserinfo</seealso>
        [EpicAkSPropertyNameAliasAttribute("locale")]
        public string? Locale { get; set; }
    }
}
