using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Library.Common.Mapper.Interfaces
{
    public interface ILayerLevelMapper : IMapperBase
    {
        IEnumerable<TDestination> MapAll<TDestination>(IEnumerable<dynamic> fromObjects) where TDestination : class;
    }
}
