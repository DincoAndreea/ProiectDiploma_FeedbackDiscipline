; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [270 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 93
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 122
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 18
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 117
	i32 57967248, ; 4: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 62
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 107
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 107
	i32 160529393, ; 7: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 37
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 74
	i32 166922606, ; 9: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 47
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 108
	i32 201930040, ; 11: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 38
	i32 209399409, ; 12: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 72
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 88
	i32 230752869, ; 14: Microsoft.CSharp.dll => 0xdc10265 => 11
	i32 232815796, ; 15: System.Web.Services => 0xde07cb4 => 130
	i32 261689757, ; 16: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 77
	i32 278686392, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 92
	i32 280482487, ; 18: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 86
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 64
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 29
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 90
	i32 385762202, ; 22: System.Memory.dll => 0x16fe439a => 132
	i32 389971796, ; 23: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 49
	i32 441335492, ; 24: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 76
	i32 442521989, ; 25: Xamarin.Essentials => 0x1a605985 => 116
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 85
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 17
	i32 469710990, ; 28: System.dll => 0x1bff388e => 26
	i32 476646585, ; 29: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 86
	i32 485463106, ; 30: Microsoft.IdentityModel.Abstractions => 0x1cef9442 => 12
	i32 486930444, ; 31: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 97
	i32 507578056, ; 32: Okta.Xamarin.dll => 0x1e4106c8 => 20
	i32 514659665, ; 33: Xamarin.Android.Support.Compat => 0x1ead1551 => 47
	i32 524864063, ; 34: Xamarin.Android.Support.Print => 0x1f48ca3f => 59
	i32 525008092, ; 35: SkiaSharp.dll => 0x1f4afcdc => 21
	i32 526420162, ; 36: System.Transactions.dll => 0x1f6088c2 => 124
	i32 548916678, ; 37: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 10
	i32 577335427, ; 38: System.Security.Cryptography.Cng => 0x22697083 => 133
	i32 605376203, ; 39: System.IO.Compression.FileSystem => 0x24154ecb => 128
	i32 627609679, ; 40: Xamarin.AndroidX.CustomView => 0x2568904f => 81
	i32 662205335, ; 41: System.Text.Encodings.Web.dll => 0x27787397 => 33
	i32 663517072, ; 42: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 113
	i32 666292255, ; 43: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 69
	i32 690569205, ; 44: System.Xml.Linq.dll => 0x29293ff5 => 36
	i32 692692150, ; 45: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 44
	i32 764776452, ; 46: FeedbackDiscipline => 0x2d959004 => 4
	i32 775507847, ; 47: System.IO.Compression => 0x2e394f87 => 127
	i32 801787702, ; 48: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 56
	i32 809851609, ; 49: System.Drawing.Common.dll => 0x30455ad9 => 126
	i32 843511501, ; 50: Xamarin.AndroidX.Print => 0x3246f6cd => 104
	i32 886248193, ; 51: Microcharts.Droid => 0x34d31301 => 8
	i32 916714535, ; 52: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 59
	i32 928116545, ; 53: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 122
	i32 955402788, ; 54: Newtonsoft.Json => 0x38f24a24 => 18
	i32 967690846, ; 55: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 90
	i32 974778368, ; 56: FormsViewGroup.dll => 0x3a19f000 => 5
	i32 987342438, ; 57: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 41
	i32 1012816738, ; 58: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 106
	i32 1035644815, ; 59: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 68
	i32 1042160112, ; 60: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 119
	i32 1052210849, ; 61: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 94
	i32 1098167829, ; 62: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 43
	i32 1098259244, ; 63: System => 0x41761b2c => 26
	i32 1175144683, ; 64: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 111
	i32 1178241025, ; 65: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 101
	i32 1204270330, ; 66: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 69
	i32 1267360935, ; 67: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 112
	i32 1292763917, ; 68: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 51
	i32 1293217323, ; 69: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 83
	i32 1297413738, ; 70: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 40
	i32 1323988371, ; 71: Okta.Xamarin.Android => 0x4eea7593 => 19
	i32 1365406463, ; 72: System.ServiceModel.Internals.dll => 0x516272ff => 131
	i32 1376866003, ; 73: Xamarin.AndroidX.SavedState => 0x52114ed3 => 106
	i32 1395857551, ; 74: Xamarin.AndroidX.Media.dll => 0x5333188f => 98
	i32 1406073936, ; 75: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 78
	i32 1411638395, ; 76: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 31
	i32 1460219004, ; 77: Xamarin.Forms.Xaml => 0x57092c7c => 120
	i32 1460893475, ; 78: System.IdentityModel.Tokens.Jwt => 0x57137723 => 27
	i32 1462112819, ; 79: System.IO.Compression.dll => 0x57261233 => 127
	i32 1469204771, ; 80: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 67
	i32 1498168481, ; 81: Microsoft.IdentityModel.JsonWebTokens.dll => 0x594c3ca1 => 13
	i32 1544850751, ; 82: Okta.Xamarin.Android.dll => 0x5c148d3f => 19
	i32 1574652163, ; 83: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 50
	i32 1582372066, ; 84: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 82
	i32 1582526884, ; 85: Microcharts.Forms.dll => 0x5e5371a4 => 9
	i32 1587447679, ; 86: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 37
	i32 1592978981, ; 87: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 88: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 96
	i32 1624863272, ; 89: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 115
	i32 1636350590, ; 90: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 80
	i32 1639515021, ; 91: System.Net.Http.dll => 0x61b9038d => 28
	i32 1657153582, ; 92: System.Runtime => 0x62c6282e => 32
	i32 1658241508, ; 93: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 109
	i32 1658251792, ; 94: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 121
	i32 1670060433, ; 95: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 77
	i32 1722051300, ; 96: SkiaSharp.Views.Forms => 0x66a46ae4 => 23
	i32 1729485958, ; 97: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 73
	i32 1766324549, ; 98: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 108
	i32 1776026572, ; 99: System.Core.dll => 0x69dc03cc => 25
	i32 1788241197, ; 100: Xamarin.AndroidX.Fragment => 0x6a96652d => 85
	i32 1796167890, ; 101: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 10
	i32 1808609942, ; 102: Xamarin.AndroidX.Loader => 0x6bcd3296 => 96
	i32 1813201214, ; 103: Xamarin.Google.Android.Material => 0x6c13413e => 121
	i32 1818569960, ; 104: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 102
	i32 1866717392, ; 105: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 56
	i32 1867746548, ; 106: Xamarin.Essentials.dll => 0x6f538cf4 => 116
	i32 1878053835, ; 107: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 120
	i32 1885316902, ; 108: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 70
	i32 1916660109, ; 109: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 43
	i32 1919157823, ; 110: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 99
	i32 1986222447, ; 111: Microsoft.IdentityModel.Tokens.dll => 0x7663596f => 15
	i32 2011961780, ; 112: System.Buffers.dll => 0x77ec19b4 => 24
	i32 2019465201, ; 113: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 94
	i32 2037417872, ; 114: Xamarin.Android.Support.ViewPager => 0x79708790 => 63
	i32 2044222327, ; 115: Xamarin.Android.Support.Loader => 0x79d85b77 => 57
	i32 2055257422, ; 116: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 91
	i32 2079903147, ; 117: System.Runtime.dll => 0x7bf8cdab => 32
	i32 2090596640, ; 118: System.Numerics.Vectors => 0x7c9bf920 => 30
	i32 2097448633, ; 119: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 87
	i32 2126786730, ; 120: Xamarin.Forms.Platform.Android => 0x7ec430aa => 118
	i32 2139458754, ; 121: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 55
	i32 2166116741, ; 122: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 50
	i32 2196165013, ; 123: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 62
	i32 2201231467, ; 124: System.Net.Http => 0x8334206b => 28
	i32 2217644978, ; 125: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 111
	i32 2244775296, ; 126: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 97
	i32 2256548716, ; 127: Xamarin.AndroidX.MultiDex => 0x8680336c => 99
	i32 2261435625, ; 128: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 89
	i32 2279755925, ; 129: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 105
	i32 2315684594, ; 130: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 65
	i32 2330457430, ; 131: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 49
	i32 2330986192, ; 132: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 60
	i32 2369706906, ; 133: Microsoft.IdentityModel.Logging => 0x8d3edb9a => 14
	i32 2409053734, ; 134: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 103
	i32 2440966767, ; 135: Xamarin.Android.Support.Loader.dll => 0x917e326f => 57
	i32 2465532216, ; 136: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 76
	i32 2471841756, ; 137: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 138: Java.Interop.dll => 0x93918882 => 6
	i32 2487632829, ; 139: Xamarin.Android.Support.DocumentFile => 0x944643bd => 54
	i32 2501346920, ; 140: System.Data.DataSetExtensions => 0x95178668 => 125
	i32 2505896520, ; 141: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 93
	i32 2562349572, ; 142: Microsoft.CSharp => 0x98ba5a04 => 11
	i32 2570120770, ; 143: System.Text.Encodings.Web => 0x9930ee42 => 33
	i32 2581819634, ; 144: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 112
	i32 2620871830, ; 145: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 80
	i32 2624644809, ; 146: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 84
	i32 2633051222, ; 147: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 92
	i32 2640290731, ; 148: Microsoft.IdentityModel.Logging.dll => 0x9d5fa3ab => 14
	i32 2698266930, ; 149: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 41
	i32 2701096212, ; 150: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 109
	i32 2719963679, ; 151: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 133
	i32 2732626843, ; 152: Xamarin.AndroidX.Activity => 0xa2e0939b => 64
	i32 2737747696, ; 153: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 67
	i32 2751899777, ; 154: Xamarin.Android.Support.Collections => 0xa406a881 => 46
	i32 2766581644, ; 155: Xamarin.Forms.Core => 0xa4e6af8c => 117
	i32 2778768386, ; 156: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 114
	i32 2782647110, ; 157: Xamarin.Android.Support.CustomTabs.dll => 0xa5dbd346 => 52
	i32 2788639665, ; 158: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 58
	i32 2788775637, ; 159: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 61
	i32 2795602088, ; 160: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 22
	i32 2810250172, ; 161: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 78
	i32 2819470561, ; 162: System.Xml.dll => 0xa80db4e1 => 35
	i32 2853208004, ; 163: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 114
	i32 2855708567, ; 164: Xamarin.AndroidX.Transition => 0xaa36a797 => 110
	i32 2876493027, ; 165: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 61
	i32 2893257763, ; 166: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 38
	i32 2903344695, ; 167: System.ComponentModel.Composition => 0xad0d8637 => 129
	i32 2905242038, ; 168: mscorlib.dll => 0xad2a79b6 => 17
	i32 2912489636, ; 169: SkiaSharp.Views.Android => 0xad9910a4 => 22
	i32 2916838712, ; 170: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 115
	i32 2919462931, ; 171: System.Numerics.Vectors.dll => 0xae037813 => 30
	i32 2921128767, ; 172: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 66
	i32 2921692953, ; 173: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 53
	i32 2974793899, ; 174: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 23
	i32 2978675010, ; 175: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 83
	i32 3024354802, ; 176: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 88
	i32 3036068679, ; 177: Microcharts.Droid.dll => 0xb4f6bb47 => 8
	i32 3044182254, ; 178: FormsViewGroup => 0xb57288ee => 5
	i32 3056250942, ; 179: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 45
	i32 3057625584, ; 180: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 100
	i32 3068715062, ; 181: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 39
	i32 3084678329, ; 182: Microsoft.IdentityModel.Tokens => 0xb7dc74b9 => 15
	i32 3111772706, ; 183: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3124832203, ; 184: System.Threading.Tasks.Extensions => 0xba4127cb => 2
	i32 3191408315, ; 185: Xamarin.Android.Support.CustomTabs => 0xbe3906bb => 52
	i32 3204380047, ; 186: System.Data.dll => 0xbefef58f => 123
	i32 3204912593, ; 187: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 45
	i32 3211777861, ; 188: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 82
	i32 3233339011, ; 189: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 40
	i32 3247209679, ; 190: FeedbackDiscipline.dll => 0xc18c7ccf => 4
	i32 3247949154, ; 191: Mono.Security => 0xc197c562 => 134
	i32 3258312781, ; 192: Xamarin.AndroidX.CardView => 0xc235e84d => 73
	i32 3265893370, ; 193: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 2
	i32 3267021929, ; 194: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 71
	i32 3296380511, ; 195: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 46
	i32 3312457198, ; 196: Microsoft.IdentityModel.JsonWebTokens => 0xc57015ee => 13
	i32 3317135071, ; 197: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 81
	i32 3317144872, ; 198: System.Data => 0xc5b79d28 => 123
	i32 3321585405, ; 199: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 54
	i32 3340387945, ; 200: SkiaSharp => 0xc71a4669 => 21
	i32 3340431453, ; 201: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 70
	i32 3346324047, ; 202: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 101
	i32 3352662376, ; 203: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 48
	i32 3353484488, ; 204: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 87
	i32 3357663996, ; 205: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 51
	i32 3358260929, ; 206: System.Text.Json => 0xc82afec1 => 34
	i32 3362522851, ; 207: Xamarin.AndroidX.Core => 0xc86c06e3 => 79
	i32 3366347497, ; 208: Java.Interop => 0xc8a662e9 => 6
	i32 3374999561, ; 209: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 105
	i32 3395150330, ; 210: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 31
	i32 3404865022, ; 211: System.ServiceModel.Internals => 0xcaf21dfe => 131
	i32 3429136800, ; 212: System.Xml => 0xcc6479a0 => 35
	i32 3430777524, ; 213: netstandard => 0xcc7d82b4 => 1
	i32 3439690031, ; 214: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 44
	i32 3441283291, ; 215: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 84
	i32 3455791806, ; 216: Microcharts => 0xcdfb32be => 7
	i32 3476120550, ; 217: Mono.Android => 0xcf3163e6 => 16
	i32 3485117614, ; 218: System.Text.Json.dll => 0xcfbaacae => 34
	i32 3486566296, ; 219: System.Transactions => 0xcfd0c798 => 124
	i32 3493954962, ; 220: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 75
	i32 3501239056, ; 221: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 71
	i32 3509114376, ; 222: System.Xml.Linq => 0xd128d608 => 36
	i32 3536029504, ; 223: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 118
	i32 3547625832, ; 224: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 60
	i32 3567349600, ; 225: System.ComponentModel.Composition.dll => 0xd4a16f60 => 129
	i32 3618140916, ; 226: Xamarin.AndroidX.Preference => 0xd7a872f4 => 103
	i32 3627220390, ; 227: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 104
	i32 3632359727, ; 228: Xamarin.Forms.Platform => 0xd881692f => 119
	i32 3633644679, ; 229: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 66
	i32 3641597786, ; 230: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 91
	i32 3664423555, ; 231: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 63
	i32 3668042751, ; 232: Microcharts.dll => 0xdaa1e3ff => 7
	i32 3672681054, ; 233: Mono.Android.dll => 0xdae8aa5e => 16
	i32 3676310014, ; 234: System.Web.Services.dll => 0xdb2009fe => 130
	i32 3681174138, ; 235: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 39
	i32 3682565725, ; 236: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 72
	i32 3684561358, ; 237: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 75
	i32 3689375977, ; 238: System.Drawing.Common => 0xdbe768e9 => 126
	i32 3700591436, ; 239: Microsoft.IdentityModel.Abstractions.dll => 0xdc928b4c => 12
	i32 3714038699, ; 240: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 58
	i32 3718780102, ; 241: Xamarin.AndroidX.Annotation => 0xdda814c6 => 65
	i32 3724971120, ; 242: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 100
	i32 3758932259, ; 243: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 89
	i32 3776062606, ; 244: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 55
	i32 3786282454, ; 245: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 74
	i32 3822602673, ; 246: Xamarin.AndroidX.Media => 0xe3d849b1 => 98
	i32 3829621856, ; 247: System.Numerics.dll => 0xe4436460 => 29
	i32 3832731800, ; 248: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 48
	i32 3860913051, ; 249: FeedbackDiscipline.Android => 0xe620db9b => 0
	i32 3862817207, ; 250: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 42
	i32 3874897629, ; 251: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 42
	i32 3885922214, ; 252: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 110
	i32 3896760992, ; 253: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 79
	i32 3903721208, ; 254: Microcharts.Forms => 0xe8ae0ef8 => 9
	i32 3920810846, ; 255: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 128
	i32 3921031405, ; 256: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 113
	i32 3931092270, ; 257: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 102
	i32 3945713374, ; 258: System.Data.DataSetExtensions.dll => 0xeb2ecede => 125
	i32 3955647286, ; 259: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 68
	i32 4025784931, ; 260: System.Memory => 0xeff49a63 => 132
	i32 4063435586, ; 261: Xamarin.Android.Support.CustomView => 0xf2331b42 => 53
	i32 4104167530, ; 262: Okta.Xamarin => 0xf4a0a06a => 20
	i32 4105002889, ; 263: Mono.Security.dll => 0xf4ad5f89 => 134
	i32 4151237749, ; 264: System.Core => 0xf76edc75 => 25
	i32 4182413190, ; 265: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 95
	i32 4196557070, ; 266: FeedbackDiscipline.Android.dll => 0xfa22610e => 0
	i32 4260525087, ; 267: System.Buffers => 0xfdf2741f => 24
	i32 4263231520, ; 268: System.IdentityModel.Tokens.Jwt.dll => 0xfe1bc020 => 27
	i32 4292120959 ; 269: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 95
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [270 x i32] [
	i32 93, i32 122, i32 18, i32 117, i32 62, i32 107, i32 107, i32 37, ; 0..7
	i32 74, i32 47, i32 108, i32 38, i32 72, i32 88, i32 11, i32 130, ; 8..15
	i32 77, i32 92, i32 86, i32 64, i32 29, i32 90, i32 132, i32 49, ; 16..23
	i32 76, i32 116, i32 85, i32 17, i32 26, i32 86, i32 12, i32 97, ; 24..31
	i32 20, i32 47, i32 59, i32 21, i32 124, i32 10, i32 133, i32 128, ; 32..39
	i32 81, i32 33, i32 113, i32 69, i32 36, i32 44, i32 4, i32 127, ; 40..47
	i32 56, i32 126, i32 104, i32 8, i32 59, i32 122, i32 18, i32 90, ; 48..55
	i32 5, i32 41, i32 106, i32 68, i32 119, i32 94, i32 43, i32 26, ; 56..63
	i32 111, i32 101, i32 69, i32 112, i32 51, i32 83, i32 40, i32 19, ; 64..71
	i32 131, i32 106, i32 98, i32 78, i32 31, i32 120, i32 27, i32 127, ; 72..79
	i32 67, i32 13, i32 19, i32 50, i32 82, i32 9, i32 37, i32 3, ; 80..87
	i32 96, i32 115, i32 80, i32 28, i32 32, i32 109, i32 121, i32 77, ; 88..95
	i32 23, i32 73, i32 108, i32 25, i32 85, i32 10, i32 96, i32 121, ; 96..103
	i32 102, i32 56, i32 116, i32 120, i32 70, i32 43, i32 99, i32 15, ; 104..111
	i32 24, i32 94, i32 63, i32 57, i32 91, i32 32, i32 30, i32 87, ; 112..119
	i32 118, i32 55, i32 50, i32 62, i32 28, i32 111, i32 97, i32 99, ; 120..127
	i32 89, i32 105, i32 65, i32 49, i32 60, i32 14, i32 103, i32 57, ; 128..135
	i32 76, i32 1, i32 6, i32 54, i32 125, i32 93, i32 11, i32 33, ; 136..143
	i32 112, i32 80, i32 84, i32 92, i32 14, i32 41, i32 109, i32 133, ; 144..151
	i32 64, i32 67, i32 46, i32 117, i32 114, i32 52, i32 58, i32 61, ; 152..159
	i32 22, i32 78, i32 35, i32 114, i32 110, i32 61, i32 38, i32 129, ; 160..167
	i32 17, i32 22, i32 115, i32 30, i32 66, i32 53, i32 23, i32 83, ; 168..175
	i32 88, i32 8, i32 5, i32 45, i32 100, i32 39, i32 15, i32 3, ; 176..183
	i32 2, i32 52, i32 123, i32 45, i32 82, i32 40, i32 4, i32 134, ; 184..191
	i32 73, i32 2, i32 71, i32 46, i32 13, i32 81, i32 123, i32 54, ; 192..199
	i32 21, i32 70, i32 101, i32 48, i32 87, i32 51, i32 34, i32 79, ; 200..207
	i32 6, i32 105, i32 31, i32 131, i32 35, i32 1, i32 44, i32 84, ; 208..215
	i32 7, i32 16, i32 34, i32 124, i32 75, i32 71, i32 36, i32 118, ; 216..223
	i32 60, i32 129, i32 103, i32 104, i32 119, i32 66, i32 91, i32 63, ; 224..231
	i32 7, i32 16, i32 130, i32 39, i32 72, i32 75, i32 126, i32 12, ; 232..239
	i32 58, i32 65, i32 100, i32 89, i32 55, i32 74, i32 98, i32 29, ; 240..247
	i32 48, i32 0, i32 42, i32 42, i32 110, i32 79, i32 9, i32 128, ; 248..255
	i32 113, i32 102, i32 125, i32 68, i32 132, i32 53, i32 20, i32 134, ; 256..263
	i32 25, i32 95, i32 0, i32 24, i32 27, i32 95 ; 264..269
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
