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
        InputHandlerRoot.INSTANCE.MouseHandlers.Add (NodeHandler);
    }

    /// <summary>
    /// 現在のマウス座標の位置にある要素を、CurrentElementとして登録する
    /// </summary>
    public void OnGUI()
    {
        Vector2 position = Event.current.mousePosition;
        NodeHandler.CurrentElement = RootObject.GetNodeElement(position);
    }
}
