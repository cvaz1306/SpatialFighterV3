// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.IntegratedPlatform
{
	public sealed partial class IntegratedPlatformInterface : Handle
	{
		public IntegratedPlatformInterface()
		{
		}

		public IntegratedPlatformInterface(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="AddNotifyUserLoginStatusChanged" /> API.
		/// </summary>
		public const int AddnotifyuserloginstatuschangedApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="ClearUserPreLogoutCallback" /> API.
		/// </summary>
		public const int ClearuserprelogoutcallbackApiLatest = 1;

		public const int CreateintegratedplatformoptionscontainerApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="FinalizeDeferredUserLogout" /> API.
		/// </summary>
		public const int FinalizedeferreduserlogoutApiLatest = 1;

		/// <summary>
		/// A macro to identify the Steam integrated platform.
		/// </summary>
		public static readonly Utf8String IptSteam = "STEAM";

		public const int OptionsApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetUserLoginStatus" /> API.
		/// </summary>
		public const int SetuserloginstatusApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="SetUserPreLogoutCallback" /> API.
		/// </summary>
		public const int SetuserprelogoutcallbackApiLatest = 1;

		public const int SteamOptionsApiLatest = 2;

		/// <summary>
		/// Register to receive notifications when the login state of Integrated Platform users change.
		/// 
		/// This notification will trigger any time the EOS SDK's internal login state changes for a user, including for manual login state
		/// changes (when the <see cref="IntegratedPlatformManagementFlags.ApplicationManagedIdentityLogin" /> flag is set), or automatically detected ones (when not disabled by the
		/// <see cref="IntegratedPlatformManagementFlags.ApplicationManagedIdentityLogin" /> flag).
		/// <seealso cref="RemoveNotifyUserLoginStatusChanged" />
		/// </summary>
		/// <param name="options">Data associated with what version of the notification to receive.</param>
		/// <param name="clientData">A context pointer that is returned in the callback function.</param>
		/// <param name="callbackFunction">The function that is called when Integrated Platform user logins happen</param>
		/// <returns>
		/// A valid notification that can be used to unregister for notifications, or <see cref="Common.InvalidNotificationid" /> if input was invalid.
		/// </returns>
		public ulong AddNotifyUserLoginStatusChanged(ref AddNotifyUserLoginStatusChangedOptions options, object clientData, OnUserLoginStatusChangedCallback callbackFunction)
		{
			AddNotifyUserLoginStatusChangedOptionsInternal optionsInternal = new AddNotifyUserLoginStatusChangedOptionsInternal();
			optionsInternal.Set(ref options);

			var clientDataAddress = System.IntPtr.Zero;

			var callbackFunctionInternal = new OnUserLoginStatusChangedCallbackInternal(OnUserLoginStatusChangedCallbackInternalImplementation);
			Helper.AddCallback(out clientDataAddress, clientData, callbackFunction, callbackFunctionInternal);

			var funcResult = Bindings.EOS_IntegratedPlatform_AddNotifyUserLoginStatusChanged(InnerHandle, ref optionsInternal, clientDataAddress, callbackFunctionInternal);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Clears a previously set integrated platform user logout handler for the specified integrated platform. If none is set for the specified platform, this does nothing.
		/// 
		/// If there are any pending deferred user-logouts when a handler is cleared, those users will internally be logged-out and cached data about those users cleared before this function returns.
		/// Any applicable callbacks about those users being logged-out will occur in a future call to <see cref="Platform.PlatformInterface.Tick" />().
		/// <seealso cref="SetUserPreLogoutCallback" />
		/// </summary>
		/// <param name="options">Data for which integrated platform to no longer call a previously-registered callback for.</param>
		public void ClearUserPreLogoutCallback(ref ClearUserPreLogoutCallbackOptions options)
		{
			ClearUserPreLogoutCallbackOptionsInternal optionsInternal = new ClearUserPreLogoutCallbackOptionsInternal();
			optionsInternal.Set(ref options);

			Bindings.EOS_IntegratedPlatform_ClearUserPreLogoutCallback(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);
		}

		/// <summary>
		/// Creates an integrated platform options container handle. This handle can used to add multiple options to your container which will then be applied with <see cref="Platform.PlatformInterface.Create" />.
		/// The resulting handle must be released by calling <see cref="IntegratedPlatformOptionsContainer.Release" /> once it has been passed to <see cref="Platform.PlatformInterface.Create" />.
		/// <seealso cref="IntegratedPlatformOptionsContainer.Release" />
		/// <seealso cref="Platform.PlatformInterface.Create" />
		/// <seealso cref="IntegratedPlatformOptionsContainer.Add" />
		/// </summary>
		/// <param name="options">structure containing operation input parameters.</param>
		/// <param name="outIntegratedPlatformOptionsContainerHandle">Pointer to an integrated platform options container handle to be set if successful.</param>
		/// <returns>
		/// Success if we successfully created the integrated platform options container handle pointed at in OutIntegratedPlatformOptionsContainerHandle, or an error result if the input data was invalid.
		/// </returns>
		public static Result CreateIntegratedPlatformOptionsContainer(ref CreateIntegratedPlatformOptionsContainerOptions options, out IntegratedPlatformOptionsContainer outIntegratedPlatformOptionsContainerHandle)
		{
			CreateIntegratedPlatformOptionsContainerOptionsInternal optionsInternal = new CreateIntegratedPlatformOptionsContainerOptionsInternal();
			optionsInternal.Set(ref options);

			var outIntegratedPlatformOptionsContainerHandleAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(ref optionsInternal, ref outIntegratedPlatformOptionsContainerHandleAddress);

			Helper.Dispose(ref optionsInternal);

			Helper.Get(outIntegratedPlatformOptionsContainerHandleAddress, out outIntegratedPlatformOptionsContainerHandle);

			return funcResult;
		}

		/// <summary>
		/// Complete a Logout/Login for a previously deferred Integrated Platform User Logout.
		/// 
		/// This function allows applications to control whether an integrated-platform user actually logs out when an integrated platform's system tells the SDK a user has been logged-out.
		/// This allows applications to prevent accidental logouts from destroying application user state. If a user did not mean to logout, the application should prompt and confirm whether
		/// the user meant to logout, and either wait for them to confirm they meant to, or wait for them to login again, before calling this function.
		/// 
		/// If the sign-out is intended and your application believes the user is still logged-out, the UserExpectedLoginState in Options should be <see cref="LoginStatus.NotLoggedIn" />.
		/// If the sign-out was NOT intended and your application believes the user has logged-in again, the UserExpectedLoginState in Options should be <see cref="LoginStatus.LoggedIn" />.
		/// <seealso cref="SetUserPreLogoutCallback" />
		/// <seealso cref="ClearUserPreLogoutCallback" />
		/// <seealso cref="AddNotifyUserLoginStatusChanged" />
		/// </summary>
		/// <param name="options">Data for which integrated platform and user is now in the expected logged-in/logged-out state.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the platform user state matches the UserExpectedLoginState internally.
		/// <see cref="Result.NotConfigured" /> if the Integrated Platform was not initialized on platform creation
		/// <see cref="Result.InvalidUser" /> if the LocalPlatformUserId is not a valid user id for the provided Integrated Platform, or if there is no deferred logout waiting to be completed for this specified user
		/// <see cref="Result.InvalidParameters" /> if any other input was invalid
		/// </returns>
		public Result FinalizeDeferredUserLogout(ref FinalizeDeferredUserLogoutOptions options)
		{
			FinalizeDeferredUserLogoutOptionsInternal optionsInternal = new FinalizeDeferredUserLogoutOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_IntegratedPlatform_FinalizeDeferredUserLogout(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// Unregister from Integrated Platform user login and logout notifications.
		/// <seealso cref="AddNotifyUserLoginStatusChanged" />
		/// </summary>
		/// <param name="notificationId">The NotificationId that was returned from registering for Integrated Platform user login and logout notifications.</param>
		public void RemoveNotifyUserLoginStatusChanged(ulong notificationId)
		{
			Bindings.EOS_IntegratedPlatform_RemoveNotifyUserLoginStatusChanged(InnerHandle, notificationId);

			Helper.RemoveCallbackByNotificationId(notificationId);
		}

		/// <summary>
		/// Sets the current login status of a specific local platform user to a new value.
		/// 
		/// This function may only be used with an Integrated Platform initialized with the <see cref="IntegratedPlatformManagementFlags.ApplicationManagedIdentityLogin" /> flag, otherwise
		/// calls will return <see cref="Result.InvalidState" /> and a platform user's login status will be controlled by OS events.
		/// 
		/// If the login status of a user changes, a Integrated Platform User Login Status Changed notification will fire, and depending on the state
		/// of the user's login and the platform, the EOS SDK might start fetching data for the user, it may clear cached data, or it may do nothing.
		/// 
		/// If the login status of a user is not different from a previous call to this function, the function will do nothing and return <see cref="Result.Success" />.
		/// This will not trigger a call to the Integrated Platform User Login Status Changed.
		/// 
		/// @param Options
		/// </summary>
		/// <returns>
		/// <see cref="Result.Success" /> if the call was successful
		/// <see cref="Result.NotConfigured" /> if the Integrated Platform was not initialized on platform creation
		/// <see cref="Result.InvalidState" /> if the Integrated Platform was not initialized with the <see cref="IntegratedPlatformManagementFlags.ApplicationManagedIdentityLogin" /> flag
		/// <see cref="Result.InvalidUser" /> if the LocalPlatformUserId is not a valid user id for the provided Integrated Platform
		/// <see cref="Result.InvalidParameters" /> if any other input was invalid
		/// </returns>
		public Result SetUserLoginStatus(ref SetUserLoginStatusOptions options)
		{
			SetUserLoginStatusOptionsInternal optionsInternal = new SetUserLoginStatusOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_IntegratedPlatform_SetUserLoginStatus(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// Sets the integrated platform user logout handler for all integrated platforms.
		/// 
		/// There can only be one handler set at once, attempting to set a handler when one is already set will result in a <see cref="Result.AlreadyConfigured" /> error.
		/// 
		/// This callback handler allows applications to decide if a user is logged-out immediately when the SDK receives a system user logout event,
		/// or if the application would like to give the user a chance to correct themselves and log back in if they are in a state that might be
		/// disruptive if an accidental logout happens (unsaved user data, in a multiplayer match, etc). This is not supported on all integrated
		/// platforms, such as those where applications automatically close when a user logs out, or those where a user is always logged-in.
		/// 
		/// If a logout is deferred, applications are expected to eventually call <see cref="FinalizeDeferredUserLogout" /> when they
		/// have decided a user meant to logout, or if they have logged in again.
		/// <seealso cref="ClearUserPreLogoutCallback" />
		/// <seealso cref="FinalizeDeferredUserLogout" />
		/// </summary>
		/// <param name="options">Data that specifies the API version.</param>
		/// <param name="clientData">An optional context pointer that is returned in the callback data.</param>
		/// <param name="callbackFunction">The function that will handle the callback.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the platform user logout handler was bound successfully.
		/// <see cref="Result.AlreadyConfigured" /> if there is already a platform user logout handler bound.
		/// </returns>
		public Result SetUserPreLogoutCallback(ref SetUserPreLogoutCallbackOptions options, object clientData, OnUserPreLogoutCallback callbackFunction)
		{
			SetUserPreLogoutCallbackOptionsInternal optionsInternal = new SetUserPreLogoutCallbackOptionsInternal();
			optionsInternal.Set(ref options);

			var clientDataAddress = System.IntPtr.Zero;

			var callbackFunctionInternal = new OnUserPreLogoutCallbackInternal(OnUserPreLogoutCallbackInternalImplementation);
			Helper.AddCallback(out clientDataAddress, clientData, callbackFunction, callbackFunctionInternal);

			var funcResult = Bindings.EOS_IntegratedPlatform_SetUserPreLogoutCallback(InnerHandle, ref optionsInternal, clientDataAddress, callbackFunctionInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		[MonoPInvokeCallback(typeof(OnUserLoginStatusChangedCallbackInternal))]
		internal static void OnUserLoginStatusChangedCallbackInternalImplementation(ref UserLoginStatusChangedCallbackInfoInternal data)
		{
			OnUserLoginStatusChangedCallback callback;
			UserLoginStatusChangedCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnUserPreLogoutCallbackInternal))]
		internal static IntegratedPlatformPreLogoutAction OnUserPreLogoutCallbackInternalImplementation(ref UserPreLogoutCallbackInfoInternal data)
		{
			OnUserPreLogoutCallback callback;
			UserPreLogoutCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				var funcResult = callback(ref callbackInfo);

				return funcResult;
			}

			return Helper.GetDefault<IntegratedPlatformPreLogoutAction>();
		}
	}
}