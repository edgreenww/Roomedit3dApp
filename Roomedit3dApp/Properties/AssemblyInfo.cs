using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Roomedit3dApp" )]
[assembly: AssemblyDescription( "C# .NET Revit API add-in using socket.io to subscribe to real-time roomedit3d BIM updates" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "Roomedit3dApp Revit C# .NET Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2016 (C) Jeremy Tammik, Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// History:
//
// 2016-05-19 2017.0.0.0 initial commit
// 2016-05-19 2017.0.0.1 implemented toggle subscription external command
// 2016-05-19 2017.0.0.1 implemented external event and its handler, added BimUpdater and Util classes
// 2016-05-19 2017.0.0.2 initial experimental socket and removed architecture mismatch warning
// 2016-05-19 2017.0.0.2 Roomedit3dSocketTest works, receiving messages from roomedit3d web server
// 2016-05-26 2017.0.0.3 Roomedit3dApp socket connection works, receiving messages from roomedit3d web server
// 2016-05-26 2017.0.0.4 Roomedit3dApp transformation works, updating BIM from viewer live
// 2016-06-13 2017.0.0.5 updated to new heroku url for roomedit3dv2 using oauth2
// 2016-10-03 2017.0.0.6 updated to new heroku url for roomedit3dv3
//
[assembly: AssemblyVersion( "2017.0.0.6" )]
[assembly: AssemblyFileVersion( "2017.0.0.6" )]
