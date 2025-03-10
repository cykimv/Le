using UnrealBuildTool;
using System.Collections.Generic;

public class LeEditorTarget : TargetRules
{
	public LeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("Le");
	}
}
