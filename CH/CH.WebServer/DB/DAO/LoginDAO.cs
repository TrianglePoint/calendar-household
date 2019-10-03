using CH.WebServer.DB.DAO.Common;
using CH.WebServer.Models.ViewModel;
using System.Collections.Generic;

namespace CH.WebServer.DB.DAO
{
    public class LoginDao : BaseDAO
    {
        /// <summary>
        /// ログリン時
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<LoginViewModel> Login(LoginViewModel where)
        {
            return sqlMapper.QueryForObject<LoginViewModel>("Login.FindInfo", where)
                ?? throw new Exception("一致するユーザー情報がないです。アカウント名またはパスワードを確認してください。");
        }
    }
}