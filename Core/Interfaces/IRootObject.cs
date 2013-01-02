using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// すべてのデータを保持するルートオブジェクトが持つインタフェース
/// </summary>
public interface IRootObject
{
    /// <summary>
    /// このルートオブジェクトが初期化(本モデルの内容が反映されている)済みかどうか
    /// </summary>
    bool IsInitialized
    {
        get;
    }

    /// <summary>
    /// ノード用のビューモデル一覧
    /// </summary>
    IList<INodeElement> NodeElements
    {
        get;
        set;
    }

    /// <summary>
    /// エッジ用のビューモデル一覧
    /// </summary>
    IList<IEdgeElement> EdgeElements
    {
        get;
        set;
    }

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

    /// <summary>
    /// IDを指定してダイアグラム上の要素を取得する
    /// </summary>
    /// <param name='id'>
    /// 取得対象のID
    /// </param>
    /// <returns>
    /// 発見した要素
    /// </returns>
    IDiagramElement GetDiagramElement(string id);

    /// <summary>
    /// このルートオブジェクトの本モデルとビューモデルを同期する
    /// </summary>
    void initialize();
}
