using UnityEditor;
using UnityEngine;

public static class WebGLBuild
{
    [MenuItem("Build/WebGL")]
    public static void BuildWebGL()
    {
        string[] scenes = new string[] { "Assets/Scenes/Chapter1.unity", "Assets/Scenes/Chapter2.unity" };
        string path = "Build/WebGL";
        BuildPipeline.BuildPlayer(scenes, path, BuildTarget.WebGL, BuildOptions.None);
        Debug.Log("WebGL build completed: " + path);
    }
}
