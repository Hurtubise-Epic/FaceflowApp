// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class FaceflowLive : ModuleRules
{
	private string ThirdPartyPath
        {
            get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../ThirdParty/")); }
        }

    private string SocketIOThirdParty
    {
        get { return Path.GetFullPath(Path.Combine(ThirdPartyPath, "SocketIO")); }
    }

    private string BoostThirdParty
    {
        get { return Path.GetFullPath(Path.Combine(ThirdPartyPath, "Boost")); }
    }

    public FaceflowLive(ReadOnlyTargetRules Target) : base(Target)
	{
		
		
		
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseRTTI = true;
        bEnableExceptions = true;

        PublicIncludePaths.AddRange(
            new string[] {
                    Path.Combine(ModuleDirectory, "Public"),
            }
            );


        PrivateIncludePaths.AddRange(
            new string[] {
                    Path.Combine(ModuleDirectory, "Private"),
                    Path.Combine(ModuleDirectory, "Private/internal"),
                    Path.Combine(ThirdPartyPath, "websocketpp"),
                    Path.Combine(ThirdPartyPath, "asio/asio/include"),
                    Path.Combine(ThirdPartyPath, "rapidjson/include"),
            }
            );

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"LiveLinkInterface",
                "SIOJson",
                "Messaging",
                "CoreUtility",
            });

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"InputCore",
				"Json",
				"JsonUtilities",
				"Networking",
				"Slate",
				"SlateCore",
                "SocketIOLib",
                "Sockets",
			});

    }
}
