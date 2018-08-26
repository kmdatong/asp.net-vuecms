using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vuecms.Domains;

namespace vuecms.Controllers
{
  
    [RoutePrefix("api")]
    public class WebApiController : ApiController
    {
        private DTContext _context { get; set; }

        public WebApiController()
        {
            _context = new DTContext() ;

        }

        [HttpGet]
        [Route("list")]
        public object List()
        {
            var list = _context.ClassInfo.ToList();

            return list;
        }

        [HttpGet]
        [Route("userlist")]
        public object UserList(int page = 1, int pageSize = 15, string callback = "")
        {
            var list = _context.Account.OrderBy(x => x.Id).Skip((page - 1) * pageSize).Take(pageSize);

            return new { data = list };
        }

        [HttpPost]
        [Route("adduser")]
        public object AddUser(Account user)
        {

            _context.Account.Add(user);
            _context.SaveChanges();

            var list = _context.Account.OrderBy(x => x.Id).Skip(0).Take(15);

            return Json(new { data = list });
        }

        [HttpGet]
        [Route("lunbolist")]
        public object LunBoList(int page = 1, int pageSize = 15, string callback = "")
        {
            var list = _context.LunBo.OrderByDescending(x => x.Sort)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new { data = list };
        }

    }
}
