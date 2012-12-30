using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上のノードの入力に対するハンドラ
/// </summary>
public interface INodeInputHandler : IMouseInputHandler
{
    /// <summary>
    /// イベント発生時、マウス座標に存在する要素を格納する
    /// </summary>
    INodeElement CurrentElement
    {
        get;
        set;
    }
}
