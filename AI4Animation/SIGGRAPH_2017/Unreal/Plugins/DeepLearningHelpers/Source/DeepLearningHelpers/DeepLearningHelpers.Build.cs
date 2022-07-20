// juaxix - 2020 - xixgames

using UnrealBuildTool;

public class DeepLearningHelpers : ModuleRules
{
	public DeepLearningHelpers(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"Eigen", 
                "Engine",
				"ControlRig"
			}
			);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"InputCore"
			}
			);


	}
}
