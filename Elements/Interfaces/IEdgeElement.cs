using UnityEngine;
using System.Collections;

/// <summary>
/// エッジが必要とするインタフェース
/// </summary>
public interface IEdgeElement
{
    /// <summary>
    /// エッジ始点の座標を取得する
    /// </summary>
    Vector2 GetSourcePosition();

    /// <summary>
    /// エッジ終点の座標を取得する
    /// </summary>
    Vector2 GetDestinationPosition();
}
