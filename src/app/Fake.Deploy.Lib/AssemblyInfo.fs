﻿namespace System
open System.Reflection
open System.Runtime.InteropServices

[<assembly: AssemblyTitleAttribute("FAKE - F# Make Deploy Lib")>]
[<assembly: GuidAttribute("AA284C42-1396-42CB-BCAC-D27F18D14AC7")>]
[<assembly: AssemblyProductAttribute("FAKE - F# Make")>]
[<assembly: AssemblyVersionAttribute("2.12.2")>]
[<assembly: AssemblyInformationalVersionAttribute("2.12.2")>]
[<assembly: AssemblyFileVersionAttribute("2.12.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.12.2"
