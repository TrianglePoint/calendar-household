using CH.WebServer.Models.ViewModel;
using System.Collections.Generic;

namespace CH.WebServer.DB.DAO
{
    public class TestDAO : BaseDAO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<TestThingViewModel> ExecuteGet()
        {            
            return sqlMapper.QueryForList<TestThingViewModel>("Test.getTestThing", null);
        }
    }
}