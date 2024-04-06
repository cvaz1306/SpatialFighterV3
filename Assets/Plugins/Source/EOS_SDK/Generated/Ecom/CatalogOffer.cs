// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Contains information about a single offer within the catalog. Instances of this structure are
	/// created by <see cref="EcomInterface.CopyOfferByIndex" />. They must be passed to <see cref="EcomInterface.Release" />.
	/// Prices are stored in the lowest denomination for the associated currency. If CurrencyCode is
	/// "USD" then a price of 299 represents "$2.99".
	/// </summary>
	public struct CatalogOffer
	{
		/// <summary>
		/// The index of this offer as it exists on the server.
		/// This is useful for understanding pagination data.
		/// </summary>
		public int ServerIndex { get; set; }

		/// <summary>
		/// Product namespace in which this offer exists
		/// </summary>
		public Utf8String CatalogNamespace { get; set; }

		/// <summary>
		/// The ID of this offer
		/// </summary>
		public Utf8String Id { get; set; }

		/// <summary>
		/// Localized UTF-8 title of this offer
		/// </summary>
		public Utf8String TitleText { get; set; }

		/// <summary>
		/// Localized UTF-8 description of this offer
		/// </summary>
		public Utf8String DescriptionText { get; set; }

		/// <summary>
		/// Localized UTF-8 long description of this offer
		/// </summary>
		public Utf8String LongDescriptionText { get; set; }

		/// <summary>
		/// Deprecated.
		/// <see cref="CatalogItem.TechnicalDetailsText" /> is still valid.
		/// </summary>
		public Utf8String TechnicalDetailsText_DEPRECATED { get; set; }

		/// <summary>
		/// The Currency Code for this offer
		/// </summary>
		public Utf8String CurrencyCode { get; set; }

		/// <summary>
		/// If this value is <see cref="Result.Success" /> then OriginalPrice, CurrentPrice, and DiscountPercentage contain valid data.
		/// Otherwise this value represents the error that occurred on the price query.
		/// </summary>
		public Result PriceResult { get; set; }

		/// <summary>
		/// The original price of this offer as a 32-bit number is deprecated.
		/// </summary>
		public uint OriginalPrice_DEPRECATED { get; set; }

		/// <summary>
		/// The current price including discounts of this offer as a 32-bit number is deprecated..
		/// </summary>
		public uint CurrentPrice_DEPRECATED { get; set; }

		/// <summary>
		/// A value from 0 to 100 define the percentage of the OrignalPrice that the CurrentPrice represents
		/// </summary>
		public byte DiscountPercentage { get; set; }

		/// <summary>
		/// Contains the POSIX timestamp that the offer expires or -1 if it does not expire
		/// </summary>
		public long ExpirationTimestamp { get; set; }

		/// <summary>
		/// The number of times that the requesting account has purchased this offer.
		/// This value is deprecated and the backend no longer returns this value.
		/// </summary>
		public uint PurchasedCount_DEPRECATED { get; set; }

		/// <summary>
		/// The maximum number of times that the offer can be purchased.
		/// A negative value implies there is no limit.
		/// </summary>
		public int PurchaseLimit { get; set; }

		/// <summary>
		/// True if the user can purchase this offer.
		/// </summary>
		public bool AvailableForPurchase { get; set; }

		/// <summary>
		/// The original price of this offer as a 64-bit number.
		/// </summary>
		public ulong OriginalPrice64 { get; set; }

		/// <summary>
		/// The current price including discounts of this offer as a 64-bit number.
		/// </summary>
		public ulong CurrentPrice64 { get; set; }

		/// <summary>
		/// The decimal point for the provided price. For example, DecimalPoint '2' and CurrentPrice64 '12345' would be '123.45'.
		/// </summary>
		public uint DecimalPoint { get; set; }

		/// <summary>
		/// Timestamp indicating when the time when the offer was released. Can be ignored if set to -1.
		/// </summary>
		public long ReleaseDateTimestamp { get; set; }

		/// <summary>
		/// Timestamp indicating the effective date of the offer. Can be ignored if set to -1.
		/// </summary>
		public long EffectiveDateTimestamp { get; set; }

		internal void Set(ref CatalogOfferInternal other)
		{
			ServerIndex = other.ServerIndex;
			CatalogNamespace = other.CatalogNamespace;
			Id = other.Id;
			TitleText = other.TitleText;
			DescriptionText = other.DescriptionText;
			LongDescriptionText = other.LongDescriptionText;
			TechnicalDetailsText_DEPRECATED = other.TechnicalDetailsText_DEPRECATED;
			CurrencyCode = other.CurrencyCode;
			PriceResult = other.PriceResult;
			OriginalPrice_DEPRECATED = other.OriginalPrice_DEPRECATED;
			CurrentPrice_DEPRECATED = other.CurrentPrice_DEPRECATED;
			DiscountPercentage = other.DiscountPercentage;
			ExpirationTimestamp = other.ExpirationTimestamp;
			PurchasedCount_DEPRECATED = other.PurchasedCount_DEPRECATED;
			PurchaseLimit = other.PurchaseLimit;
			AvailableForPurchase = other.AvailableForPurchase;
			OriginalPrice64 = other.OriginalPrice64;
			CurrentPrice64 = other.CurrentPrice64;
			DecimalPoint = other.DecimalPoint;
			ReleaseDateTimestamp = other.ReleaseDateTimestamp;
			EffectiveDateTimestamp = other.EffectiveDateTimestamp;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CatalogOfferInternal : IGettable<CatalogOffer>, ISettable<CatalogOffer>, System.IDisposable
	{
		private int m_ApiVersion;
		private int m_ServerIndex;
		private System.IntPtr m_CatalogNamespace;
		private System.IntPtr m_Id;
		private System.IntPtr m_TitleText;
		private System.IntPtr m_DescriptionText;
		private System.IntPtr m_LongDescriptionText;
		private System.IntPtr m_TechnicalDetailsText_DEPRECATED;
		private System.IntPtr m_CurrencyCode;
		private Result m_PriceResult;
		private uint m_OriginalPrice_DEPRECATED;
		private uint m_CurrentPrice_DEPRECATED;
		private byte m_DiscountPercentage;
		private long m_ExpirationTimestamp;
		private uint m_PurchasedCount_DEPRECATED;
		private int m_PurchaseLimit;
		private int m_AvailableForPurchase;
		private ulong m_OriginalPrice64;
		private ulong m_CurrentPrice64;
		private uint m_DecimalPoint;
		private long m_ReleaseDateTimestamp;
		private long m_EffectiveDateTimestamp;

		public int ServerIndex
		{
			get
			{
				return m_ServerIndex;
			}

			set
			{
				m_ServerIndex = value;
			}
		}

		public Utf8String CatalogNamespace
		{
			get
			{
				Utf8String value;
				Helper.Get(m_CatalogNamespace, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_CatalogNamespace);
			}
		}

		public Utf8String Id
		{
			get
			{
				Utf8String value;
				Helper.Get(m_Id, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_Id);
			}
		}

		public Utf8String TitleText
		{
			get
			{
				Utf8String value;
				Helper.Get(m_TitleText, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_TitleText);
			}
		}

		public Utf8String DescriptionText
		{
			get
			{
				Utf8String value;
				Helper.Get(m_DescriptionText, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_DescriptionText);
			}
		}

		public Utf8String LongDescriptionText
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LongDescriptionText, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LongDescriptionText);
			}
		}

		public Utf8String TechnicalDetailsText_DEPRECATED
		{
			get
			{
				Utf8String value;
				Helper.Get(m_TechnicalDetailsText_DEPRECATED, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_TechnicalDetailsText_DEPRECATED);
			}
		}

		public Utf8String CurrencyCode
		{
			get
			{
				Utf8String value;
				Helper.Get(m_CurrencyCode, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_CurrencyCode);
			}
		}

		public Result PriceResult
		{
			get
			{
				return m_PriceResult;
			}

			set
			{
				m_PriceResult = value;
			}
		}

		public uint OriginalPrice_DEPRECATED
		{
			get
			{
				return m_OriginalPrice_DEPRECATED;
			}

			set
			{
				m_OriginalPrice_DEPRECATED = value;
			}
		}

		public uint CurrentPrice_DEPRECATED
		{
			get
			{
				return m_CurrentPrice_DEPRECATED;
			}

			set
			{
				m_CurrentPrice_DEPRECATED = value;
			}
		}

		public byte DiscountPercentage
		{
			get
			{
				return m_DiscountPercentage;
			}

			set
			{
				m_DiscountPercentage = value;
			}
		}

		public long ExpirationTimestamp
		{
			get
			{
				return m_ExpirationTimestamp;
			}

			set
			{
				m_ExpirationTimestamp = value;
			}
		}

		public uint PurchasedCount_DEPRECATED
		{
			get
			{
				return m_PurchasedCount_DEPRECATED;
			}

			set
			{
				m_PurchasedCount_DEPRECATED = value;
			}
		}

		public int PurchaseLimit
		{
			get
			{
				return m_PurchaseLimit;
			}

			set
			{
				m_PurchaseLimit = value;
			}
		}

		public bool AvailableForPurchase
		{
			get
			{
				bool value;
				Helper.Get(m_AvailableForPurchase, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AvailableForPurchase);
			}
		}

		public ulong OriginalPrice64
		{
			get
			{
				return m_OriginalPrice64;
			}

			set
			{
				m_OriginalPrice64 = value;
			}
		}

		public ulong CurrentPrice64
		{
			get
			{
				return m_CurrentPrice64;
			}

			set
			{
				m_CurrentPrice64 = value;
			}
		}

		public uint DecimalPoint
		{
			get
			{
				return m_DecimalPoint;
			}

			set
			{
				m_DecimalPoint = value;
			}
		}

		public long ReleaseDateTimestamp
		{
			get
			{
				return m_ReleaseDateTimestamp;
			}

			set
			{
				m_ReleaseDateTimestamp = value;
			}
		}

		public long EffectiveDateTimestamp
		{
			get
			{
				return m_EffectiveDateTimestamp;
			}

			set
			{
				m_EffectiveDateTimestamp = value;
			}
		}

		public void Set(ref CatalogOffer other)
		{
			m_ApiVersion = EcomInterface.CatalogofferApiLatest;
			ServerIndex = other.ServerIndex;
			CatalogNamespace = other.CatalogNamespace;
			Id = other.Id;
			TitleText = other.TitleText;
			DescriptionText = other.DescriptionText;
			LongDescriptionText = other.LongDescriptionText;
			TechnicalDetailsText_DEPRECATED = other.TechnicalDetailsText_DEPRECATED;
			CurrencyCode = other.CurrencyCode;
			PriceResult = other.PriceResult;
			OriginalPrice_DEPRECATED = other.OriginalPrice_DEPRECATED;
			CurrentPrice_DEPRECATED = other.CurrentPrice_DEPRECATED;
			DiscountPercentage = other.DiscountPercentage;
			ExpirationTimestamp = other.ExpirationTimestamp;
			PurchasedCount_DEPRECATED = other.PurchasedCount_DEPRECATED;
			PurchaseLimit = other.PurchaseLimit;
			AvailableForPurchase = other.AvailableForPurchase;
			OriginalPrice64 = other.OriginalPrice64;
			CurrentPrice64 = other.CurrentPrice64;
			DecimalPoint = other.DecimalPoint;
			ReleaseDateTimestamp = other.ReleaseDateTimestamp;
			EffectiveDateTimestamp = other.EffectiveDateTimestamp;
		}

		public void Set(ref CatalogOffer? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = EcomInterface.CatalogofferApiLatest;
				ServerIndex = other.Value.ServerIndex;
				CatalogNamespace = other.Value.CatalogNamespace;
				Id = other.Value.Id;
				TitleText = other.Value.TitleText;
				DescriptionText = other.Value.DescriptionText;
				LongDescriptionText = other.Value.LongDescriptionText;
				TechnicalDetailsText_DEPRECATED = other.Value.TechnicalDetailsText_DEPRECATED;
				CurrencyCode = other.Value.CurrencyCode;
				PriceResult = other.Value.PriceResult;
				OriginalPrice_DEPRECATED = other.Value.OriginalPrice_DEPRECATED;
				CurrentPrice_DEPRECATED = other.Value.CurrentPrice_DEPRECATED;
				DiscountPercentage = other.Value.DiscountPercentage;
				ExpirationTimestamp = other.Value.ExpirationTimestamp;
				PurchasedCount_DEPRECATED = other.Value.PurchasedCount_DEPRECATED;
				PurchaseLimit = other.Value.PurchaseLimit;
				AvailableForPurchase = other.Value.AvailableForPurchase;
				OriginalPrice64 = other.Value.OriginalPrice64;
				CurrentPrice64 = other.Value.CurrentPrice64;
				DecimalPoint = other.Value.DecimalPoint;
				ReleaseDateTimestamp = other.Value.ReleaseDateTimestamp;
				EffectiveDateTimestamp = other.Value.EffectiveDateTimestamp;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_CatalogNamespace);
			Helper.Dispose(ref m_Id);
			Helper.Dispose(ref m_TitleText);
			Helper.Dispose(ref m_DescriptionText);
			Helper.Dispose(ref m_LongDescriptionText);
			Helper.Dispose(ref m_TechnicalDetailsText_DEPRECATED);
			Helper.Dispose(ref m_CurrencyCode);
		}

		public void Get(out CatalogOffer output)
		{
			output = new CatalogOffer();
			output.Set(ref this);
		}
	}
}