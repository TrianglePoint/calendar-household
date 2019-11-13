using CH.Model.DTO.Common;
using CH.Model.ViewModel;
using Newtonsoft.Json;

namespace CH.Model.DTO
{
	/// <summary>
	/// Test
	/// </summary>
	[JsonObject]
	public class TestDTO : BaseDTO
	{
		public TestViewModel ViewModel { get; set; }
	}
}
