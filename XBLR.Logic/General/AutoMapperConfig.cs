using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBLR.Data.DataModel;
using XBLR.Logic.ViewModel;

namespace XBLR.Logic.General
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<xblrData, xblrVM>();
            });
            //var configStack = new MapperConfiguration(cfg => { cfg.CreateMap<xblrData, xblrVM>().ForMember(dest => dest.element_name, opts => opts.MapFrom(src => src.element_name)); });
        }
    }
}
