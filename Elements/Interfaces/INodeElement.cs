using UnityEngine;
using System.Collections;

/// <summary>
/// ノードが必要とするインタフェース
/// </summary>
public interface INodeElement
{
    /// <summary>
    /// ノードの座標と大きさを表すRect
    /// </summary>
    Rect Position
    {
        get;
        set;
    }
}
