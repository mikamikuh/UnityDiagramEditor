using UnityEngine;
using System.Collections;

/// <summary>
/// イベントが発生した際に呼ばれるハンドラクラス
/// </summary>
public interface IEventHandler
{

    /// <summary>
    /// コマンドの実行時に呼ばれる
    /// </summary>
    void OnExecuteCommand ();

    /// <summary>
    ///
    /// </summary>
    void Ignore ();

    /// <summary>
    ///
    /// </summary>
    void Layout ();

    /// <summary>
    /// OnGUIが再描画で呼ばれた時に呼ばれる
    /// </summary>
    void Repaint ();

    /// <summary>
    ///
    /// </summary>
    void ValidateCommand ();
}
