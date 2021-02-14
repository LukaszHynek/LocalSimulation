// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LocalPhysics: ModuleRules
{
	public LocalPhysics(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
                "Engine",
                "AnimGraphRuntime",
                "PhysX",
                "PhysicsCore",
                "APEX"  //This is not really needed, but the includes are all coupled. Not really an issue at the moment, could be broken out in the future

			}
		);

        PrivateIncludePaths.AddRange(
            new string[] {
                "Runtime/LocalPhysics/Private"
            });
    }
}
