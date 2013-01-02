using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// データをすべて保持するクラス
/// このクラスを継承したクラスでをGameObjectに割り当て、それを選択したときにエディタは動作する
/// </summary>
public abstract class RootObjectBase : MonoBehaviour, IRootObject
{
    /// <summary>
    /// ノードのビューモデル一覧
    /// </summary>
    public IList<INodeElement> NodeElements
    {
        get;
        set;
    }

    /// <summary>
    /// エッジのビューモデル一覧
    /// </summary>
    public IList<IEdgeElement> EdgeElements
    {
        get;
        set;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public RootObjectBase()
    {
        NodeElements = new List<INodeElement>();
        EdgeElements = new List<IEdgeElement>();
    }

    /// <summary>
    /// 本モデルと同期済かどうか
    /// </summary>
    [System.NonSerialized]
    protected bool initialized = false;
    public bool IsInitialized
    {
        get
        {
            return initialized;
        }
    }

    /// <summary>
    /// このルートオブジェクトの本モデルとビューモデルを同期する
    /// </summary>
    public abstract void initialize();

    /// <summary>
    /// 対象のマウス座標に存在するノードを返す
    /// </summary>
    /// <param name='position'>
    /// 対象のマウス座標
    /// </param>
    /// <returns>
    /// 対象のマウス座標上のノード(INodeElement)
    /// </returns>
    public INodeElement GetNodeElement(Vector2 position)
    {
        foreach (IDiagramElement e in NodeElements)
        {
            if (e is INodeElement)
            {
                INodeElement node = (INodeElement)e;
                if (node.GetViewRect().Contains(position))
                {
                    return node;
                }
            }
        }

        return null;
    }

    /// <summary>
    /// IDを指定してダイアグラム上の要素を取得する
    /// NodeElementsとEdgeElementsの両方から探索する
    /// </summary>
    /// <param name='id'>
    /// 取得対象のID
    /// </param>
    /// <returns>
    /// 発見した要素
    /// </returns>
    public IDiagramElement GetDiagramElement(string id)
    {
        foreach (IDiagramElement e in NodeElements)
        {
            if (e.GetId() == id)
            {
                return e;
            }
        }

        foreach (IDiagramElement e in EdgeElements)
        {
            if (e.GetId() == id)
            {
                return e;
            }
        }

        return null;
    }
}
