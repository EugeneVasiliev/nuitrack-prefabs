using UnityEditor;

using nuitrack;
using NuitrackSDK.Avatar;


namespace NuitrackSDKEditor.Avatar
{
    [CustomEditor(typeof(BaseAvatar), true)]
    public class BaseAvatarEditor : TrackedUserEditor
    {
        protected virtual JointType SelectJoint { get; set; } = JointType.None;

        public override void DrawDefaultInspector()
        {
            DrawSkeletonSettings();
            base.DrawDefaultInspector();
            DrawAvatarGUI();
        }

        /// <summary>
        /// Draw basic avatar settings
        /// </summary>
        protected void DrawSkeletonSettings()
        {
            SerializedProperty jointConfidence = serializedObject.FindProperty("jointConfidence");
            jointConfidence.floatValue = EditorGUILayout.Slider("Joint confidence", jointConfidence.floatValue, 0, 1);
            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Override this method to add your own settings and parameters in the Inspector.
        /// </summary>
        protected virtual void DrawAvatarGUI() { }      
    }
}