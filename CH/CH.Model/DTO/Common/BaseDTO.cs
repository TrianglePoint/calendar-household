using System.Collections.Generic;
using Newtonsoft.Json;

namespace CH.Model.DTO.Common
{
	/// <summary>
	/// 基本DTO
	/// サーバ ー＞ クライアントにデータを送る際使います。
	/// </summary>
	[JsonObject]
	public class BaseDTO
	{
		/// <summary>
		/// サーバ処理の成功可否
		/// </summary>
		public bool Status { get; set; }

		/// <summary>
		/// サーバがクライアントに送るメッセージ
		/// </summary>
		public IList<string> Messages { get; set; }
	}
}
