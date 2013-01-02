using UnityEngine;
using System.Collections;

/// <summary>
/// マウスの入力を通知するハンドラ
/// </summary>
public interface IMouseInputHandler
{
    /// <summary>
    /// イベント発生時、マウス座標に存在する要素を格納する
    /// </summary>
    INodeElement CurrentElement
    {
        get;
        set;
    }

    /// <summary>
    /// 右クリックされたときの処理
    /// </summary>
    void OnContextClick ();

    /// <summary>
    /// 不明
    /// </summary>
    void OnDragExisted ();

    /// <summary>
    /// 不明
    /// </summary>
    void OnDragPerform ();

    /// <summary>
    /// 不明
    /// </summary>
    void OnDragUpdated ();

    /// <summary>
    /// マウスが左クリック押下されたときの処理
    /// </summary>
    /// <param name='position'>
    /// イベントが発生したエディタ上の座標
    /// </param>
    void OnMouseDown(Vector2 position);

    /// <summary>
    /// マウスがドラッグ中であるときの処理
    /// </summary>
    /// <param name='position'>
    /// イベントが発生したエディタ上の座標
    /// </param>
    void OnMouseDrag(Vector2 position);

    /// <summary>
    /// マウスの左クリックが離されたときの処理
    /// </summary>
    /// <param name='position'>
    /// イベントが発生したエディタ上の座標
    /// </param>
    void OnMouseUp(Vector2 position);

    /// <summary>
    /// マウスが移動中であるときの処理
    /// EditorWindow.wantsMouseMoveがtureでないと呼ばれない
    /// </summary>
    /// <param name='position'>
    /// イベントが発生したエディタ上の座標
    /// </param>
    void MouseMove(Vector2 position);

    /// <summary>
    /// マウスがスクロールされたときの処理
    /// </summary>
    void OnScrollWheel ();

    /// <summary>
    /// 何も発生しなかった場合に呼ばれる
    /// EditorWindow.wantsMouseMoveがtureの場合、毎フレーム毎に呼ばれる
    /// </summary>
    void MouseUpdate(Vector2 position);
}
