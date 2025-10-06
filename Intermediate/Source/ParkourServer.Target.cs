using UnrealBuildTool;

public class ParkourServerTarget : TargetRules
{
	public ParkourServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Parkour");
	}
}
