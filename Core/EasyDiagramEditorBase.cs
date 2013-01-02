using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// ダイアグラムエディタの基底クラス
/// </summary>
public abstract class EasyDiagramEditorBase : EditorWindow
{
    /// <summary>
    /// ノードのマウス入力ハンドラ
    /// </summary>
    protected INodeInputHandler NodeHandler;

    /// <summary>
    /// エッジの作成時の入力ハンドラ
    /// </summary>
    protected INodeInputHandler EdgeCreateMouseHandler;

    /// <summary>
    /// 保持するルートオブジェクト
    /// </summary>
    protected IRootObject RootObject;

    /// <summary>
    /// コンストラクタ
    /// 各種ハンドラを初期化する
    /// </summary>
    public EasyDiagramEditorBase()
    {
        NodeHandler = new NodeInputHandler();
        EdgeCreateMouseHandler = new EdgeCreateInputHandler(CreateEdge, ChangeNormalMode);
        ChangeNormalMode();
    }

    /// <summary>
    /// 現在のマウス座標の位置にある要素を、CurrentElementとして登録する
    /// </summary>
    public void OnGUI()
    {
        Vector2 position = Event.current.mousePosition;
        InputHandlerRoot.INSTANCE.MouseHandler.CurrentElement = RootObject.GetNodeElement(position);
    }

    /// <summary>
    /// ハンドラをNodeHandlerに変更する
    /// TODO HandlerManagerクラスの作成
    /// </summary>
    public void ChangeNormalMode()
    {
        InputHandlerRoot.INSTANCE.MouseHandler = NodeHandler;
    }

    /// <summary>
    /// ハンドラをEdgeCreateMouseHandlerに変更する
    /// TODO HandlerManagerクラスの作成
    /// </summary>
    public void ChangeEdgeMode()
    {
        InputHandlerRoot.INSTANCE.MouseHandler = EdgeCreateMouseHandler;
    }

    /// <summary>
    /// 遷移元/遷移先フェーズを設定してエッジを作成する
    /// </summary>
    /// <param name='source'>
    /// 遷移元フェーズ ビューモデル
    /// </param>
    /// <param name='destination'>
    /// 遷移先フェーズ ビューモデル
    /// </param>
    public abstract void CreateEdge(INodeElement source, INodeElement destination);
}
