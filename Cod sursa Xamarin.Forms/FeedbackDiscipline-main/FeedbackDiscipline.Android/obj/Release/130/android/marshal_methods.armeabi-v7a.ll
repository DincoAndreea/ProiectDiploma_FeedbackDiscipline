; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [132 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 63
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 47
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 59
	i32 182336117, ; 3: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 30
	i32 209399409, ; 4: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 16
	i32 230752869, ; 5: Microsoft.CSharp.dll => 0xdc10265 => 3
	i32 232815796, ; 6: System.Web.Services => 0xde07cb4 => 35
	i32 318968648, ; 7: Xamarin.AndroidX.Activity.dll => 0x13031348 => 56
	i32 321597661, ; 8: System.Numerics => 0x132b30dd => 10
	i32 342366114, ; 9: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 25
	i32 442521989, ; 10: Xamarin.Essentials => 0x1a605985 => 58
	i32 450948140, ; 11: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 23
	i32 465846621, ; 12: mscorlib => 0x1bc4415d => 5
	i32 469710990, ; 13: System.dll => 0x1bff388e => 8
	i32 485463106, ; 14: Microsoft.IdentityModel.Abstractions => 0x1cef9442 => 43
	i32 507578056, ; 15: Okta.Xamarin.dll => 0x1e4106c8 => 49
	i32 525008092, ; 16: SkiaSharp.dll => 0x1f4afcdc => 50
	i32 548916678, ; 17: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 42
	i32 627609679, ; 18: Xamarin.AndroidX.CustomView => 0x2568904f => 21
	i32 662205335, ; 19: System.Text.Encodings.Web.dll => 0x27787397 => 54
	i32 690569205, ; 20: System.Xml.Linq.dll => 0x29293ff5 => 13
	i32 764776452, ; 21: FeedbackDiscipline => 0x2d959004 => 65
	i32 809851609, ; 22: System.Drawing.Common.dll => 0x30455ad9 => 34
	i32 886248193, ; 23: Microcharts.Droid => 0x34d31301 => 40
	i32 928116545, ; 24: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 63
	i32 955402788, ; 25: Newtonsoft.Json => 0x38f24a24 => 47
	i32 967690846, ; 26: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 25
	i32 974778368, ; 27: FormsViewGroup.dll => 0x3a19f000 => 38
	i32 1012816738, ; 28: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 57
	i32 1035644815, ; 29: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 15
	i32 1042160112, ; 30: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 61
	i32 1052210849, ; 31: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 27
	i32 1098259244, ; 32: System => 0x41761b2c => 8
	i32 1293217323, ; 33: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 22
	i32 1323988371, ; 34: Okta.Xamarin.Android => 0x4eea7593 => 48
	i32 1365406463, ; 35: System.ServiceModel.Internals.dll => 0x516272ff => 36
	i32 1376866003, ; 36: Xamarin.AndroidX.SavedState => 0x52114ed3 => 57
	i32 1406073936, ; 37: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 18
	i32 1411638395, ; 38: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 11
	i32 1460219004, ; 39: Xamarin.Forms.Xaml => 0x57092c7c => 62
	i32 1460893475, ; 40: System.IdentityModel.Tokens.Jwt => 0x57137723 => 53
	i32 1469204771, ; 41: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 14
	i32 1498168481, ; 42: Microsoft.IdentityModel.JsonWebTokens.dll => 0x594c3ca1 => 44
	i32 1544850751, ; 43: Okta.Xamarin.Android.dll => 0x5c148d3f => 48
	i32 1582526884, ; 44: Microcharts.Forms.dll => 0x5e5371a4 => 41
	i32 1592978981, ; 45: System.Runtime.Serialization.dll => 0x5ef2ee25 => 1
	i32 1622152042, ; 46: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 28
	i32 1636350590, ; 47: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 20
	i32 1639515021, ; 48: System.Net.Http.dll => 0x61b9038d => 9
	i32 1658251792, ; 49: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 32
	i32 1722051300, ; 50: SkiaSharp.Views.Forms => 0x66a46ae4 => 52
	i32 1729485958, ; 51: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 17
	i32 1766324549, ; 52: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 30
	i32 1776026572, ; 53: System.Core.dll => 0x69dc03cc => 7
	i32 1788241197, ; 54: Xamarin.AndroidX.Fragment => 0x6a96652d => 23
	i32 1796167890, ; 55: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 42
	i32 1808609942, ; 56: Xamarin.AndroidX.Loader => 0x6bcd3296 => 28
	i32 1813201214, ; 57: Xamarin.Google.Android.Material => 0x6c13413e => 32
	i32 1867746548, ; 58: Xamarin.Essentials.dll => 0x6f538cf4 => 58
	i32 1878053835, ; 59: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 62
	i32 1986222447, ; 60: Microsoft.IdentityModel.Tokens.dll => 0x7663596f => 46
	i32 2011961780, ; 61: System.Buffers.dll => 0x77ec19b4 => 6
	i32 2019465201, ; 62: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 27
	i32 2055257422, ; 63: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 26
	i32 2097448633, ; 64: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 24
	i32 2126786730, ; 65: Xamarin.Forms.Platform.Android => 0x7ec430aa => 60
	i32 2201231467, ; 66: System.Net.Http => 0x8334206b => 9
	i32 2279755925, ; 67: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 29
	i32 2369706906, ; 68: Microsoft.IdentityModel.Logging => 0x8d3edb9a => 45
	i32 2475788418, ; 69: Java.Interop.dll => 0x93918882 => 2
	i32 2562349572, ; 70: Microsoft.CSharp => 0x98ba5a04 => 3
	i32 2570120770, ; 71: System.Text.Encodings.Web => 0x9930ee42 => 54
	i32 2620871830, ; 72: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 20
	i32 2640290731, ; 73: Microsoft.IdentityModel.Logging.dll => 0x9d5fa3ab => 45
	i32 2732626843, ; 74: Xamarin.AndroidX.Activity => 0xa2e0939b => 56
	i32 2737747696, ; 75: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 14
	i32 2766581644, ; 76: Xamarin.Forms.Core => 0xa4e6af8c => 59
	i32 2778768386, ; 77: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 31
	i32 2795602088, ; 78: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 51
	i32 2810250172, ; 79: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 18
	i32 2819470561, ; 80: System.Xml.dll => 0xa80db4e1 => 12
	i32 2853208004, ; 81: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 31
	i32 2905242038, ; 82: mscorlib.dll => 0xad2a79b6 => 5
	i32 2912489636, ; 83: SkiaSharp.Views.Android => 0xad9910a4 => 51
	i32 2974793899, ; 84: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 52
	i32 2978675010, ; 85: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 22
	i32 3036068679, ; 86: Microcharts.Droid.dll => 0xb4f6bb47 => 40
	i32 3044182254, ; 87: FormsViewGroup => 0xb57288ee => 38
	i32 3084678329, ; 88: Microsoft.IdentityModel.Tokens => 0xb7dc74b9 => 46
	i32 3111772706, ; 89: System.Runtime.Serialization => 0xb979e222 => 1
	i32 3124832203, ; 90: System.Threading.Tasks.Extensions => 0xba4127cb => 0
	i32 3204380047, ; 91: System.Data.dll => 0xbefef58f => 33
	i32 3247209679, ; 92: FeedbackDiscipline.dll => 0xc18c7ccf => 65
	i32 3247949154, ; 93: Mono.Security => 0xc197c562 => 37
	i32 3258312781, ; 94: Xamarin.AndroidX.CardView => 0xc235e84d => 17
	i32 3265893370, ; 95: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 0
	i32 3312457198, ; 96: Microsoft.IdentityModel.JsonWebTokens => 0xc57015ee => 44
	i32 3317135071, ; 97: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 21
	i32 3317144872, ; 98: System.Data => 0xc5b79d28 => 33
	i32 3340387945, ; 99: SkiaSharp => 0xc71a4669 => 50
	i32 3353484488, ; 100: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 24
	i32 3358260929, ; 101: System.Text.Json => 0xc82afec1 => 55
	i32 3362522851, ; 102: Xamarin.AndroidX.Core => 0xc86c06e3 => 19
	i32 3366347497, ; 103: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 104: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 29
	i32 3395150330, ; 105: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 11
	i32 3404865022, ; 106: System.ServiceModel.Internals => 0xcaf21dfe => 36
	i32 3429136800, ; 107: System.Xml => 0xcc6479a0 => 12
	i32 3455791806, ; 108: Microcharts => 0xcdfb32be => 39
	i32 3476120550, ; 109: Mono.Android => 0xcf3163e6 => 4
	i32 3485117614, ; 110: System.Text.Json.dll => 0xcfbaacae => 55
	i32 3509114376, ; 111: System.Xml.Linq => 0xd128d608 => 13
	i32 3536029504, ; 112: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 60
	i32 3632359727, ; 113: Xamarin.Forms.Platform => 0xd881692f => 61
	i32 3641597786, ; 114: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 26
	i32 3668042751, ; 115: Microcharts.dll => 0xdaa1e3ff => 39
	i32 3672681054, ; 116: Mono.Android.dll => 0xdae8aa5e => 4
	i32 3676310014, ; 117: System.Web.Services.dll => 0xdb2009fe => 35
	i32 3682565725, ; 118: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 16
	i32 3689375977, ; 119: System.Drawing.Common => 0xdbe768e9 => 34
	i32 3700591436, ; 120: Microsoft.IdentityModel.Abstractions.dll => 0xdc928b4c => 43
	i32 3829621856, ; 121: System.Numerics.dll => 0xe4436460 => 10
	i32 3860913051, ; 122: FeedbackDiscipline.Android => 0xe620db9b => 64
	i32 3896760992, ; 123: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 19
	i32 3903721208, ; 124: Microcharts.Forms => 0xe8ae0ef8 => 41
	i32 3955647286, ; 125: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 15
	i32 4104167530, ; 126: Okta.Xamarin => 0xf4a0a06a => 49
	i32 4105002889, ; 127: Mono.Security.dll => 0xf4ad5f89 => 37
	i32 4151237749, ; 128: System.Core => 0xf76edc75 => 7
	i32 4196557070, ; 129: FeedbackDiscipline.Android.dll => 0xfa22610e => 64
	i32 4260525087, ; 130: System.Buffers => 0xfdf2741f => 6
	i32 4263231520 ; 131: System.IdentityModel.Tokens.Jwt.dll => 0xfe1bc020 => 53
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [132 x i32] [
	i32 63, i32 47, i32 59, i32 30, i32 16, i32 3, i32 35, i32 56, ; 0..7
	i32 10, i32 25, i32 58, i32 23, i32 5, i32 8, i32 43, i32 49, ; 8..15
	i32 50, i32 42, i32 21, i32 54, i32 13, i32 65, i32 34, i32 40, ; 16..23
	i32 63, i32 47, i32 25, i32 38, i32 57, i32 15, i32 61, i32 27, ; 24..31
	i32 8, i32 22, i32 48, i32 36, i32 57, i32 18, i32 11, i32 62, ; 32..39
	i32 53, i32 14, i32 44, i32 48, i32 41, i32 1, i32 28, i32 20, ; 40..47
	i32 9, i32 32, i32 52, i32 17, i32 30, i32 7, i32 23, i32 42, ; 48..55
	i32 28, i32 32, i32 58, i32 62, i32 46, i32 6, i32 27, i32 26, ; 56..63
	i32 24, i32 60, i32 9, i32 29, i32 45, i32 2, i32 3, i32 54, ; 64..71
	i32 20, i32 45, i32 56, i32 14, i32 59, i32 31, i32 51, i32 18, ; 72..79
	i32 12, i32 31, i32 5, i32 51, i32 52, i32 22, i32 40, i32 38, ; 80..87
	i32 46, i32 1, i32 0, i32 33, i32 65, i32 37, i32 17, i32 0, ; 88..95
	i32 44, i32 21, i32 33, i32 50, i32 24, i32 55, i32 19, i32 2, ; 96..103
	i32 29, i32 11, i32 36, i32 12, i32 39, i32 4, i32 55, i32 13, ; 104..111
	i32 60, i32 61, i32 26, i32 39, i32 4, i32 35, i32 16, i32 34, ; 112..119
	i32 43, i32 10, i32 64, i32 19, i32 41, i32 15, i32 49, i32 37, ; 120..127
	i32 7, i32 64, i32 6, i32 53 ; 128..131
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
