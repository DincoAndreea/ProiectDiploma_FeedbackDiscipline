package crc64e4dfeccb62c11f54;


public class OktaLogoutCallbackInterceptorActivity_1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Okta.Xamarin.Android.OktaLogoutCallbackInterceptorActivity`1, Okta.Xamarin.Android", OktaLogoutCallbackInterceptorActivity_1.class, __md_methods);
	}


	public OktaLogoutCallbackInterceptorActivity_1 ()
	{
		super ();
		if (getClass () == OktaLogoutCallbackInterceptorActivity_1.class) {
			mono.android.TypeManager.Activate ("Okta.Xamarin.Android.OktaLogoutCallbackInterceptorActivity`1, Okta.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
