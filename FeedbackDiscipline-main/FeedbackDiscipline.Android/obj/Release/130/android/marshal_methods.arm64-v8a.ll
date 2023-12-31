; ModuleID = 'obj\Release\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Release\130\android\marshal_methods.arm64-v8a.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [132 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 4
	i64 181099460066822533, ; 1: Microcharts.Droid.dll => 0x28364ffda4c4985 => 40
	i64 232391251801502327, ; 2: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 57
	i64 702024105029695270, ; 3: System.Drawing.Common => 0x9be17343c0e7726 => 34
	i64 720058930071658100, ; 4: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 24
	i64 872800313462103108, ; 5: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 22
	i64 887546508555532406, ; 6: Microcharts.Forms => 0xc5132d8dc173876 => 41
	i64 996343623809489702, ; 7: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 61
	i64 1000557547492888992, ; 8: Mono.Security.dll => 0xde2b1c9cba651a0 => 37
	i64 1120440138749646132, ; 9: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 32
	i64 1416135423712704079, ; 10: Microcharts => 0x13a71faa343e364f => 39
	i64 1425944114962822056, ; 11: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 1
	i64 1624659445732251991, ; 12: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 14
	i64 1731380447121279447, ; 13: Newtonsoft.Json => 0x18071957e9b889d7 => 47
	i64 1795316252682057001, ; 14: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 15
	i64 1836611346387731153, ; 15: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 57
	i64 1865037103900624886, ; 16: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 42
	i64 1981742497975770890, ; 17: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 27
	i64 2040001226662520565, ; 18: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 0
	i64 2133195048986300728, ; 19: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 47
	i64 2165725771938924357, ; 20: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 16
	i64 2262844636196693701, ; 21: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 22
	i64 2284400282711631002, ; 22: System.Web.Services => 0x1fb3d1f42fd4249a => 35
	i64 2329709569556905518, ; 23: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 26
	i64 2335503487726329082, ; 24: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 54
	i64 2337758774805907496, ; 25: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 11
	i64 2470498323731680442, ; 26: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 18
	i64 2547086958574651984, ; 27: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 56
	i64 2592350477072141967, ; 28: System.Xml.dll => 0x23f9e10627330e8f => 12
	i64 2612152650457191105, ; 29: Microsoft.IdentityModel.Tokens.dll => 0x24403afeed9892c1 => 46
	i64 2624866290265602282, ; 30: mscorlib.dll => 0x246d65fbde2db8ea => 5
	i64 2783046991838674048, ; 31: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 11
	i64 2789714023057451704, ; 32: Microsoft.IdentityModel.JsonWebTokens.dll => 0x26b70e1f9943eab8 => 44
	i64 2960931600190307745, ; 33: Xamarin.Forms.Core => 0x2917579a49927da1 => 59
	i64 3017704767998173186, ; 34: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 32
	i64 3122911337338800527, ; 35: Microcharts.dll => 0x2b56cf50bf1e898f => 39
	i64 3135710569046186342, ; 36: FeedbackDiscipline.Android => 0x2b8448261a6f9966 => 64
	i64 3289520064315143713, ; 37: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 25
	i64 3402534845034375023, ; 38: System.IdentityModel.Tokens.Jwt.dll => 0x2f383b6a0629a76f => 53
	i64 3522470458906976663, ; 39: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 30
	i64 3531994851595924923, ; 40: System.Numerics => 0x31042a9aade235bb => 10
	i64 3727469159507183293, ; 41: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 29
	i64 4525561845656915374, ; 42: System.ServiceModel.Internals => 0x3ece06856b710dae => 36
	i64 4794310189461587505, ; 43: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 56
	i64 4795410492532947900, ; 44: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 30
	i64 5142919913060024034, ; 45: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 60
	i64 5203618020066742981, ; 46: Xamarin.Essentials => 0x4836f704f0e652c5 => 58
	i64 5507995362134886206, ; 47: System.Core.dll => 0x4c705499688c873e => 7
	i64 5701169857135624461, ; 48: FeedbackDiscipline => 0x4f1e9fc76abbc10d => 65
	i64 6085203216496545422, ; 49: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 61
	i64 6086316965293125504, ; 50: FormsViewGroup.dll => 0x5476f10882baef80 => 38
	i64 6222399776351216807, ; 51: System.Text.Json.dll => 0x565a67a0ffe264a7 => 55
	i64 6276613759455078625, ; 52: Okta.Xamarin.dll => 0x571b02f594a628e1 => 49
	i64 6401687960814735282, ; 53: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 26
	i64 6504860066809920875, ; 54: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 16
	i64 6548213210057960872, ; 55: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 21
	i64 6591024623626361694, ; 56: System.Web.Services.dll => 0x5b7805f9751a1b5e => 35
	i64 6659513131007730089, ; 57: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 24
	i64 6671798237668743565, ; 58: SkiaSharp => 0x5c96fd260152998d => 50
	i64 6876862101832370452, ; 59: System.Xml.Linq => 0x5f6f85a57d108914 => 13
	i64 7488575175965059935, ; 60: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 13
	i64 7496222613193209122, ; 61: System.IdentityModel.Tokens.Jwt => 0x6807eec000a1b522 => 53
	i64 7635363394907363464, ; 62: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 59
	i64 7637365915383206639, ; 63: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 58
	i64 7654504624184590948, ; 64: System.Net.Http => 0x6a3a4366801b8264 => 9
	i64 7735176074855944702, ; 65: Microsoft.CSharp => 0x6b58dda848e391fe => 3
	i64 7820441508502274321, ; 66: System.Data => 0x6c87ca1e14ff8111 => 33
	i64 7836164640616011524, ; 67: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 14
	i64 7927939710195668715, ; 68: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 51
	i64 8083354569033831015, ; 69: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 25
	i64 8167236081217502503, ; 70: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8187102936927221770, ; 71: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 52
	i64 8626175481042262068, ; 72: Java.Interop => 0x77b654e585b55834 => 2
	i64 8638972117149407195, ; 73: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 3
	i64 9150689056026028438, ; 74: FeedbackDiscipline.dll => 0x7efdc736ca7c6996 => 65
	i64 9324707631942237306, ; 75: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 15
	i64 9427266486299436557, ; 76: Microsoft.IdentityModel.Logging.dll => 0x82d460ebe6d2a60d => 45
	i64 9662334977499516867, ; 77: System.Numerics.dll => 0x8617827802b0cfc3 => 10
	i64 9678050649315576968, ; 78: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 18
	i64 9808709177481450983, ; 79: Mono.Android.dll => 0x881f890734e555e7 => 4
	i64 9998632235833408227, ; 80: Mono.Security => 0x8ac2470b209ebae3 => 37
	i64 10038780035334861115, ; 81: System.Net.Http.dll => 0x8b50e941206af13b => 9
	i64 10229024438826829339, ; 82: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 21
	i64 10430153318873392755, ; 83: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 19
	i64 10447083246144586668, ; 84: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 42
	i64 11023048688141570732, ; 85: System.Core => 0x98f9bc61168392ac => 7
	i64 11037814507248023548, ; 86: System.Xml => 0x992e31d0412bf7fc => 12
	i64 11162124722117608902, ; 87: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 31
	i64 11340910727871153756, ; 88: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 20
	i64 11517440453979132662, ; 89: Microsoft.IdentityModel.Abstractions.dll => 0x9fd62b122523d2f6 => 43
	i64 11529969570048099689, ; 90: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 31
	i64 12102847907131387746, ; 91: System.Buffers => 0xa7f5f40c43256f62 => 6
	i64 12145679461940342714, ; 92: System.Text.Json => 0xa88e1f1ebcb62fba => 55
	i64 12307291687973536691, ; 93: Okta.Xamarin.Android => 0xaacc489558c7c3b3 => 48
	i64 12439275739440478309, ; 94: Microsoft.IdentityModel.JsonWebTokens => 0xaca12f61007bf865 => 44
	i64 12451044538927396471, ; 95: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 23
	i64 12466513435562512481, ; 96: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 28
	i64 12538491095302438457, ; 97: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 17
	i64 12898955242700436758, ; 98: Okta.Xamarin => 0xb3024b739ed27516 => 49
	i64 12963446364377008305, ; 99: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 34
	i64 13370592475155966277, ; 100: System.Runtime.Serialization => 0xb98de304062ea945 => 1
	i64 13403416310143541304, ; 101: Microcharts.Droid => 0xba02801ea6c86038 => 40
	i64 13454009404024712428, ; 102: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 63
	i64 13492263892638604996, ; 103: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 52
	i64 13572454107664307259, ; 104: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 29
	i64 13647894001087880694, ; 105: System.Data.dll => 0xbd670f48cb071df6 => 33
	i64 13959074834287824816, ; 106: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 23
	i64 13967638549803255703, ; 107: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 60
	i64 14124974489674258913, ; 108: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 17
	i64 14551742072151931844, ; 109: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 54
	i64 14792063746108907174, ; 110: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 63
	i64 14852515768018889994, ; 111: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 20
	i64 15138356091203993725, ; 112: Microsoft.IdentityModel.Abstractions => 0xd2163ea89395c07d => 43
	i64 15370334346939861994, ; 113: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 19
	i64 15609085926864131306, ; 114: System.dll => 0xd89e9cf3334914ea => 8
	i64 15810740023422282496, ; 115: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 62
	i64 15963349826457351533, ; 116: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 0
	i64 16154507427712707110, ; 117: System => 0xe03056ea4e39aa26 => 8
	i64 16324796876805858114, ; 118: SkiaSharp.dll => 0xe28d5444586b6342 => 50
	i64 16757453548800217720, ; 119: Okta.Xamarin.Android.dll => 0xe88e6f37c4589278 => 48
	i64 16833383113903931215, ; 120: mscorlib => 0xe99c30c1484d7f4f => 5
	i64 17001062948826229159, ; 121: Microcharts.Forms.dll => 0xebefe8ad2cd7a9a7 => 41
	i64 17137864900836977098, ; 122: Microsoft.IdentityModel.Tokens => 0xedd5ed53b705e9ca => 46
	i64 17671790519499593115, ; 123: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 51
	i64 17704177640604968747, ; 124: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 28
	i64 17710060891934109755, ; 125: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 27
	i64 17790600151040787804, ; 126: Microsoft.IdentityModel.Logging => 0xf6e4e89427cc055c => 45
	i64 17838668724098252521, ; 127: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 6
	i64 17882897186074144999, ; 128: FormsViewGroup => 0xf82cd03e3ac830e7 => 38
	i64 17892495832318972303, ; 129: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 62
	i64 18129453464017766560, ; 130: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 36
	i64 18311231973601736124 ; 131: FeedbackDiscipline.Android.dll => 0xfe1e9076824e75bc => 64
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [132 x i32] [
	i32 4, i32 40, i32 57, i32 34, i32 24, i32 22, i32 41, i32 61, ; 0..7
	i32 37, i32 32, i32 39, i32 1, i32 14, i32 47, i32 15, i32 57, ; 8..15
	i32 42, i32 27, i32 0, i32 47, i32 16, i32 22, i32 35, i32 26, ; 16..23
	i32 54, i32 11, i32 18, i32 56, i32 12, i32 46, i32 5, i32 11, ; 24..31
	i32 44, i32 59, i32 32, i32 39, i32 64, i32 25, i32 53, i32 30, ; 32..39
	i32 10, i32 29, i32 36, i32 56, i32 30, i32 60, i32 58, i32 7, ; 40..47
	i32 65, i32 61, i32 38, i32 55, i32 49, i32 26, i32 16, i32 21, ; 48..55
	i32 35, i32 24, i32 50, i32 13, i32 13, i32 53, i32 59, i32 58, ; 56..63
	i32 9, i32 3, i32 33, i32 14, i32 51, i32 25, i32 2, i32 52, ; 64..71
	i32 2, i32 3, i32 65, i32 15, i32 45, i32 10, i32 18, i32 4, ; 72..79
	i32 37, i32 9, i32 21, i32 19, i32 42, i32 7, i32 12, i32 31, ; 80..87
	i32 20, i32 43, i32 31, i32 6, i32 55, i32 48, i32 44, i32 23, ; 88..95
	i32 28, i32 17, i32 49, i32 34, i32 1, i32 40, i32 63, i32 52, ; 96..103
	i32 29, i32 33, i32 23, i32 60, i32 17, i32 54, i32 63, i32 20, ; 104..111
	i32 43, i32 19, i32 8, i32 62, i32 0, i32 8, i32 50, i32 48, ; 112..119
	i32 5, i32 41, i32 46, i32 51, i32 28, i32 27, i32 45, i32 6, ; 120..127
	i32 38, i32 62, i32 36, i32 64 ; 128..131
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
