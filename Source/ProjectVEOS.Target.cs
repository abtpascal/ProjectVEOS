// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVEOSTarget : TargetRules
{
	public ProjectVEOSTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectVEOS261114");
	}

	//
	// TargetRules interface.
	//
}