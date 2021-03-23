using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;
using Task3Garage.Data;

namespace Task3Garage.Service.Services.MaintenanceServiceService
{
    public class MaintenanceServiceService : IMaintenanceServiceService
    {
        private readonly ApplicationDbContext _DB;

        public MaintenanceServiceService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<MaintenanceServiceVM> Index()

        {
            return null;

            //return _DB.MaintenanceServices.Include(x => x.Category)
            //    .Include(x => x.Viewers).Select(x => new MaintenanceServiceVM(x)).ToList();
        }

        public MaintenanceServiceVM Details(int id)
        {
            return null;

            //return new MaintenanceServiceVM(_DB.MaintenanceServices.Include(x => x.Viewers)
            //    .SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateMaintenanceServiceDto dTO)
        {

        }

        public void Update(UpdateMaintenanceServiceDto dTO)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
