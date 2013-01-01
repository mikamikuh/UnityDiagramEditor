using UnityEngine;
using System.Collections;

/// <summary>
/// ノードが必要とするインタフェース
/// </summary>
public interface INodeElement
{
    /// <summary>
    /// ノードの座標と大きさを表すRectを取得する
    /// </summary>
    Rect GetViewRect();

    /// <summary>
    /// 表示用のRectを格納する
    /// </summary>
    void SetViewRect(Rect rect);
}
