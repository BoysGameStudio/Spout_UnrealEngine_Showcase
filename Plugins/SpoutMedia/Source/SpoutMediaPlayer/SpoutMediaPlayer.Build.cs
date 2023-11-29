// Copyright Alan Liu 2022-2023. All Rights Reserved.

using UnrealBuildTool;

public class SpoutMediaPlayer : ModuleRules
{
	public SpoutMediaPlayer(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		bUsePrecompiled = true;

		OptimizeCode = CodeOptimization.Never;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"RenderCore",
				"Media",
				"SpoutLibrary",
				"RHI",
				"RenderCore"
			}
		);
	}
}