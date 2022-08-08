using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data;
using teste.tcc.Models;

namespace teste.tcc.services
{

    public class UserResponsavelService
    {
        private AppDbContext _context;

        public UserResponsavelService(AppDbContext context)
        {
            _context = context;
        }

        public UserResponsavel AdicionaResponsavel (UserResponsavel user)
        {
            _context.UserResponsavel.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserResponsavel RecuperaUserPorLogin(string login)
        {
            UserResponsavel user = _context.UserResponsavel.FirstOrDefault(user => user.login == login);
            if(user != null)
            {
                return user;
            }
            return null;
        }
    }
}
