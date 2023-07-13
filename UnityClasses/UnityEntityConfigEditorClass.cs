public class UnityEntityConfigEditorClass : UnityClass
{
	public UnityEntityConfigEditorClass(string filePath) : base(filePath)
	{
	}

	protected override void GenerateLines()
	{
		AddLine("using UnityEditor;");
		AddLine("");
		AddLine($"[CustomEditor(typeof({entity}Config))]");
		AddLine($"public class {entity}ConfigEditor : EntityConfigAssetEditorBase<{entity}ComponentConfig, {entity}Config>");
		AddLine("{");
		AddLine("	protected override void OnEnable()");
		AddLine("	{");
		AddLine("		base.OnEnable();");
		AddLine("	}");
		AddLine("");
		AddLine("	public override void OnInspectorGUI()");
		AddLine("	{");
		AddLine("		using (var check = new EditorGUI.ChangeCheckScope())");
		AddLine("		{");
		AddLine("			DrawComponentList();");
		AddLine("");
		AddLine("			if (check.changed)");
		AddLine("			{");
		AddLine("				EditorUtility.SetDirty(entityConfigAsset);");
		AddLine("				serializedObject.ApplyModifiedProperties();");
		AddLine("			}");
		AddLine("		}");
		AddLine("	}");
		AddLine("}");
	}
}