﻿using AutoMapper;
using CESDE.ConductaEstudiante.Application.Commands.ConductaEstudiantesC;
using CESDE.ConductaEstudiante.Application.Dtos.ConductaEstudiante;
using CESDE.ConductaEstudiante.Domain.Entities;


namespace CESDE.ConductaEstudiante.Application.Mappings.ConductaEstudianteM
{
    public class ConductaEstudianteMapping : Profile
    {

        public ConductaEstudianteMapping() 
        {
            CreateMap<Estudiante, ConductaEstudianteDto>();
            CreateMap<CrearConductaEstudianteCommand, Estudiante>();

        }

    }
}
