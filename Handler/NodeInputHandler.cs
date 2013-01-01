using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// ノードに関するマウス入力のハンドラ
/// </summary>
public class NodeInputHandler : INodeInputHandler
{

    /// <summary>
    /// マウス座標から取得したノード
    /// </summary>
    public INodeElement CurrentElement
    {
        get;
        set;
    }

    /// <summary>
    /// 選択中の要素
    /// </summary>
    private INodeElement selectedElement;

    /// <summary>
    /// ドラッグ中かどうか
    /// ドラッグ中の場合はtrue, そうでない場合はfalse
    /// </summary>
    private bool isDrugging = false;

    /// <summary>
    /// ノードのドラッグ時、Rectの座標からどのくらい離れているかを持つ
    /// ノードをクリックした位置を起点に、ノードを動かせるようにする為に必要
    /// </summary>
    private Vector2 drugOffset;

    /// <summary>
    /// TODO 右クリック時の処理を書く
    /// </summary>
    public void OnContextClick()
    {
        Debug.Log ("OnContextClick");
    }

    /// <summary>
    /// TODO 説明を記述
    /// </summary>
    public void OnDragExisted()
    {
        Debug.Log ("OnDragExisted");
    }

    /// <summary>
    /// TODO 説明を記述
    /// </summary>
    public void OnDragPerform()
    {
        Debug.Log ("OnDragPerform");
    }

    /// <summary>
    /// TODO 説明を記述
    /// </summary>
    public void OnDragUpdated()
    {
        Debug.Log ("OnDragUpdated");
    }

    /// <summary>
    /// マウスの左ボタンが押下されたときの処理
    /// 押下されたとき、そこにノードがあればドラッグ状態にする
    /// </summary>
    /// <param name='position'>
    /// 押下されたときの座標
    /// </param>
    public void OnMouseDown(Vector2 position)
    {
        if (CurrentElement != null)
        {
            isDrugging = true;
            selectedElement = CurrentElement;
            Rect rect = selectedElement.GetViewRect();
            drugOffset.x = position.x - rect.x;
            drugOffset.y = position.y - rect.y;
        }
    }

    /// <summary>
    /// マウスがドラッグされたときの処理
    /// ドラッグ中であれば、ドラッグと同時に対象のノードを移動する
    /// </summary>
    public void OnMouseDrag(Vector2 position)
    {
        if (isDrugging == true)
        {
            Rect rect = selectedElement.GetViewRect ();
            rect.x = position.x - drugOffset.x;
            rect.y = position.y - drugOffset.y;
            selectedElement.SetViewRect(rect);
        }
    }

    /// <summary>
    /// マウスの左ボタンが離されたときの処理
    /// ドラッグ状態を解除し、選択ノードをnullにする
    /// </summary>
    public void OnMouseUp(Vector2 position)
    {
        isDrugging = false;
        selectedElement = null;
    }

    /// <summary>
    /// TODO 説明を記述
    /// </summary>
    public void OnScrollWheel()
    {
    }

    /// <summary>
    /// TODO 説明を記述
    /// </summary>
    public void MouseMove(Vector2 position)
    {
    }

    /// <summary>
    /// OnGUIが呼ばれたときの処理
    /// マウスが要素上にあるとき、カーソルアイコンを移動中アイコンに変更する
    /// </summary>
    public void MouseUpdate()
    {
        if (CurrentElement != null)
        {
            Rect rect = CurrentElement.GetViewRect();
            EditorGUIUtility.AddCursorRect (rect, MouseCursor.MoveArrow);
        }
    }
}
