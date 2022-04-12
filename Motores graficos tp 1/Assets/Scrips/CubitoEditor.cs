using UnityEngine;
using UnityEditor; 

[CustomEditor(typeof(Cubito))]
public class CubitoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Cubito cubito = (Cubito)target;

        GUILayout.Label("Movimiento:", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("x+1")) cubito.movimiento("x+1");

        if (GUILayout.Button("x-1")) cubito.movimiento("x-1");

        if (GUILayout.Button("y+1")) cubito.movimiento("y+1");

        if (GUILayout.Button("y-1")) cubito.movimiento("y-1");

        if (GUILayout.Button("z+1")) cubito.movimiento("z+1");

        if (GUILayout.Button("z-1")) cubito.movimiento("z-1");

        if (GUILayout.Button("0")) cubito.movimiento("0");

            GUILayout.EndHorizontal();

        GUILayout.Label("Tamaño:", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("-1")) cubito.tamaño("resta");

        if (GUILayout.Button("+1")) cubito.tamaño("suma") ;

        GUILayout.EndHorizontal();

        GUILayout.Label("Rotacion:", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("x+1")) cubito.rotacion("x+1");

        if (GUILayout.Button("x-1")) cubito.rotacion("x-1");

        if (GUILayout.Button("y+1")) cubito.rotacion("y+1");

        if (GUILayout.Button("y-1")) cubito.rotacion("y-1");

        if (GUILayout.Button("z+1")) cubito.rotacion("z+1");

        if (GUILayout.Button("z-1")) cubito.rotacion("z-1");

        if (GUILayout.Button("0")) cubito.rotacion("0");

        GUILayout.EndHorizontal();

    }
}
