using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;
using Task3Garage.Data;

namespace Task3Garage.Service.Services.MaintenanceReportService
{
    public class MaintenanceReportService : IMaintenanceReportService
    {
        private readonly ApplicationDbContext _DB;

        public MaintenanceReportService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<MaintenanceReportVM> Index()

        {
            return null;
            //return _DB.MaintenanceReports.Include(x => x.Category)
            //    .Include(x => x.Viewers).Select(x => new MaintenanceReportVM(x)).ToList();
        }

        public MaintenanceReportVM Details(int id)

        {
            return null;

            //return new MaintenanceReportVM(_DB.MaintenanceReports.Include(x => x.Viewers)
            //    .SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateMaintenanceReportDto dTO)
        {

        }

        public void Update(UpdateMaintenanceReportDto dTO)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
