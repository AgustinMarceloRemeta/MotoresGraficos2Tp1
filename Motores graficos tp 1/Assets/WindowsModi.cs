using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WindowsModi : EditorWindow
{
    [MenuItem("Window/Spawneador")]

    public static void ShowWindow() {
        GetWindow<WindowsModi>("Spawneador");
    }
    private void OnGUI()
    {
        GUILayout.Label("Spawnear objeto:", EditorStyles.boldLabel);
        if (GUILayout.Button("Cubito")) spawn("cubo") ;
        if (GUILayout.Button("Esfera")) spawn("Esfera");
        if (GUILayout.Button("Capsula")) spawn("Capsula");
    }
    void spawn(string tipo)
    {
        GameObject Objeto = null;
        if (tipo == "cubo") Objeto = GameObject.FindGameObjectWithTag("Cubito");
        if (tipo == "Esfera") Objeto = GameObject.FindGameObjectWithTag("Esferita");
        else if (tipo == "Capsula") Objeto = GameObject.FindGameObjectWithTag("Capsula");
        GameObject.Instantiate(Objeto);
        Objeto.transform.position = new Vector3(0, 0, 0);

    }
}
