using CH.WebServer.DB.DAO;
using CH.WebServer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CH.WebServer.Controllers
{
    public class TestController : ApiController
    {
        // GET api/test
        public IList<LoginViewModel> Get(LoginViewModel where)
        {
            try
            {
                LoginDAO dao = new LoginDAO();
                IList<LoginViewModel> viewModels = dao.Login(where);
                return viewModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
