using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 入力に対するハンドラの実行と管理を行うシングルトンクラス
/// </summary>
public class InputHandlerRoot
{

    /// <summary>
    /// シングルトンクラス
    /// </summary>
    public static InputHandlerRoot INSTANCE = new InputHandlerRoot();

    /// <summary>
    /// マウスの入力ハンドラ
    /// </summary>
    public IMouseInputHandler MouseHandler
    {
        get;
        set;
    }

    /// <summary>
    /// 入力関連のハンドラをすべて実行する
    /// </summary>
    public void ExecuteInputHandlers ()
    {
        Execute (MouseHandler);
    }

    /// <summary>
    /// マウス入力ハンドラの処理を実行
    /// イベントの種別に応じて、インタフェースの処理を呼び出す
    /// </summary>
    private void Execute(IMouseInputHandler handler)
    {
        Event e = Event.current;

        EventType type = e.type;
        KeyCode keyCode = e.keyCode;
        Vector2 position = Event.current.mousePosition;

        switch (e.type)
        {

        case EventType.ContextClick:
            handler.OnContextClick();
            break;
        case EventType.DragExited:
            handler.OnDragExisted();
            break;
        case EventType.DragPerform:
            handler.OnDragPerform();
            break;
        case EventType.DragUpdated:
            handler.OnDragUpdated();
            break;
        case EventType.MouseDown:
            handler.OnMouseDown(position);
            break;
        case EventType.MouseDrag:
            handler.OnMouseDrag(position);
            break;
        case EventType.MouseUp:
            handler.OnMouseUp (position);
            break;
        case EventType.ScrollWheel:
            handler.OnScrollWheel();
            break;
        case EventType.MouseMove:
            handler.MouseMove(position);
            break;
        default:
            handler.MouseUpdate(position);
            break;
        }
    }
}
