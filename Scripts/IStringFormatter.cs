using JetBrains.Annotations;

namespace Kogane
{
	/// <summary>
	/// ジェネリックを使用することで string.Format の GC Alloc を減らすためのインターフェイス
	/// </summary>
	public interface IStringFormatter
	{
		/// <summary>
		/// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
		/// </summary>
		[StringFormatMethod( "format" )]
		string Format<T1>( string format, T1 arg1 );

		/// <summary>
		/// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
		/// </summary>
		[StringFormatMethod( "format" )]
		string Format<T1, T2>( string format, T1 arg1, T2 arg2 );

		/// <summary>
		/// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
		/// </summary>
		[StringFormatMethod( "format" )]
		string Format<T1, T2, T3>( string format, T1 arg1, T2 arg2, T3 arg3 );

		/// <summary>
		/// 指定された形式に基づいてオブジェクトの値を文字列に変換し、別の文字列に挿入します
		/// </summary>
		[StringFormatMethod( "format" )]
		string Format<T1, T2, T3, T4>( string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4 );
	}
}