; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [270 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 84
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 16
	i64 181099460066822533, ; 2: Microcharts.Droid.dll => 0x28364ffda4c4985 => 8
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 74
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 106
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 107
	i64 590536689428908136, ; 6: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 43
	i64 634308326490598313, ; 7: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 93
	i64 702024105029695270, ; 8: System.Drawing.Common => 0x9be17343c0e7726 => 126
	i64 720058930071658100, ; 9: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 87
	i64 816102801403336439, ; 10: Xamarin.Android.Support.Collections => 0xb53612c89d8d6f7 => 46
	i64 846634227898301275, ; 11: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 40
	i64 872800313462103108, ; 12: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 83
	i64 887546508555532406, ; 13: Microcharts.Forms => 0xc5132d8dc173876 => 9
	i64 940822596282819491, ; 14: System.Transactions => 0xd0e792aa81923a3 => 124
	i64 996343623809489702, ; 15: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 119
	i64 1000557547492888992, ; 16: Mono.Security.dll => 0xde2b1c9cba651a0 => 134
	i64 1120440138749646132, ; 17: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 121
	i64 1315114680217950157, ; 18: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 69
	i64 1416135423712704079, ; 19: Microcharts => 0x13a71faa343e364f => 7
	i64 1425944114962822056, ; 20: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 3
	i64 1490981186906623721, ; 21: Xamarin.Android.Support.VersionedParcelable => 0x14b1077d6c5c0ee9 => 62
	i64 1624659445732251991, ; 22: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 67
	i64 1628611045998245443, ; 23: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 95
	i64 1636321030536304333, ; 24: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 88
	i64 1731380447121279447, ; 25: Newtonsoft.Json => 0x18071957e9b889d7 => 18
	i64 1743969030606105336, ; 26: System.Memory.dll => 0x1833d297e88f2af8 => 132
	i64 1795316252682057001, ; 27: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 68
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 106
	i64 1865037103900624886, ; 29: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 10
	i64 1875917498431009007, ; 30: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 65
	i64 1981742497975770890, ; 31: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 94
	i64 2040001226662520565, ; 32: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 2
	i64 2133195048986300728, ; 33: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 18
	i64 2136356949452311481, ; 34: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 99
	i64 2165725771938924357, ; 35: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 72
	i64 2262844636196693701, ; 36: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 83
	i64 2284400282711631002, ; 37: System.Web.Services => 0x1fb3d1f42fd4249a => 130
	i64 2329709569556905518, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 91
	i64 2335503487726329082, ; 39: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 33
	i64 2337758774805907496, ; 40: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 31
	i64 2470498323731680442, ; 41: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 78
	i64 2479423007379663237, ; 42: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 111
	i64 2497223385847772520, ; 43: System.Runtime => 0x22a7eb7046413568 => 32
	i64 2547086958574651984, ; 44: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 64
	i64 2592350477072141967, ; 45: System.Xml.dll => 0x23f9e10627330e8f => 35
	i64 2612152650457191105, ; 46: Microsoft.IdentityModel.Tokens.dll => 0x24403afeed9892c1 => 15
	i64 2624866290265602282, ; 47: mscorlib.dll => 0x246d65fbde2db8ea => 17
	i64 2694427813909235223, ; 48: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 103
	i64 2783046991838674048, ; 49: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 31
	i64 2789714023057451704, ; 50: Microsoft.IdentityModel.JsonWebTokens.dll => 0x26b70e1f9943eab8 => 13
	i64 2949706848458024531, ; 51: Xamarin.Android.Support.SlidingPaneLayout => 0x28ef76c01de0a653 => 60
	i64 2960931600190307745, ; 52: Xamarin.Forms.Core => 0x2917579a49927da1 => 117
	i64 2977248461349026546, ; 53: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 55
	i64 3017704767998173186, ; 54: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 121
	i64 3122911337338800527, ; 55: Microcharts.dll => 0x2b56cf50bf1e898f => 7
	i64 3135710569046186342, ; 56: FeedbackDiscipline.Android => 0x2b8448261a6f9966 => 0
	i64 3289520064315143713, ; 57: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 90
	i64 3303437397778967116, ; 58: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 66
	i64 3311221304742556517, ; 59: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 30
	i64 3402534845034375023, ; 60: System.IdentityModel.Tokens.Jwt.dll => 0x2f383b6a0629a76f => 27
	i64 3493805808809882663, ; 61: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 109
	i64 3522470458906976663, ; 62: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 108
	i64 3531994851595924923, ; 63: System.Numerics => 0x31042a9aade235bb => 29
	i64 3571415421602489686, ; 64: System.Runtime.dll => 0x319037675df7e556 => 32
	i64 3716579019761409177, ; 65: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 66: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 105
	i64 3772598417116884899, ; 67: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 84
	i64 3966267475168208030, ; 68: System.Memory => 0x370b03412596249e => 132
	i64 4252163538099460320, ; 69: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 63
	i64 4349341163892612332, ; 70: Xamarin.Android.Support.DocumentFile => 0x3c5bf6bea8cd9cec => 54
	i64 4416987920449902723, ; 71: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0x3d4c4b1c879b9883 => 45
	i64 4525561845656915374, ; 72: System.ServiceModel.Internals => 0x3ece06856b710dae => 131
	i64 4636684751163556186, ; 73: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 113
	i64 4782108999019072045, ; 74: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 71
	i64 4794310189461587505, ; 75: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 64
	i64 4795410492532947900, ; 76: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 108
	i64 4841234827713643511, ; 77: Xamarin.Android.Support.CoordinaterLayout => 0x432f856d041f03f7 => 48
	i64 4963205065368577818, ; 78: Xamarin.Android.Support.LocalBroadcastManager.dll => 0x44e0d8b5f4b6a71a => 58
	i64 5142919913060024034, ; 79: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 118
	i64 5178572682164047940, ; 80: Xamarin.Android.Support.Print.dll => 0x47ddfc6acbee1044 => 59
	i64 5203618020066742981, ; 81: Xamarin.Essentials => 0x4836f704f0e652c5 => 116
	i64 5205316157927637098, ; 82: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 97
	i64 5288341611614403055, ; 83: Xamarin.Android.Support.Interpolator.dll => 0x4963f6ad4b3179ef => 56
	i64 5348796042099802469, ; 84: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 98
	i64 5376510917114486089, ; 85: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 111
	i64 5408338804355907810, ; 86: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 110
	i64 5451019430259338467, ; 87: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 77
	i64 5507995362134886206, ; 88: System.Core.dll => 0x4c705499688c873e => 25
	i64 5692067934154308417, ; 89: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 115
	i64 5701169857135624461, ; 90: FeedbackDiscipline => 0x4f1e9fc76abbc10d => 4
	i64 5757522595884336624, ; 91: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 75
	i64 5767696078500135884, ; 92: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 44
	i64 5814345312393086621, ; 93: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 103
	i64 5896680224035167651, ; 94: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 92
	i64 6044705416426755068, ; 95: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0x53e31b8ccdff13fc => 61
	i64 6085203216496545422, ; 96: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 119
	i64 6086316965293125504, ; 97: FormsViewGroup.dll => 0x5476f10882baef80 => 5
	i64 6222399776351216807, ; 98: System.Text.Json.dll => 0x565a67a0ffe264a7 => 34
	i64 6276613759455078625, ; 99: Okta.Xamarin.dll => 0x571b02f594a628e1 => 20
	i64 6311200438583329442, ; 100: Xamarin.Android.Support.LocalBroadcastManager => 0x5795e35c580c82a2 => 58
	i64 6319713645133255417, ; 101: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 93
	i64 6401687960814735282, ; 102: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 91
	i64 6504860066809920875, ; 103: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 72
	i64 6548213210057960872, ; 104: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 81
	i64 6591024623626361694, ; 105: System.Web.Services.dll => 0x5b7805f9751a1b5e => 130
	i64 6659513131007730089, ; 106: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 87
	i64 6671798237668743565, ; 107: SkiaSharp => 0x5c96fd260152998d => 21
	i64 6876862101832370452, ; 108: System.Xml.Linq => 0x5f6f85a57d108914 => 36
	i64 6894844156784520562, ; 109: System.Numerics.Vectors => 0x5faf683aead1ad72 => 30
	i64 7036436454368433159, ; 110: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 89
	i64 7103753931438454322, ; 111: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 86
	i64 7194160955514091247, ; 112: Xamarin.Android.Support.CursorAdapter.dll => 0x63d6cb45d266f6ef => 51
	i64 7488575175965059935, ; 113: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 36
	i64 7496222613193209122, ; 114: System.IdentityModel.Tokens.Jwt => 0x6807eec000a1b522 => 27
	i64 7635363394907363464, ; 115: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 117
	i64 7637365915383206639, ; 116: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 116
	i64 7654504624184590948, ; 117: System.Net.Http => 0x6a3a4366801b8264 => 28
	i64 7735176074855944702, ; 118: Microsoft.CSharp => 0x6b58dda848e391fe => 11
	i64 7820441508502274321, ; 119: System.Data => 0x6c87ca1e14ff8111 => 123
	i64 7821246742157274664, ; 120: Xamarin.Android.Support.AsyncLayoutInflater => 0x6c8aa67926f72e28 => 45
	i64 7836164640616011524, ; 121: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 67
	i64 7927939710195668715, ; 122: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 22
	i64 8044118961405839122, ; 123: System.ComponentModel.Composition => 0x6fa2739369944712 => 129
	i64 8083354569033831015, ; 124: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 90
	i64 8101777744205214367, ; 125: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 44
	i64 8103644804370223335, ; 126: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 125
	i64 8167236081217502503, ; 127: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 6
	i64 8187102936927221770, ; 128: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 23
	i64 8196541262927413903, ; 129: Xamarin.Android.Support.Interpolator => 0x71bff6d9fb9ec28f => 56
	i64 8385935383968044654, ; 130: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0x7460d3cd16cb566e => 42
	i64 8398329775253868912, ; 131: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 76
	i64 8400357532724379117, ; 132: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 102
	i64 8601935802264776013, ; 133: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 110
	i64 8626175481042262068, ; 134: Java.Interop => 0x77b654e585b55834 => 6
	i64 8638972117149407195, ; 135: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 11
	i64 8639588376636138208, ; 136: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 101
	i64 8684531736582871431, ; 137: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 128
	i64 8796457469147618732, ; 138: Xamarin.Android.Support.CustomTabs => 0x7a134b766a601dac => 52
	i64 8808820144457481518, ; 139: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 57
	i64 8917102979740339192, ; 140: Xamarin.Android.Support.DocumentFile.dll => 0x7bbfe9ea4d000bf8 => 54
	i64 9150689056026028438, ; 141: FeedbackDiscipline.dll => 0x7efdc736ca7c6996 => 4
	i64 9312692141327339315, ; 142: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 115
	i64 9324707631942237306, ; 143: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 68
	i64 9427266486299436557, ; 144: Microsoft.IdentityModel.Logging.dll => 0x82d460ebe6d2a60d => 14
	i64 9662334977499516867, ; 145: System.Numerics.dll => 0x8617827802b0cfc3 => 29
	i64 9678050649315576968, ; 146: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 78
	i64 9711637524876806384, ; 147: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 98
	i64 9808709177481450983, ; 148: Mono.Android.dll => 0x881f890734e555e7 => 16
	i64 9825649861376906464, ; 149: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 75
	i64 9834056768316610435, ; 150: System.Transactions.dll => 0x8879968718899783 => 124
	i64 9866412715007501892, ; 151: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 39
	i64 9998632235833408227, ; 152: Mono.Security => 0x8ac2470b209ebae3 => 134
	i64 10038780035334861115, ; 153: System.Net.Http.dll => 0x8b50e941206af13b => 28
	i64 10229024438826829339, ; 154: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 81
	i64 10303855825347935641, ; 155: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 57
	i64 10363495123250631811, ; 156: Xamarin.Android.Support.Collections.dll => 0x8fd287e80cd8d483 => 46
	i64 10376576884623852283, ; 157: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 109
	i64 10430153318873392755, ; 158: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 79
	i64 10447083246144586668, ; 159: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 10
	i64 10635644668885628703, ; 160: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 55
	i64 10847732767863316357, ; 161: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 69
	i64 10850923258212604222, ; 162: Xamarin.Android.Arch.Lifecycle.Runtime => 0x9696393672c9593e => 42
	i64 10913891249535884439, ; 163: Xamarin.Android.Support.CustomTabs.dll => 0x9775ee4465d49c97 => 52
	i64 11023048688141570732, ; 164: System.Core => 0x98f9bc61168392ac => 25
	i64 11037814507248023548, ; 165: System.Xml => 0x992e31d0412bf7fc => 35
	i64 11162124722117608902, ; 166: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 114
	i64 11340910727871153756, ; 167: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 80
	i64 11376461258732682436, ; 168: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 47
	i64 11392833485892708388, ; 169: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 104
	i64 11517440453979132662, ; 170: Microsoft.IdentityModel.Abstractions.dll => 0x9fd62b122523d2f6 => 12
	i64 11529969570048099689, ; 171: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 114
	i64 11578238080964724296, ; 172: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 89
	i64 11580057168383206117, ; 173: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 65
	i64 11597940890313164233, ; 174: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 175: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 86
	i64 11834399401546345650, ; 176: Xamarin.Android.Support.SlidingPaneLayout.dll => 0xa43c3b8deb43ecb2 => 60
	i64 11865714326292153359, ; 177: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa4ab7c5000e8440f => 41
	i64 12102847907131387746, ; 178: System.Buffers => 0xa7f5f40c43256f62 => 24
	i64 12137774235383566651, ; 179: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 112
	i64 12145679461940342714, ; 180: System.Text.Json => 0xa88e1f1ebcb62fba => 34
	i64 12307291687973536691, ; 181: Okta.Xamarin.Android => 0xaacc489558c7c3b3 => 19
	i64 12388767885335911387, ; 182: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0xabedbec0d236dbdb => 41
	i64 12414299427252656003, ; 183: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 47
	i64 12439275739440478309, ; 184: Microsoft.IdentityModel.JsonWebTokens => 0xaca12f61007bf865 => 13
	i64 12451044538927396471, ; 185: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 85
	i64 12466513435562512481, ; 186: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 96
	i64 12487638416075308985, ; 187: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 82
	i64 12538491095302438457, ; 188: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 73
	i64 12550732019250633519, ; 189: System.IO.Compression => 0xae2d28465e8e1b2f => 127
	i64 12700543734426720211, ; 190: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 74
	i64 12898955242700436758, ; 191: Okta.Xamarin => 0xb3024b739ed27516 => 20
	i64 12952608645614506925, ; 192: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 50
	i64 12963446364377008305, ; 193: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 126
	i64 13370592475155966277, ; 194: System.Runtime.Serialization => 0xb98de304062ea945 => 3
	i64 13401370062847626945, ; 195: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 112
	i64 13403416310143541304, ; 196: Microcharts.Droid => 0xba02801ea6c86038 => 8
	i64 13404347523447273790, ; 197: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 76
	i64 13454009404024712428, ; 198: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 122
	i64 13491513212026656886, ; 199: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 70
	i64 13492263892638604996, ; 200: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 23
	i64 13572454107664307259, ; 201: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 105
	i64 13647894001087880694, ; 202: System.Data.dll => 0xbd670f48cb071df6 => 123
	i64 13959074834287824816, ; 203: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 85
	i64 13967638549803255703, ; 204: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 118
	i64 14124974489674258913, ; 205: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 73
	i64 14172845254133543601, ; 206: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 99
	i64 14212104595480609394, ; 207: System.Security.Cryptography.Cng.dll => 0xc53b89d4a4518272 => 133
	i64 14261073672896646636, ; 208: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 104
	i64 14400856865250966808, ; 209: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 49
	i64 14486659737292545672, ; 210: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 92
	i64 14551742072151931844, ; 211: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 33
	i64 14644440854989303794, ; 212: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 97
	i64 14661790646341542033, ; 213: Xamarin.Android.Support.SwipeRefreshLayout => 0xcb7924e94e552091 => 61
	i64 14792063746108907174, ; 214: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 122
	i64 14852515768018889994, ; 215: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 80
	i64 14987728460634540364, ; 216: System.IO.Compression.dll => 0xcfff1ba06622494c => 127
	i64 14988210264188246988, ; 217: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 82
	i64 15138356091203993725, ; 218: Microsoft.IdentityModel.Abstractions => 0xd2163ea89395c07d => 12
	i64 15188640517174936311, ; 219: Xamarin.Android.Arch.Core.Common => 0xd2c8e413d75142f7 => 37
	i64 15246441518555807158, ; 220: Xamarin.Android.Arch.Core.Common.dll => 0xd3963dc832493db6 => 37
	i64 15326820765897713587, ; 221: Xamarin.Android.Arch.Core.Runtime.dll => 0xd4b3ce481769e7b3 => 38
	i64 15370334346939861994, ; 222: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 79
	i64 15568534730848034786, ; 223: Xamarin.Android.Support.VersionedParcelable.dll => 0xd80e8bda21875fe2 => 62
	i64 15582737692548360875, ; 224: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 95
	i64 15609085926864131306, ; 225: System.dll => 0xd89e9cf3334914ea => 26
	i64 15777549416145007739, ; 226: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 107
	i64 15810740023422282496, ; 227: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 120
	i64 15937190497610202713, ; 228: System.Security.Cryptography.Cng => 0xdd2c465197c97e59 => 133
	i64 15963349826457351533, ; 229: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 2
	i64 16154507427712707110, ; 230: System => 0xe03056ea4e39aa26 => 26
	i64 16242842420508142678, ; 231: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe16a2b1f8908ac56 => 48
	i64 16324796876805858114, ; 232: SkiaSharp.dll => 0xe28d5444586b6342 => 21
	i64 16565028646146589191, ; 233: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 129
	i64 16621146507174665210, ; 234: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 77
	i64 16677317093839702854, ; 235: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 102
	i64 16757453548800217720, ; 236: Okta.Xamarin.Android.dll => 0xe88e6f37c4589278 => 19
	i64 16767985610513713374, ; 237: Xamarin.Android.Arch.Core.Runtime => 0xe8b3da12798808de => 38
	i64 16822611501064131242, ; 238: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 125
	i64 16833383113903931215, ; 239: mscorlib => 0xe99c30c1484d7f4f => 17
	i64 16932527889823454152, ; 240: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 50
	i64 17001062948826229159, ; 241: Microcharts.Forms.dll => 0xebefe8ad2cd7a9a7 => 9
	i64 17024911836938395553, ; 242: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 66
	i64 17031351772568316411, ; 243: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 100
	i64 17037200463775726619, ; 244: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 88
	i64 17137864900836977098, ; 245: Microsoft.IdentityModel.Tokens => 0xedd5ed53b705e9ca => 15
	i64 17383232329670771222, ; 246: Xamarin.Android.Support.CustomView.dll => 0xf13da5b41a1cc216 => 53
	i64 17428701562824544279, ; 247: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 49
	i64 17483646997724851973, ; 248: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 63
	i64 17524135665394030571, ; 249: Xamarin.Android.Support.Print => 0xf3323c8a739097eb => 59
	i64 17544493274320527064, ; 250: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 71
	i64 17666959971718154066, ; 251: Xamarin.Android.Support.CustomView => 0xf52da67d9f4e4752 => 53
	i64 17671790519499593115, ; 252: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 22
	i64 17704177640604968747, ; 253: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 96
	i64 17710060891934109755, ; 254: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 94
	i64 17760961058993581169, ; 255: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 39
	i64 17790600151040787804, ; 256: Microsoft.IdentityModel.Logging => 0xf6e4e89427cc055c => 14
	i64 17838668724098252521, ; 257: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 24
	i64 17841643939744178149, ; 258: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 43
	i64 17882897186074144999, ; 259: FormsViewGroup => 0xf82cd03e3ac830e7 => 5
	i64 17892495832318972303, ; 260: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 120
	i64 17928294245072900555, ; 261: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 128
	i64 17958105683855786126, ; 262: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 40
	i64 18116111925905154859, ; 263: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 70
	i64 18121036031235206392, ; 264: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 100
	i64 18129453464017766560, ; 265: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 131
	i64 18301997741680159453, ; 266: Xamarin.Android.Support.CursorAdapter => 0xfdfdc1fa58d8eadd => 51
	i64 18305135509493619199, ; 267: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 101
	i64 18311231973601736124, ; 268: FeedbackDiscipline.Android.dll => 0xfe1e9076824e75bc => 0
	i64 18380184030268848184 ; 269: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 113
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [270 x i32] [
	i32 84, i32 16, i32 8, i32 74, i32 106, i32 107, i32 43, i32 93, ; 0..7
	i32 126, i32 87, i32 46, i32 40, i32 83, i32 9, i32 124, i32 119, ; 8..15
	i32 134, i32 121, i32 69, i32 7, i32 3, i32 62, i32 67, i32 95, ; 16..23
	i32 88, i32 18, i32 132, i32 68, i32 106, i32 10, i32 65, i32 94, ; 24..31
	i32 2, i32 18, i32 99, i32 72, i32 83, i32 130, i32 91, i32 33, ; 32..39
	i32 31, i32 78, i32 111, i32 32, i32 64, i32 35, i32 15, i32 17, ; 40..47
	i32 103, i32 31, i32 13, i32 60, i32 117, i32 55, i32 121, i32 7, ; 48..55
	i32 0, i32 90, i32 66, i32 30, i32 27, i32 109, i32 108, i32 29, ; 56..63
	i32 32, i32 1, i32 105, i32 84, i32 132, i32 63, i32 54, i32 45, ; 64..71
	i32 131, i32 113, i32 71, i32 64, i32 108, i32 48, i32 58, i32 118, ; 72..79
	i32 59, i32 116, i32 97, i32 56, i32 98, i32 111, i32 110, i32 77, ; 80..87
	i32 25, i32 115, i32 4, i32 75, i32 44, i32 103, i32 92, i32 61, ; 88..95
	i32 119, i32 5, i32 34, i32 20, i32 58, i32 93, i32 91, i32 72, ; 96..103
	i32 81, i32 130, i32 87, i32 21, i32 36, i32 30, i32 89, i32 86, ; 104..111
	i32 51, i32 36, i32 27, i32 117, i32 116, i32 28, i32 11, i32 123, ; 112..119
	i32 45, i32 67, i32 22, i32 129, i32 90, i32 44, i32 125, i32 6, ; 120..127
	i32 23, i32 56, i32 42, i32 76, i32 102, i32 110, i32 6, i32 11, ; 128..135
	i32 101, i32 128, i32 52, i32 57, i32 54, i32 4, i32 115, i32 68, ; 136..143
	i32 14, i32 29, i32 78, i32 98, i32 16, i32 75, i32 124, i32 39, ; 144..151
	i32 134, i32 28, i32 81, i32 57, i32 46, i32 109, i32 79, i32 10, ; 152..159
	i32 55, i32 69, i32 42, i32 52, i32 25, i32 35, i32 114, i32 80, ; 160..167
	i32 47, i32 104, i32 12, i32 114, i32 89, i32 65, i32 1, i32 86, ; 168..175
	i32 60, i32 41, i32 24, i32 112, i32 34, i32 19, i32 41, i32 47, ; 176..183
	i32 13, i32 85, i32 96, i32 82, i32 73, i32 127, i32 74, i32 20, ; 184..191
	i32 50, i32 126, i32 3, i32 112, i32 8, i32 76, i32 122, i32 70, ; 192..199
	i32 23, i32 105, i32 123, i32 85, i32 118, i32 73, i32 99, i32 133, ; 200..207
	i32 104, i32 49, i32 92, i32 33, i32 97, i32 61, i32 122, i32 80, ; 208..215
	i32 127, i32 82, i32 12, i32 37, i32 37, i32 38, i32 79, i32 62, ; 216..223
	i32 95, i32 26, i32 107, i32 120, i32 133, i32 2, i32 26, i32 48, ; 224..231
	i32 21, i32 129, i32 77, i32 102, i32 19, i32 38, i32 125, i32 17, ; 232..239
	i32 50, i32 9, i32 66, i32 100, i32 88, i32 15, i32 53, i32 49, ; 240..247
	i32 63, i32 59, i32 71, i32 53, i32 22, i32 96, i32 94, i32 39, ; 248..255
	i32 14, i32 24, i32 43, i32 5, i32 120, i32 128, i32 40, i32 70, ; 256..263
	i32 100, i32 131, i32 51, i32 101, i32 0, i32 113 ; 264..269
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
