﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SimpleInjector.Extensions")]
[assembly: AssemblyDescription("Extensions for the Simple Injector")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Cutting Edge Internet Technologies")]
[assembly: AssemblyProduct("SimpleInjector.Extensions")]
[assembly: AssemblyCopyright("Copyright © 2010 S. van Deursen")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("86ba2aed-05c4-4b4e-89c6-02da1f63103b")]

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

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

[assembly: AllowPartiallyTrustedCallers]

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
    Target = "SimpleInjector.Extensions",
    Justification = "Cannot really make up new types just to satisfy this rule.")]