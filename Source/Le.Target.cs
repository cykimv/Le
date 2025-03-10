using UnrealBuildTool;
using System.Collections.Generic;

public class LeTarget : TargetRules
{
	public LeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("Le");
	}
}
