// Copyright (c) 2014 Moritz Wundke & Ruben Avalos Elvira

namespace UnrealBuildTool.Rules
{
	public class AsyncPackageStreamer : ModuleRules
	{
#if WITH_FORWARDED_MODULE_RULES_CTOR
		public AsyncPackageStreamer(ReadOnlyTargetRules Target) : base(Target)
#else
		public AsyncPackageStreamer(TargetInfo Target)
#endif
		{
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					"Developer/AsyncPackageStreamer/Private",
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
                    "CoreUObject",
                    "Engine",
                    "NetworkFile"
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
                    "Core",
                    "CoreUObject",
                    "Engine",
                    "PakFile",
                    "Sockets",
                    "StreamingFile",
                    "NetworkFile"
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
		}
	}
}
