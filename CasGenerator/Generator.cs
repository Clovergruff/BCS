using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public static class Generator
{
	public static bool FileDoesntExist(string filePath)
	{
		if (Program.forceOverwrite)
			return true;
			
		return !File.Exists(filePath);
	}

	public static void CreateExtensionClass(string filePath, string entity, string prefix, string component, bool generateConfig) =>
		new UnityExtensionClass(filePath).Generate(entity: entity, prefix: prefix, component: component, generateConfig: generateConfig);

	public static void CreateSystemClass(string filePath, string entity, string component, bool generateConfig) =>
		new UnitySystemClass(filePath).Generate(entity: entity, component: component, generateConfig: generateConfig);

	public static void CreateConfigClass(string filePath, string entity, string component) =>
		new UnityConfigClass(filePath).Generate(entity: entity, component: component);

	public static void CreateMainEntityClass(string filePath, string entity, bool hasUpdate, bool hasFixedUpdate, bool hasLateUpdate) =>
		new UnityEntityClass(filePath).Generate(entity: entity, hasUpdate: hasUpdate, hasFixedUpdate: hasFixedUpdate, hasLateUpdate: hasLateUpdate);

	public static void CreateEntityDataEditorClass(string filePath, string entity) =>
		new UnityEntityDataEditorClass(filePath).Generate(entity: entity);

	public static void CreateComponentConfigClass(string filePath, string entity) =>
		new UnityComponentConfigClass(filePath).Generate(entity: entity);

	public static void CreateComponentConfigEditorClass(string filePath, string entity, string component) =>
		new UnityComponentConfigEditorClass(filePath).Generate(entity: entity, component: component);

	public static void CreateEntityDataClass(string filePath, string entity) =>
		new UnityEntityDataClass(filePath).Generate(entity: entity);

	public static void CreateEntityManagerClass(string filePath, string entity) =>
		new UnityEntityManagerClass(filePath).Generate(entity: entity);

	public static void CreateEntityFactoryClass(string filePath, string entity) =>
		new UnityEntityFactoryClass(filePath).Generate(entity: entity);

	public static void CreateSystemBaseClass(string filePath, string entity, bool hasUpdate, bool hasFixedUpdate, bool hasLateUpdate) =>
		new UnitySystemBaseClass(filePath).Generate(entity: entity, hasUpdate: hasUpdate, hasFixedUpdate: hasFixedUpdate, hasLateUpdate: hasLateUpdate);
}
