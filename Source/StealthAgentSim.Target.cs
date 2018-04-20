// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class StealthAgentSimTarget : TargetRules
{
	public StealthAgentSimTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.Add("StealthAgentSim");
	}
}
