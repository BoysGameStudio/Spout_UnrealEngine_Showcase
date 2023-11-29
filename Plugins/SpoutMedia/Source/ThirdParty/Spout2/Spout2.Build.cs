// Copyright Alan Liu 2022-2023. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class Spout2 : ModuleRules
{
	public Spout2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bUsePrecompiled = true;
		bEnableExceptions = true;
		bEnableUndefinedIdentifierWarnings = false;
		OptimizeCode = CodeOptimization.Never;

		PublicIncludePaths.AddRange(
			new string[]
			{
				Path.Combine(ModuleDirectory, "SpoutDX"),
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"RHI",
				"RenderCore",
				"Projects",
				"MediaIOCore",
				"ImageWriteQueue"
			}
		);

		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PrivateDependencyModuleNames.AddRange(
				new[]
				{
					"D3D12RHI"
				});

			PrivateIncludePaths.AddRange(
				new[]
				{
					Path.Combine(EngineDirectory, "Source/Runtime/D3D12RHI/Private"),
					Path.Combine(EngineDirectory, "Source/Runtime/D3D12RHI/Private/Windows")
				});

			AddEngineThirdPartyPrivateStaticDependencies(Target, "DX12");
			AddEngineThirdPartyPrivateStaticDependencies(Target, "NVAftermath");
		}
	}
}