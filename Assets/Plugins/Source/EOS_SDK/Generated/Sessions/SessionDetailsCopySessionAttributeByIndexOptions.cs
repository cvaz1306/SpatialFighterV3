// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionDetails.CopySessionAttributeByIndex" /> function.
	/// </summary>
	public struct SessionDetailsCopySessionAttributeByIndexOptions
	{
		/// <summary>
		/// The index of the attribute to retrieve
		/// <seealso cref="SessionDetails.GetSessionAttributeCount" />
		/// </summary>
		public uint AttrIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionDetailsCopySessionAttributeByIndexOptionsInternal : ISettable<SessionDetailsCopySessionAttributeByIndexOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_AttrIndex;

		public uint AttrIndex
		{
			set
			{
				m_AttrIndex = value;
			}
		}

		public void Set(ref SessionDetailsCopySessionAttributeByIndexOptions other)
		{
			m_ApiVersion = SessionDetails.SessiondetailsCopysessionattributebyindexApiLatest;
			AttrIndex = other.AttrIndex;
		}

		public void Set(ref SessionDetailsCopySessionAttributeByIndexOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionDetails.SessiondetailsCopysessionattributebyindexApiLatest;
				AttrIndex = other.Value.AttrIndex;
			}
		}

		public void Dispose()
		{
		}
	}
}