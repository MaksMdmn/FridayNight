using AutoMapper;
using FridayNight.Library.Common.Exceptions;
using FridayNight.Library.Common.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FridayNight.Library.Common.Mapper
{
    public class LayerLevelMapper : ILayerLevelMapper
    {
        private IMapper _autoMapper;

        public LayerLevelMapper(params Profile[] profiles)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => cfg.AddProfiles(profiles));

            _autoMapper = config.CreateMapper();
        }

        public TDestination Map<TDestination>(object source)
        {
            if (source == null)
            {
                throw new FailedMappingException(source, typeof(TDestination));
            }

            return _autoMapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            destination = Map<TDestination>(source);

            return destination;
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            if (source == null)
            {
                throw new FailedMappingException(source, sourceType, destinationType);
            }

            return _autoMapper.Map(source, sourceType, destinationType);
        }

        public object Map(object source, object destination, Type sourceType, Type destinationType)
        {
            destination = Map(source, sourceType, destinationType);

            return destination;
        }

        public IEnumerable<TDestination> MapAll<TDestination>(IEnumerable<dynamic> sourceList) where TDestination : class
        {
            if (sourceList == null || !sourceList.Any())
            {
                throw new FailedMappingException(sourceList, typeof(TDestination));
            }

            return sourceList.Select(obj => Map<TDestination>(obj) as TDestination);
        }
    }
}
