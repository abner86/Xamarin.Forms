﻿using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

#if !MXBUILD
[assembly: AssemblyTitle("Xamarin.Forms.Maps")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCulture("")]
#endif
[assembly: NeutralResourcesLanguage("en")]
#if !MXBUILD
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Android")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.WP8")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.UWP")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.WinRT.Phone")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.WinRT.Tablet")]
#else
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Portable")]
#endif
[assembly: InternalsVisibleTo("iOSUnitTests")]
#if !MXBUILD
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.UnitTests")]
#else
[assembly: InternalsVisibleTo("Xamarin.Forms.UnitTests")]
#endif
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.WP8.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Design")]
#if !MXBUILD
[assembly: Preserve]
#endif