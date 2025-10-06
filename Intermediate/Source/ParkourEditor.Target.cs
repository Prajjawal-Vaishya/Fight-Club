using UnrealBuildTool;

public class ParkourEditorTarget : TargetRules
{
	public ParkourEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Parkour");
	}
}
