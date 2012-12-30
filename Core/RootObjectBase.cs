using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// データをすべて保持するクラス
/// このクラスを継承したクラスでをGameObjectに割り当て、それを選択したときにエディタは動作する
/// </summary>
[System.Serializable]
public abstract class RootObjectBase : MonoBehaviour, IRootObject
{
    /// <summary>
    /// ダイアグラム上のすべての要素を管理するリスト
    /// </summary>
    public List<DiagramElement> elements;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public RootObjectBase()
    {
        elements = new List<IDiagramElement>();
    }

    /// <summary>
    /// 描画可能なオブジェクトのリストを返す
    /// </summary>
    /// <returns>
    /// 描画可能なオブジェクトのIList(IDiagramElement)
    /// </returns>
    public IList<IDiagramElement> GetDrawableObject ()
    {
        return elements;
    }

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
        foreach (IDiagramElement e in elements)
        {
            if (e is INodeElement)
            {
                INodeElement node = (INodeElement)e;
                if (node.Position.Contains(position))
                {
                    return node;
                }
            }
        }

        return null;
    }
}
