using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMHS.UI
{
    public static class AutomapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                // Solo hay un Initialize
                    cfg.CreateMap<Models.Citas, DATA.Citas>();
                    cfg.CreateMap<DATA.Citas, Models.Citas>();
                   
                // Por cada objeto que tenga
            });
        }
    }
}