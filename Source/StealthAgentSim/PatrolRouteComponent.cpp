// Fill out your copyright notice in the Description page of Project Settings.

#include "PatrolRouteComponent.h"
#include "StealthAgentSim.h"



TArray<AActor*> UPatrolRouteComponent::GetWaypoints() const
{
	return WaypointTargetPoints;
}