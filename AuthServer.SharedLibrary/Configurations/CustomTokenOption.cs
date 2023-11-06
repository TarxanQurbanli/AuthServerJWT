﻿namespace AuthServer.SharedLibrary.Configurations
{
    public class CustomTokenOption
    {
        public List<string> Audience { get; set; }  // Audisence yerine Audience kullanılmalı
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }

}
