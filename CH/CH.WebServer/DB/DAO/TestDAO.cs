using CH.WebServer.Models.ViewModel;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System.Collections.Generic;

namespace CH.WebServer.DB.DAO
{
    public class TestDAO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<TestThingViewModel> ExecuteGet()
        {
            DomSqlMapBuilder dom = new DomSqlMapBuilder();
            ISqlMapper sqlMapper = dom.Configure(@"./SqlMap.config");

            return sqlMapper.QueryForList<TestThingViewModel>("Test.getTestThing", null);
        }
    }
}