using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// ダイアグラム上のノードを表すクラス(シリアライズ可能)
/// </summary>
[System.Serializable]
public class NodeElementBase : SelectableElementBase, INodeElement
{
    /// <summary>
    /// エディタ上の座標と大きさを表現する為のクラス
    /// </summary>
    public Rect Position
    {
        get;
        set;
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public NodeElementBase()
    {
        Position = new Rect(0, 0, 100, 100);
    }

    /// <summary>
    /// ノードの矩形を描画する
    /// </summary>
    public override void OnGUI()
    {
        Color old = GUI.color;
        GUI.color = Color.blue;
        GUI.Box (Position, "");
        GUI.color = old;
    }
}