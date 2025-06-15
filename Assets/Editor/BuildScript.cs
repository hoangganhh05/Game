using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript
{
    static void PerformIOSBuild()
    {
        string buildPath = "build/ios";
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" }; // đổi tên scene nếu khác
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
