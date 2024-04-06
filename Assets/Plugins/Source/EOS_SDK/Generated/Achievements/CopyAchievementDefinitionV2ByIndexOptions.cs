// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.CopyAchievementDefinitionByIndex" /> function.
	/// </summary>
	public struct CopyAchievementDefinitionV2ByIndexOptions
	{
		/// <summary>
		/// Index of the achievement definition to retrieve from the cache.
		/// </summary>
		public uint AchievementIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyAchievementDefinitionV2ByIndexOptionsInternal : ISettable<CopyAchievementDefinitionV2ByIndexOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_AchievementIndex;

		public uint AchievementIndex
		{
			set
			{
				m_AchievementIndex = value;
			}
		}

		public void Set(ref CopyAchievementDefinitionV2ByIndexOptions other)
		{
			m_ApiVersion = AchievementsInterface.Copyachievementdefinitionv2ByindexApiLatest;
			AchievementIndex = other.AchievementIndex;
		}

		public void Set(ref CopyAchievementDefinitionV2ByIndexOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AchievementsInterface.Copyachievementdefinitionv2ByindexApiLatest;
				AchievementIndex = other.Value.AchievementIndex;
			}
		}

		public void Dispose()
		{
		}
	}
}