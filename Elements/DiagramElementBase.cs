using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上の表示可能要素であることを示す基底クラス
/// </summary>
[System.Serializable]
public abstract class DiagramElementBase : IDiagramElement
{
    /// <summary>
    /// オーバーライドし、GUI処理の記述を実装すること
    /// </summary>
    public virtual void OnGUI ()
    {
        throw new System.NotImplementedException ();
    }

    /// <summary>
    /// オーバーライドし、IRootObjectの実装を返す処理の記述を実装すること
    /// </summary>
    /// <returns>
    /// 選択中のIRootObject
    /// </returns>
    public virtual IRootObject GetRootObject()
    {
        throw new System.NotImplementedException ();
    }
}
