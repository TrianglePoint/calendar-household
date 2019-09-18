using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace CH.WebServer.DB.DAO.Common
{
    public class BaseDAO
    {
        protected readonly ISqlMapper sqlMapper;

        public BaseDAO()
        {
            DomSqlMapBuilder dom = new DomSqlMapBuilder();
            sqlMapper = dom.Configure(@"./SqlMap.config");
        }

        /// <summary>
        /// Begin
        /// </summary>
        public void BeginTransaction()
        {
            sqlMapper.BeginTransaction();
        }

        /// <summary>
        /// Commit
        /// </summary>
        public void CommitTransaction()
        {
            sqlMapper.CommitTransaction();
        }

        /// <summary>
        /// RollBack
        /// </summary>
        public void RollBackTransaction()
        {
            sqlMapper.RollBackTransaction();
        }
    }
}