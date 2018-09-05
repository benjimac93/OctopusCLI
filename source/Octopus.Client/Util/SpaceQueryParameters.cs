﻿namespace Octopus.Client.Util
{
    public class SpaceQueryParameters
    {
        public SpaceQueryParameters(bool includeGlobal, string[] spaceIds)
        {
            IncludeGlobal = includeGlobal;
            SpaceIds = spaceIds;
        }
        public bool IncludeGlobal { get; }
        public string[] SpaceIds { get; }
    }
}