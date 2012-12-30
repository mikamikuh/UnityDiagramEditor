using UnityEngine;
using System.Collections;

/// <summary>
/// ダイアグラム上の要素が必要とするインタフェース
/// </summary>
public interface IDiagramElement
{
    /// <summary>
    /// 要素の描画処理を実装する
    /// </summary>
    void OnGUI();

    /// <summary>
    /// Unityが選択中のIRootObjectを取得する
    /// </summary>
    /// <returns>
    /// 選択中のIRootObject
    /// </returns>
    IRootObject GetRootObject();
}
