﻿// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Rock.Version" )]
[assembly: AssemblyDescription( "This assembly represents the official version number for Rock." )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Spark Development Network" )]
[assembly: AssemblyProduct( "Rock" )]
[assembly: AssemblyCopyright( "Copyright © Spark Development Network 2011-2014" )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "8db1acaa-10dd-4afb-bd0e-2f823dbb345d" )]

// 
// WARNING: Before you monkey with any of these values
// make sure you read "The bottom line:" in this article: 
// http://stackoverflow.com/questions/64602/what-are-differences-between-assemblyversion-assemblyfileversion-and-assemblyin

// Based on my analysis, the AssemblyVersion number should change only when we are
// making a breaking change and need the runtime binding to fail if it does not
// match the correct version exactly.

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion( "0.0" )]
[assembly: AssemblyFileVersion( "1.0.6.0" )]

// This number can change for each build (and should change) so that we can correctly
// identify exactly which version someone is running.  This number should increment
// for nightly, automated builds.

// NOTE: This item will be auto-generated by the msbuild task in this project's .csproj file's
// BeforeBuild target.  Therefore it should remain commented out.

//[assembly: AssemblyFileVersion( "0.0.1.*" )]

// This is the "official" product name that will be shown to people. 
// It's shown in the SystemInfo details and perhaps the RockUpdate page.
// JICK - J(on) / (N)ick versioning system.
[assembly: AssemblyInformationalVersion( "Rock McKinley 0.6 (beta)" )]
//[assembly: AssemblyInformationalVersion( "Rock McKinley 0.7 (beta)" )]    // 1.0.7
//[assembly: AssemblyInformationalVersion( "Rock McKinley 1.0" )]           // 1.1.0