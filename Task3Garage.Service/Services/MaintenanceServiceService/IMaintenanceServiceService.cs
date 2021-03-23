using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;

namespace Task3Garage.Service.Services.MaintenanceServiceService
{
    public interface IMaintenanceServiceService
    {
        List<MaintenanceServiceVM> Index();
        MaintenanceServiceVM Details(int id);
        void Create(CreateMaintenanceServiceDto dTO);
        void Update(UpdateMaintenanceServiceDto dTO);
        void Delete(int id);
    }
}
