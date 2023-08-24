// <copyright file="AssemblyInfo.cs" company="Aaron Papp">
// Copyright (c) 2023 Aaron Papp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.
// </copyright>

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("KeePassStringFieldsPasswordFont")]
[assembly: AssemblyDescription("Use the password font in the KeePass 'string fields' text box.")]
[assembly: AssemblyCompany("Aaron Papp")]
[assembly: AssemblyProduct("KeePass Plugin")]
[assembly: AssemblyCopyright("Copyright © Aaron Papp 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// I'm not a fan of this but I don't know if we can use dynamically generated classes in the .plgx version.
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguage("en-US")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("db82e00e-6a30-47cc-981c-393b7d093170")]

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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
