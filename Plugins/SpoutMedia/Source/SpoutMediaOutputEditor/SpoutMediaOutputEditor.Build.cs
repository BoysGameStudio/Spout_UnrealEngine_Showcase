// Copyright Alan Liu 2022-2023. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class SpoutMediaOutputEditor : ModuleRules
{
    public SpoutMediaOutputEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bUsePrecompiled = true;
        bEnableExceptions = true;
        OptimizeCode = CodeOptimization.Never;

        PublicIncludePaths.AddRange(
            new string[]
            {
            }
        );

        PrivateIncludePaths.AddRange(
            new[]
            {
                "SpoutMediaOutputEditor/Private"
            }
        );

        PublicDependencyModuleNames.AddRange(
            new[]
            {
                "Core"
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
                "ImageWriteQueue",
                "UnrealEd",
                "SpoutMediaOutput"
            }
        );

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
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