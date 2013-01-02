using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上のエッジを表すクラス(シリアライズ可能)
/// </summary>
[System.Serializable]
public abstract class EdgeElementBase : SelectableElementBase, IEdgeElement
{
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
        DiagramUtil.DrawLine3 (GetSourcePosition(), GetDestinationPosition(), Color.red, 1.0f);
    }
}
