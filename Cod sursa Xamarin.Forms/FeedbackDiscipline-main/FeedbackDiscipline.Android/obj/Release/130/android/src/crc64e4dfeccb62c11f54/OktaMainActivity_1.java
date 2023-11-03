package crc64e4dfeccb62c11f54;


public class OktaMainActivity_1
	extends crc643f46942d9dd1fff9.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"";
		mono.android.Runtime.register ("Okta.Xamarin.Android.OktaMainActivity`1, Okta.Xamarin.Android", OktaMainActivity_1.class, __md_methods);
	}


	public OktaMainActivity_1 ()
	{
		super ();
		if (getClass () == OktaMainActivity_1.class) {
			mono.android.TypeManager.Activate ("Okta.Xamarin.Android.OktaMainActivity`1, Okta.Xamarin.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public OktaMainActivity_1 (int p0)
	{
		super (p0);
		if (getClass () == OktaMainActivity_1.class) {
			mono.android.TypeManager.Activate ("Okta.Xamarin.Android.OktaMainActivity`1, Okta.Xamarin.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);

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
