// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class StealthAgentSim : ModuleRules
{
	public StealthAgentSim(ReadOnlyTargetRules Target) : base (Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "AIModule", "GameplayTasks", "Paper2D" });

        PrivateDependencyModuleNames.AddRange(new string[] {  });
    }
}
