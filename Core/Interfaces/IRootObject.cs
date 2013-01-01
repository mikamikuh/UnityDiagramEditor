using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// すべてのデータを保持するルートオブジェクトが持つインタフェース
/// </summary>
public interface IRootObject
{
    /// <summary>
    /// 保持するダイアグラムの要素から、描画可能な要素を全て取得する
    /// </summary>
    /// <returns>
    /// 描画可能な全ての要素(IDiagramElement)
    /// </returns>
    IList<DiagramElementBase> GetDrawableObject();

    /// <summary>
    /// マウスの座標から、その座標に存在するノードを取得する
    /// </summary>
    /// <param name='position'>
    /// 探索対象のマウス座標
    /// </param>
    /// <returns>
    /// 座標上に存在するノード(INodeELement)
    /// </returns>
    INodeElement GetNodeElement(Vector2 position);
}
