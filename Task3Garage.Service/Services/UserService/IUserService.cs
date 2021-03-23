using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;
using Task3Garage.Data;

namespace Task3Garage.Service.Services.UserService
{
    public interface IUserService
    {
        List<UserVM> Index();
        UserVM Details(int id);
        void Create(CreateUserDTO dTO);
        void Update(UpdateUserDTO dTO);
        void Delete(int id);
    }
}
