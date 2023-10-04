using Application.Features.CreateApplicationUser;
using Application.Features.LoginApplicationUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Repositoties
{
    public  interface IAuthService
    {
        Task<(int, string)> Registeration(Registration model, string role);
        Task<(int, string)> Login(Login model);
    }
}
