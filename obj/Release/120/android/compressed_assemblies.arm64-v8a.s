	.arch	armv8-a
	.file	"compressed_assemblies.arm64-v8a.arm64-v8a.s"
	.include	"compressed_assemblies.arm64-v8a-data.inc"

	.section	.data.compressed_assembly_descriptors,"aw",@progbits
	.type	.L.compressed_assembly_descriptors, @object
	.p2align	3
.L.compressed_assembly_descriptors:
	/* 0: FitBros2.dll */
	/* uncompressed_file_size */
	.word	333824
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_0

	/* 1: Java.Interop.dll */
	/* uncompressed_file_size */
	.word	165888
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_1

	/* 2: Mono.Android.dll */
	/* uncompressed_file_size */
	.word	1316352
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_2

	/* 3: Mono.Security.dll */
	/* uncompressed_file_size */
	.word	109056
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_3

	/* 4: System.Core.dll */
	/* uncompressed_file_size */
	.word	54784
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_4

	/* 5: System.Net.Http.dll */
	/* uncompressed_file_size */
	.word	212480
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_5

	/* 6: System.Numerics.dll */
	/* uncompressed_file_size */
	.word	25600
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_6

	/* 7: System.dll */
	/* uncompressed_file_size */
	.word	395776
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_7

	/* 8: Xamarin.AndroidX.Activity.dll */
	/* uncompressed_file_size */
	.word	57344
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_8

	/* 9: Xamarin.AndroidX.AppCompat.dll */
	/* uncompressed_file_size */
	.word	324608
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_9

	/* 10: Xamarin.AndroidX.Core.dll */
	/* uncompressed_file_size */
	.word	166400
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_10

	/* 11: Xamarin.AndroidX.CustomView.dll */
	/* uncompressed_file_size */
	.word	9216
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_11

	/* 12: Xamarin.AndroidX.DrawerLayout.dll */
	/* uncompressed_file_size */
	.word	40960
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_12

	/* 13: Xamarin.AndroidX.Fragment.dll */
	/* uncompressed_file_size */
	.word	197120
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_13

	/* 14: Xamarin.AndroidX.Lifecycle.Common.dll */
	/* uncompressed_file_size */
	.word	15360
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_14

	/* 15: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll */
	/* uncompressed_file_size */
	.word	16384
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_15

	/* 16: Xamarin.AndroidX.Lifecycle.ViewModel.dll */
	/* uncompressed_file_size */
	.word	17408
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_16

	/* 17: Xamarin.AndroidX.Loader.dll */
	/* uncompressed_file_size */
	.word	36864
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_17

	/* 18: Xamarin.AndroidX.SavedState.dll */
	/* uncompressed_file_size */
	.word	13312
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_18

	/* 19: Xamarin.Essentials.dll */
	/* uncompressed_file_size */
	.word	25600
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_19

	/* 20: Xamarin.Google.Guava.ListenableFuture.dll */
	/* uncompressed_file_size */
	.word	21880
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_20

	/* 21: Xamarin.Jetbrains.Annotations.dll */
	/* uncompressed_file_size */
	.word	141192
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_21

	/* 22: Xamarin.Kotlin.StdLib.Common.dll */
	/* uncompressed_file_size */
	.word	14216
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_22

	/* 23: Xamarin.Kotlin.StdLib.dll */
	/* uncompressed_file_size */
	.word	2015112
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_23

	/* 24: mscorlib.dll */
	/* uncompressed_file_size */
	.word	1871360
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_24

	.size	.L.compressed_assembly_descriptors, 400
	.section	.data.compressed_assemblies,"aw",@progbits
	.type	compressed_assemblies, @object
	.p2align	3
	.global	compressed_assemblies
compressed_assemblies:
	/* count */
	.word	25
	/* descriptors */
	.zero	4
	.xword	.L.compressed_assembly_descriptors
	.size	compressed_assemblies, 16
