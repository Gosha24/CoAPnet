﻿namespace CoAPnet.Protocol
{
    public static class CoapDefaultPort
    {
        // Default IANA ports.
        public static int Unencrypted { get; } = 5683;

        public static int Encrypted { get; } = 5684;
    }
}
