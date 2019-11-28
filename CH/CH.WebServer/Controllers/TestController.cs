using CH.Model.DTO;
using CH.Model.ViewModel;
using System.Web.Http;

namespace CH.WebServer.Controllers
{
	public class TestController : ApiController
	{
		[HttpGet]
		public TestDTO Get(TestViewModel viewModel)
		{
			TestDTO result = new TestDTO
			{
				ViewModel = new TestViewModel
				{
					Text = "testGet"
				}
			};

			result.Status = true;

			return result;
		}

		[HttpPost]
		public TestDTO Post(TestViewModel viewModel)
		{
			TestDTO result = new TestDTO
			{
				ViewModel = new TestViewModel
				{
					Text = "testPost"
				}
			};
            
            result.Status = true;

            return result;
		}

		[HttpPut]
		public TestDTO Put(TestViewModel viewModel)
		{
			TestDTO result = new TestDTO
			{
				ViewModel = new TestViewModel
				{
					Text = "testPut"
				}
			};

			result.Status = true;

			return result;
		}

		[HttpDelete]
		public TestDTO Delete(TestViewModel viewModel)
		{
			TestDTO result = new TestDTO
			{
				ViewModel = new TestViewModel
				{
					Text = "testDelete"
				}
			};

			result.Status = true;

			return result;
		}
    }
}
