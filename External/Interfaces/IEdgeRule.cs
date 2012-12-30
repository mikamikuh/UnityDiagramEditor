using UnityEngine;
using System.Collections;

/// <summary>
/// エッジのビューモデルに変更があったとき、Unity上の実モデルを変更する処理を記述する為のインタフェース
/// </summary>
public interface IEdgeRule
{

    /// <summary>
    /// 接続先が変更されたときの処理
    /// </summary>
    /// <returns>
    /// 正しく変更できた場合はtrue, 変更できなかった場合はfalse
    /// </returns>
    bool DestinationChanged();

    /// <summary>
    /// 接続元が変更されたときの処理
    /// </summary>
    /// <returns>
    /// 正しく変更できた場合はtrue, 変更できなかった場合はfalse
    /// </returns>
    bool SourceChanged();
}
