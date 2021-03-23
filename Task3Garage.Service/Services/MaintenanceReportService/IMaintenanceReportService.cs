using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;

namespace Task3Garage.Service.Services.MaintenanceReportService
{
    public interface IMaintenanceReportService
    {
        List<MaintenanceReportVM> Index();
        MaintenanceReportVM Details(int id);
        void Create(CreateMaintenanceReportDto dTO);
        void Update(UpdateMaintenanceReportDto dTO);
        void Delete(int id);
    }
}
