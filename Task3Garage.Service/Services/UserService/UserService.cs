using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Core.Dto;
using Task3Garage.Core.ViewModels;
using Task3Garage.Data;

namespace Task3Garage.Service.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _DB;

        public UserService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<UserVM> Index()

        {
            //return _DB.Users.Include(x => x.Category)
            //    .Include(x => x.Viewers).Select(x => new UserVM(x)).ToList();
            return null;
        }

        public UserVM Details(int id)
        {
            //return new UserVM(_DB.Users.Include(x => x.Viewers)
                //.SingleOrDefault(x => x.Id == id));
            return null;

        }

        public void Create(CreateUserDTO dTO)
        {

        }

        public void Update(UpdateUserDTO dTO)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
