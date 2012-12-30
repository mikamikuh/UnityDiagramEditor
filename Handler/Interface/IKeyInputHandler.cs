using UnityEngine;
using System.Collections;

/// <summary>
/// キーボードのキー入力を扱うハンドラ
/// </summary>
public interface IKeyInputHandler
{

    /// <summary>
    /// キーボードのキーが押下されたことを通知する
    /// </summary>
    /// <param name='keyCode'>
    /// 押下されたキーの種別
    /// </param>
    void OnKeyDown (KeyCode keyCode);

    /// <summary>
    /// キーボードのキーが離されたことを通知する
    /// </summary>
    /// <param name='keyCode'>
    /// 離されたキーの種別
    /// </param>
    void OnKeyUp (KeyCode keyCode);
}
