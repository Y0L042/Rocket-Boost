using UnityEngine;
using UnityEditor;

// When editing multiple projects, the LossyScale proeprty will display only the value of the first/main 
// selected transform, which does not apply to all other selected transforms. So be careful when changing the LossyScale, 
// as the scale values from this first transform are taken as base. 
[CanEditMultipleObjects]
[CustomEditor(typeof(Transform))]
public class TransformLossyScaleEditor : Editor
{
    Editor defaultEditor;

    private void OnEnable()
    {
        // https://github.com/Unity-Technologies/UnityCsReference/blob/master/Editor/Mono/Inspector/TransformInspector.cs
        defaultEditor = CreateEditor(targets, typeof(Editor).Assembly.GetType("UnityEditor.TransformInspector"));
    }

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector(); // Doesn't display rotation correctly
        defaultEditor.OnInspectorGUI();
        Transform transform = (Transform)target;
        Vector3 lossyScalePrev = transform.lossyScale;
        Vector3 lossyScaleCurrent = EditorGUILayout.Vector3Field("LossyScale", lossyScalePrev);
        if (lossyScalePrev != lossyScaleCurrent)
        {
            // Only adjust the axis that have actually changed:
            bool hasXChanged = HasAxisValueChanged(lossyScaleCurrent.x, lossyScalePrev.x);
            bool hasYChanged = HasAxisValueChanged(lossyScaleCurrent.y, lossyScalePrev.y);
            bool hasZChanged = HasAxisValueChanged(lossyScaleCurrent.z, lossyScalePrev.z);
            var sceneHierarchySelection = Selection.objects;
            foreach (var sceneObject in sceneHierarchySelection)
            {
                if (sceneObject is GameObject go)
                {
                    Vector3 tScalePrev = go.transform.lossyScale;
                    Vector3 tScaleNew = tScalePrev;
                    if (hasXChanged)
                        tScaleNew.x = lossyScaleCurrent.x;
                    if (hasYChanged)
                        tScaleNew.y = lossyScaleCurrent.y;
                    if (hasZChanged)
                        tScaleNew.z = lossyScaleCurrent.z;
                    if (tScalePrev != tScaleNew)
                    {
                        SetLossyScale(go.transform, tScaleNew);
                    }
                }
            }
        }
    }

    private bool HasAxisValueChanged(float axisCurrent, float axisPrev)
    {
        return Mathf.Abs(axisCurrent - axisPrev) >= Mathf.Epsilon;
    }

    private void SetLossyScale(Transform t, Vector3 lossyScale)
    {
        // Record changes so it they can be undone in the inspector
        Undo.RecordObject(t, "Set transform lossy scale");
        Transform parent = t.parent;
        if (parent != null)
        {
            t.SetParent(null);
        }
        t.localScale = lossyScale;
        if (parent != null)
        {
            t.SetParent(parent);
        }
    }
}