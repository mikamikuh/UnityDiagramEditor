using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上のエッジを表すクラス(シリアライズ可能)
/// </summary>
[System.Serializable]
public abstract class EdgeElementBase : SelectableElementBase, IEdgeElement
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public EdgeElementBase(IRootObject root) : base(root)
    {
    }

    /// <summary>
    /// エッジ始点の座標を取得する
    /// </summary>
    public abstract Vector2 GetDestinationPosition();

    /// <summary>
    /// エッジ終点の座標を取得する
    /// </summary>
    public abstract Vector2 GetSourcePosition();

    /// <summary>
    /// ノードの矩形を描画する
    /// </summary>
    public override void OnGUI()
    {
        // TODO DiagramUtilを自前で(必要な分だけ)作成する
        DiagramUtil.DrawLine (GetSourcePosition(), GetDestinationPosition(), Color.red, 1.0f, true, null, DiagramUtil.DestinationTexture);
    }
}
