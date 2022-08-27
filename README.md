# Kogane String Formatter

ジェネリックを使用することで string.Format の GC Alloc を減らすためのインターフェイス

## 使用例

```cs
using Cysharp.Text;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private readonly IStringFormatter m_formatter = 
#if ENABLE_ZSTRING
        new ZStringFormatter();
#else
        new DefaultStringFormatter();
#endif

    private void Start()
    {
        var text = m_formatter.Format( "{0}/{1}", 25, 100 );
    }
}

public sealed class ZStringFormatter : IStringFormatter
{
    public string Format<T1>( string format, T1 arg1 )
    {
        return ZString.Format( format, arg1 );
    }

    public string Format<T1, T2>( string format, T1 arg1, T2 arg2 )
    {
        return ZString.Format( format, arg1, arg2 );
    }

    public string Format<T1, T2, T3>( string format, T1 arg1, T2 arg2, T3 arg3 )
    {
        return ZString.Format( format, arg1, arg2, arg3 );
    }

    public string Format<T1, T2, T3, T4>( string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
    {
        return ZString.Format( format, arg1, arg2, arg3, arg4 );
    }
}
```
