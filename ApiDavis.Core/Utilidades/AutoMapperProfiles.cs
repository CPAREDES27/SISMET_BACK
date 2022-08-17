﻿using ApiDavis.Core.DTOs;
using ApiDavis.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDavis.Core.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<UsuarioRequestDTO, Usuario>();
            CreateMap<Usuario, UsuarioRequestDTO>();
            CreateMap<Usuario, UsuarioResponseDTO>();
        }
    }
}
