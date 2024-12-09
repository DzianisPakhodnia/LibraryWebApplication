using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Application.Interfaces
{
    public interface IMapperClass
    {
        Task<TDestination> Map<TSource, TDestination>(TSource source);
        Task<TDestination> Update<TSource, TDestination>(TSource source, TDestination destination);
    }
}
