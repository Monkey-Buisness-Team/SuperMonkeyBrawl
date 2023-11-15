// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SuperMonkeyBrawlEditorTarget : TargetRules
{
	public SuperMonkeyBrawlEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SuperMonkeyBrawl");
	}
}
