using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// ダイアグラム上のノードを表すクラス(シリアライズ可能)
/// </summary>
[System.Serializable]
public abstract class NodeElementBase : SelectableElementBase, INodeElement
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public NodeElementBase(IRootObject root) : base(root)
    {
    }

    /// <summary>
    /// ノードの座標と大きさを表すRectを取得する
    /// </summary>
    public abstract Rect GetViewRect();

    /// <summary>
    /// 表示用のRectを格納する
    /// </summary>
    public abstract void SetViewRect(Rect rect);

    /// <summary>
    /// ノードの矩形を描画する
    /// </summary>
    public override void OnGUI()
    {
        // TODO: 矩形のデザインを変更する
        Color old = GUI.color;
        GUI.color = Color.white;
        GUI.Box (GetViewRect(), "");
        GUI.color = old;
    }
}