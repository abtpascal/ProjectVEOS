// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVEOSEditorTarget : TargetRules
{
	public ProjectVEOSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        bUseUnityBuild = false;
        bUsePCHFiles = false;

        ExtraModuleNames.Add("ProjectVEOS261114");
    }
}