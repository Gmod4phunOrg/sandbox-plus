﻿using Sandbox;

public partial class ThrusterEntity
{
	private Particles effects;

	public virtual void OnFrame()
	{
		UpdateEffects();
	}

	protected void CreateEffects()
	{
		if ( effects != null )
			return;

		effects = Particles.Create( "particles/physgun_end_nohit.vpcf" );
	}

	protected virtual void KillEffects()
	{
		if ( effects == null )
			return;

		effects.Destory( false );
		effects = null;
	}

	protected virtual void UpdateEffects()
	{
		if ( Enabled )
		{
			CreateEffects();
		}
		else
		{
			KillEffects();
		}

		if ( effects == null )
			return;

		effects.SetPos( 0, WorldPos + WorldRot.Up * 20 );
	}
}
