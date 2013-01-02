using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// エッジの作成が成功したときに呼ばれるデリゲート
/// </summary>
public delegate void CreateSuccessDelegate(INodeElement source, INodeElement destination);

/// <summary>
/// エッジの作成が終了した時に呼ばれるデリゲート
/// </summary>
public delegate void CreateFinishedDelegate();

/// <summary>
/// エッジ作成/変更時に使用するハンドラ
/// </summary>
public class EdgeCreateInputHandler : INodeInputHandler
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
    /// エッジの編集が完了したときに呼ばれるデリゲート(Handlerを元に戻す)
    /// </summary>
    private CreateFinishedDelegate finishedDelegate;

    /// <summary>
    /// エッジの作成が成功したときに呼ばれるデリゲート
    /// </summary>
    private CreateSuccessDelegate successDelegate;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EdgeCreateInputHandler(CreateSuccessDelegate successDelegate, CreateFinishedDelegate failedDelegate)
    {
        this.successDelegate = successDelegate;
        this.finishedDelegate = failedDelegate;
    }

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
    /// そうでなければ、エッジ作成モードから抜ける
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
        }
        else
        {
            finishedDelegate();
        }
    }

    /// <summary>
    /// マウスがドラッグされたときの処理
    /// ドラッグ中であれば、ドラッグと同時に対象のノードを移動する
    /// </summary>
    public void OnMouseDrag(Vector2 destination)
    {
    }

    /// <summary>
    /// マウスの左ボタンが離されたときの処理
    /// ドラッグ状態を解除し、選択ノードをnullにする
    /// </summary>
    public void OnMouseUp(Vector2 position)
    {
        if (CurrentElement != null && selectedElement != CurrentElement)
        {
            successDelegate(selectedElement, CurrentElement);
        }

        finishedDelegate();
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
    /// 作成中のマウスに追随するエッジを描画する
    /// </summary>
    public void MouseUpdate(Vector2 destination)
    {
        // 一時的なエッジの描画
        if (isDrugging == true)
        {
            Rect rect = selectedElement.GetViewRect ();
            Vector2 source = new Vector2 ();
            source.x = rect.x + (rect.width / 2);
            source.y = rect.y + (rect.height / 2);

            DiagramUtil.DrawLine3 (source, destination, Color.red, 1.0f);
        }

        // カーソルアイコンの描画
        if (CurrentElement != null)
        {
            Rect rect = CurrentElement.GetViewRect();
            EditorGUIUtility.AddCursorRect (rect, MouseCursor.ArrowPlus);
        }
    }
}
