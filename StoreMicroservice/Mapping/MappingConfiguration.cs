﻿namespace StoreMicroservice.Mapping
{
    public static class MappingConfiguration
    {
        public static IEnumerable<AutoMapper.Profile> GetMappingProfile()
        {
            return new AutoMapper.Profile[]
            {
                new StoreMappingProfile()
            };
        }
    }
}
