namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.Google
{
    public class GoogleAccessToken
    {
        [PropertyNameAliasAttribute("access_token")]
        public string? AccessToken { get; set; }

        [PropertyNameAliasAttribute("token_type")]
        public string? TokenType { get; set; }

        [PropertyNameAliasAttribute("expires_in")]
        public long? ExpiresIn { get; set; }
    }

    public class GoogleOpenIdConfiguration
    {
        [PropertyNameAliasAttribute("issuer")]
        public string? Issuer { get; set; }

        [PropertyNameAliasAttribute("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        [PropertyNameAliasAttribute("device_authorization_endpoint")]
        public string? DeviceAuthorizationEndpoint { get; set; }

        [PropertyNameAliasAttribute("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        [PropertyNameAliasAttribute("userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }

        [PropertyNameAliasAttribute("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        [PropertyNameAliasAttribute("jwks_uri")]
        public string? Jwks_Uri { get; set; }

        [PropertyNameAliasAttribute("response_types_supported")]
        public string[]? ResponseTypesSupported { get; set; }

        [PropertyNameAliasAttribute("subject_types_supported")]
        public string[]? SubjectTypesSupported { get; set; }

        [PropertyNameAliasAttribute("id_token_signing_alg_values_supported")]
        public string[]? IdTokenSigningAlgValuesSupported { get; set; }

        [PropertyNameAliasAttribute("scopes_supported")]
        public string[]? ScopesSupported { get; set; }

        [PropertyNameAliasAttribute("token_endpoint_auth_methods_supported")]
        public string[]? TokenEndpointAuthMethodsSupported { get; set; }

        [PropertyNameAliasAttribute("claims_supported")]
        public string[]? ClaimsSupported { get; set; }

        [PropertyNameAliasAttribute("code_challenge_methods_supported")]
        public string[]? CodeChallengeMethodsSupported { get; set; }

        [PropertyNameAliasAttribute("grant_types_supported")]
        public string[]? GrantTypesSupported { get; set; }
    }

    public class GoogleUserInfo
    {
        [PropertyNameAliasAttribute("sub")]
        public string? Sub { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("given_name")]
        public string? GivenName { get; set; }

        [PropertyNameAliasAttribute("family_name")]
        public string? FamilyName { get; set; }

        [PropertyNameAliasAttribute("picture")]
        public string? Picture { get; set; }

        [PropertyNameAliasAttribute("email")]
        public string? Email { get; set; }

        [PropertyNameAliasAttribute("email_verified")]
        public bool? EmailVerified { get; set; }

        [PropertyNameAliasAttribute("locale")]
        public string? Locale { get; set; }
    }
}
