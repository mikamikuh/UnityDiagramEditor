using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// データをすべて保持するクラス
/// このクラスを継承したクラスでをGameObjectに割り当て、それを選択したときにエディタは動作する
/// </summary>
public abstract class RootObjectBase : MonoBehaviour, IRootObject
{
    /// <summary>
    /// 描画可能なオブジェクトのリストを返す
    /// </summary>
    /// <returns>
    /// 描画可能なオブジェクトのIList(IDiagramElement)
    /// </returns>
    public abstract IList<DiagramElementBase> GetDrawableObject ();

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
        foreach (IDiagramElement e in GetDrawableObject())
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
