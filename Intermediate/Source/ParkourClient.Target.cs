using UnrealBuildTool;

public class ParkourClientTarget : TargetRules
{
	public ParkourClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Parkour");
	}
}
