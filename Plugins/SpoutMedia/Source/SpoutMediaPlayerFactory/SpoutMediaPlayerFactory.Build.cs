// Copyright Alan Liu 2022-2023. All Rights Reserved.

using UnrealBuildTool;

public class SpoutMediaPlayerFactory : ModuleRules
{
    public SpoutMediaPlayerFactory(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUsePrecompiled = true;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "Media",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore", 
                "SpoutMediaPlayer", 
            }
        );
    }
}