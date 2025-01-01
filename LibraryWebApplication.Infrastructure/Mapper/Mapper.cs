using AutoMapper;
using LibraryWebApplication.Application.Interfaces;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Mapper
{
    public class Mapper : IMapperClass
    {
        private readonly IMapper _mapper;

        public Mapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<TDestination> Map<TSource, TDestination>(TSource source)
        {
            return await Task.Run(() => _mapper.Map<TDestination>(source));
        }

        public async Task<TDestination> Update<TSource, TDestination>(TSource source, TDestination destination)
        {
            return await Task.Run(() => _mapper.Map(source, destination));
        }
        
    }
}