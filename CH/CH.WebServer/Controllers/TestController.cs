using CH.Model.DTO;
using CH.Model.ViewModel;
using CH.WebServer.DB.DAO;
using CH.WebServer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace CH.WebServer.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class TestController : ApiController
	{
		public JsonResult<TestDTO> GetTest()
		{
			TestDTO dto = new TestDTO
			{
				ViewModel = new TestViewModel
				{
					Text = "testOK"
				}
			};
			return Json(dto);
		}


        // GET api/test
        public IList<TestThingViewModel> Get()
        {
            TestDAO dao = new TestDAO();
            IList<TestThingViewModel> viewModels = dao.ExecuteGet();

            return viewModels;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
