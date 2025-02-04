﻿namespace RavenNest.SDK.Endpoints
{
    public class ProductionRavenNestStreamSettings : IAppSettings
    {

//#if UNITY_STANDALONE_LINUX
//#endif
        public string ApiEndpoint => "https://www.ravenfall.stream/api/";
        public string ApiAuthEndpoint => "https://www.ravenfall.stream/api/";
        public string WebSocketEndpoint => "wss://www.ravenfall.stream/api/stream";

        //public string ApiEndpoint => "https://www.ravenfall.stream/api/";
        //public string ApiAuthEndpoint => "https://www.ravenfall.stream/api/";
        //public string WebSocketEndpoint => "wss://www.ravenfall.stream/api/stream";
    }

    public class StagingRavenNestStreamSettings : IAppSettings
    {
        public string ApiEndpoint => "https://staging.ravenfall.stream/api/";
        public string ApiAuthEndpoint => "https://staging.ravenfall.stream/api/";
        public string WebSocketEndpoint => "wss://staging.ravenfall.stream/api/stream";
    }
    public class UnsecureLocalRavenNestStreamSettings : IAppSettings
    {
        public string ApiEndpoint => "https://localhost:5001/api/";
        public string ApiAuthEndpoint => "https://localhost:5001/api/";
        public string WebSocketEndpoint => "ws://localhost:5000/api/stream";
    }
    public class LocalRavenNestStreamSettings : IAppSettings
    {
        public string ApiEndpoint => "https://localhost:5001/api/";
        public string ApiAuthEndpoint => "https://localhost:5001/api/";
        public string WebSocketEndpoint => "wss://localhost:5001/api/stream";
    }
}