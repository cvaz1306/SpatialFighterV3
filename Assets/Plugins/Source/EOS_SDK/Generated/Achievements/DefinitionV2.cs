// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Contains information about a single achievement definition with localized text.
	/// </summary>
	public struct DefinitionV2
	{
		/// <summary>
		/// Achievement ID that can be used to uniquely identify the achievement.
		/// </summary>
		public Utf8String AchievementId { get; set; }

		/// <summary>
		/// Localized display name for the achievement when it has been unlocked.
		/// </summary>
		public Utf8String UnlockedDisplayName { get; set; }

		/// <summary>
		/// Localized description for the achievement when it has been unlocked.
		/// </summary>
		public Utf8String UnlockedDescription { get; set; }

		/// <summary>
		/// Localized display name for the achievement when it is locked or hidden.
		/// </summary>
		public Utf8String LockedDisplayName { get; set; }

		/// <summary>
		/// Localized description for the achievement when it is locked or hidden.
		/// </summary>
		public Utf8String LockedDescription { get; set; }

		/// <summary>
		/// Localized flavor text that can be used by the game in an arbitrary manner. This may be null if there is no data configured in the dev portal.
		/// </summary>
		public Utf8String FlavorText { get; set; }

		/// <summary>
		/// URL of an icon to display for the achievement when it is unlocked. This may be null if there is no data configured in the dev portal.
		/// </summary>
		public Utf8String UnlockedIconURL { get; set; }

		/// <summary>
		/// URL of an icon to display for the achievement when it is locked or hidden. This may be null if there is no data configured in the dev portal.
		/// </summary>
		public Utf8String LockedIconURL { get; set; }

		/// <summary>
		/// <see langword="true" /> if the achievement is hidden; <see langword="false" /> otherwise.
		/// </summary>
		public bool IsHidden { get; set; }

		/// <summary>
		/// Array of `<see cref="Achievements.StatThresholds" />` that need to be satisfied to unlock this achievement. Consists of Name and Threshold Value.
		/// </summary>
		public StatThresholds[] StatThresholds { get; set; }

		internal void Set(ref DefinitionV2Internal other)
		{
			AchievementId = other.AchievementId;
			UnlockedDisplayName = other.UnlockedDisplayName;
			UnlockedDescription = other.UnlockedDescription;
			LockedDisplayName = other.LockedDisplayName;
			LockedDescription = other.LockedDescription;
			FlavorText = other.FlavorText;
			UnlockedIconURL = other.UnlockedIconURL;
			LockedIconURL = other.LockedIconURL;
			IsHidden = other.IsHidden;
			StatThresholds = other.StatThresholds;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DefinitionV2Internal : IGettable<DefinitionV2>, ISettable<DefinitionV2>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AchievementId;
		private System.IntPtr m_UnlockedDisplayName;
		private System.IntPtr m_UnlockedDescription;
		private System.IntPtr m_LockedDisplayName;
		private System.IntPtr m_LockedDescription;
		private System.IntPtr m_FlavorText;
		private System.IntPtr m_UnlockedIconURL;
		private System.IntPtr m_LockedIconURL;
		private int m_IsHidden;
		private uint m_StatThresholdsCount;
		private System.IntPtr m_StatThresholds;

		public Utf8String AchievementId
		{
			get
			{
				Utf8String value;
				Helper.Get(m_AchievementId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AchievementId);
			}
		}

		public Utf8String UnlockedDisplayName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_UnlockedDisplayName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_UnlockedDisplayName);
			}
		}

		public Utf8String UnlockedDescription
		{
			get
			{
				Utf8String value;
				Helper.Get(m_UnlockedDescription, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_UnlockedDescription);
			}
		}

		public Utf8String LockedDisplayName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LockedDisplayName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LockedDisplayName);
			}
		}

		public Utf8String LockedDescription
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LockedDescription, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LockedDescription);
			}
		}

		public Utf8String FlavorText
		{
			get
			{
				Utf8String value;
				Helper.Get(m_FlavorText, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_FlavorText);
			}
		}

		public Utf8String UnlockedIconURL
		{
			get
			{
				Utf8String value;
				Helper.Get(m_UnlockedIconURL, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_UnlockedIconURL);
			}
		}

		public Utf8String LockedIconURL
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LockedIconURL, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LockedIconURL);
			}
		}

		public bool IsHidden
		{
			get
			{
				bool value;
				Helper.Get(m_IsHidden, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_IsHidden);
			}
		}

		public StatThresholds[] StatThresholds
		{
			get
			{
				StatThresholds[] value;
				Helper.Get<StatThresholdsInternal, StatThresholds>(m_StatThresholds, out value, m_StatThresholdsCount);
				return value;
			}

			set
			{
				Helper.Set<StatThresholds, StatThresholdsInternal>(ref value, ref m_StatThresholds, out m_StatThresholdsCount);
			}
		}

		public void Set(ref DefinitionV2 other)
		{
			m_ApiVersion = AchievementsInterface.Definitionv2ApiLatest;
			AchievementId = other.AchievementId;
			UnlockedDisplayName = other.UnlockedDisplayName;
			UnlockedDescription = other.UnlockedDescription;
			LockedDisplayName = other.LockedDisplayName;
			LockedDescription = other.LockedDescription;
			FlavorText = other.FlavorText;
			UnlockedIconURL = other.UnlockedIconURL;
			LockedIconURL = other.LockedIconURL;
			IsHidden = other.IsHidden;
			StatThresholds = other.StatThresholds;
		}

		public void Set(ref DefinitionV2? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AchievementsInterface.Definitionv2ApiLatest;
				AchievementId = other.Value.AchievementId;
				UnlockedDisplayName = other.Value.UnlockedDisplayName;
				UnlockedDescription = other.Value.UnlockedDescription;
				LockedDisplayName = other.Value.LockedDisplayName;
				LockedDescription = other.Value.LockedDescription;
				FlavorText = other.Value.FlavorText;
				UnlockedIconURL = other.Value.UnlockedIconURL;
				LockedIconURL = other.Value.LockedIconURL;
				IsHidden = other.Value.IsHidden;
				StatThresholds = other.Value.StatThresholds;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AchievementId);
			Helper.Dispose(ref m_UnlockedDisplayName);
			Helper.Dispose(ref m_UnlockedDescription);
			Helper.Dispose(ref m_LockedDisplayName);
			Helper.Dispose(ref m_LockedDescription);
			Helper.Dispose(ref m_FlavorText);
			Helper.Dispose(ref m_UnlockedIconURL);
			Helper.Dispose(ref m_LockedIconURL);
			Helper.Dispose(ref m_StatThresholds);
		}

		public void Get(out DefinitionV2 output)
		{
			output = new DefinitionV2();
			output.Set(ref this);
		}
	}
}