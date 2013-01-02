using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上の選択可能オブジェクトを表す基底クラス
/// </summary>
public abstract class SelectableElementBase : DiagramElementBase, ISelectableElement
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public SelectableElementBase(IRootObject root) : base(root)
    {
    }
}
