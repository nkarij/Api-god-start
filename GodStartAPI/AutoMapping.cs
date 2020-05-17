using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GodStartAPI.Models;

namespace GodStartAPI
{
   
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            this.CreateMap<Job, JobRessource>(); // means you want to map from  to 
            this.CreateMap<Category, CategoryRessource>();
            this.CreateMap<PostNumber, PostNumberRessource>();
        }
    }

}
