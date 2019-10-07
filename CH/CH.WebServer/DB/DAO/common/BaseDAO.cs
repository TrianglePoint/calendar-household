using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace CH.WebServer.DB.DAO.Common
{
	public class BaseDAO
	{
		protected readonly ISqlMapper sqlMapper;
		protected ISqlMapSession Session { get; set; }

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
            Session = sqlMapper.BeginTransaction();
        }

		/// <summary>
		/// Commit
		/// </summary>
		public void CommitTransaction()
		{
			if (Session != null)
			{
				Session.CommitTransaction();
			}
        }

		/// <summary>
		/// RollBack
		/// </summary>
		public void RollBackTransaction()
		{
			if (Session != null)
			{
				Session.RollBackTransaction();
			}
        }
    }
}