using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Application.Features.CreateUser;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Application.DTOs.CreateStudent;
using Application.DTOs.DeleteStudent;
using Application.Features.DeleteUser;
using Application.DTOs.UpdateStudent;

namespace Application
{
    public static class ServiceExtension
    {
        public static void ConfiguraApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CreateTeacherValidator>();
            services.AddValidatorsFromAssemblyContaining<CreateStudentValidator>();
            services.AddValidatorsFromAssemblyContaining<UpdateStudentValidation>();
            services.AddScoped<IValidator<CreateTeacherRequest>, CreateTeacherValidator>();
            services.AddScoped<IValidator<CreateStudentRequest>, CreateStudentValidator>();
            services.AddScoped<IValidator<UpdateStudentRequest>, UpdateStudentValidation>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
           
            
        }

    }
}
