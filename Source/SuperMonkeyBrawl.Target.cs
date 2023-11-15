// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SuperMonkeyBrawlTarget : TargetRules
{
	public SuperMonkeyBrawlTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SuperMonkeyBrawl");
	}
}
