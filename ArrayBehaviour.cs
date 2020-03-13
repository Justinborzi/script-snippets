using UnityEngine;
using UnityEditor;

public class NamedArray : PropertyAttribute
{
    public readonly string[] names;
    public NamedArray(string[] names) { this.names = names; }
}

[CustomPropertyDrawer(typeof(NamedArray))]
public class NamedArrayDrawer : PropertyDrawer
{
    public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
    {
        try
        {
            int pos = int.Parse(property.propertyPath.Split('[', ']')[1]);
            EditorGUI.PropertyField(rect, property, new GUIContent(((NamedArray)attribute).names[pos]));
        }
        catch
        {
            EditorGUI.PropertyField(rect, property, label);
        }
    }
}