using InfoTrack.DevAwesome.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace InfoTrack.DevAwesome.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private LdmCoreContext _context;

        public RolesController(LdmCoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("username/{username}")]
        public IEnumerable<string> GetRolesByUsername(string username)
        {
            var login = _context.Clients
                .Include(x => x.ClientRoles)
                .ThenInclude(x => x.Role)
                .FirstOrDefault(x => x.Id == 14);
            var roles = login.ClientRoles.Select(x => x.Role)
                .ToList();
            return new string[] { "value12", username };
        }
    }
}
