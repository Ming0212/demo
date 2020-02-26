using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace demo.Models
{
    public class BModelProfile : Profile
    {
        public BModelProfile()
        {
            this.CreateMap<AModel, BModel>();
        }
    }
}
