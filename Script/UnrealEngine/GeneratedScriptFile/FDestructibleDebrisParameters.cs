using System;
namespace UnrealEngine
{
	/// <summary>Parameters that pertain to chunk debris-level settings.</summary>
	public partial struct FDestructibleDebrisParameters
	{
		/// <summary>
		/// "Debris chunks" (see debrisDepth, above) will be destroyed after a time (in seconds)
		/// separated from non-debris chunks.  The actual lifetime is interpolated between these
		/// two bDebrisTimeout, based upon the module's LOD setting.  To disable lifetime, clear the
		/// bDebrisTimeout flag in the flags field.
		/// If debrisLifetimeMax < debrisLifetimeMin, the mean of the two is used for both.
		/// Default debrisLifetimeMin = 1.0, debrisLifetimeMax = 10.0f.
		/// </summary>
		public float DebrisLifetimeMin;
		public float DebrisLifetimeMax;
		/// <summary>
		/// "Debris chunks" (see debrisDepth, above) will be destroyed if they are separated from
		/// their origin by a distance greater than maxSeparation.  The actual maxSeparation is
		/// interpolated between these two values, based upon the module's LOD setting.  To disable
		/// maxSeparation, clear the bDebrisMaxSeparation flag in the flags field.
		/// If debrisMaxSeparationMax < debrisMaxSeparationMin, the mean of the two is used for both.
		/// Default debrisMaxSeparationMin = 1.0, debrisMaxSeparationMax = 10.0f.
		/// </summary>
		public float DebrisMaxSeparationMin;
		public float DebrisMaxSeparationMax;
		/// <summary>
		/// "Debris chunks" (see debrisDepth, above) will be destroyed if they leave this box.
		/// The box translates with the destructible actor's initial position, but does not
		/// rotate or scale.
		/// </summary>
		public FBox ValidBounds;
		
	}
	
}
