using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if RELEASE
//[assembly: Obfuscation(Exclude = false, Feature = "preset(none);+anti ildasm;+anti tamper;+constants;+ctrl flow;+anti dump;+anti debug;+ref proxy;")]
[assembly: Obfuscation(Exclude = false, Feature = "preset(none);+anti ildasm;+anti tamper;+constants;+ctrl flow;+anti dump;+anti debug;+ref proxy;+rename(mode=letters,flatten=false);")]
#endif

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("EnovaPasswordReset")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("MystticSolutions")]
[assembly: AssemblyProduct("EnovaPasswordReset")]
[assembly: AssemblyCopyright("Copyright © Mysttic 2022")]
[assembly: AssemblyTrademark("MD")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("74198d8a-9648-4b5b-becc-78c0c50e974f")]

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
[assembly: AssemblyVersion("2103.1.23.0916")]
[assembly: AssemblyFileVersion("2103.1.23.0916")]
