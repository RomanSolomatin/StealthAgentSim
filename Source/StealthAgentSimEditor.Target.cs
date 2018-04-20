// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class StealthAgentSimEditorTarget : TargetRules
{
	public StealthAgentSimEditorTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.Add("StealthAgentSim");

        bUseUnityBuild = false;
        bUsePCHFiles = false;
	}
}
