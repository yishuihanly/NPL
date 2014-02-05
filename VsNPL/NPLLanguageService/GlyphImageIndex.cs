﻿
namespace ParaEngine.Tools.Lua
{
    public enum GlyphImageIndex
    {
        // Each icon type has 6 versions, corresponding to the following
        // access types.
        AccessPublic = 0,
        AccessInternal = 1,
        AccessFriend = 2,
        AccessProtected = 3,
        AccessPrivate = 4,
        AccessShortcut = 5,

        Base = 6,

        Class = Base * 0,
        Constant = Base * 1,
        Delegate = Base * 2,
        Enumeration = Base * 3,
        EnumMember = Base * 4,
        Event = Base * 5,
        Exception = Base * 6,
        Field = Base * 7,
        Interface = Base * 8,
        Macro = Base * 9,
        Map = Base * 10,
        MapItem = Base * 11,
        Method = Base * 12,
        OverloadedMethod = Base * 13,
        Module = Base * 14,
        Namespace = Base * 15,
        Operator = Base * 16,
        Property = Base * 17,
        Struct = Base * 18,
        Template = Base * 19,
        Typedef = Base * 20,
        Type = Base * 21,
        Union = Base * 22,
        Variable = Base * 23,
        ValueType = Base * 24,
        Intrinsic = Base * 25,
        JavaMethod = Base * 26,
        JavaField = Base * 27,
        JavaClass = Base * 28,
        JavaNamespace = Base * 29,
        JavaInterface = Base * 30,

        // Miscellaneous icons with one icon for each type.
        Error = 186,
        GreyedClass = 187,
        GreyedPrivateMethod = 188,
        GreyedProtectedMethod = 189,
        GreyedPublicMethod = 190,
        BrowseResourceFile = 191,
        Reference = 192,
        Library = 193,
        VBProject = 194,
        VBWebProject = 195,
        CSProject = 196,
        CSWebProject = 197,
        VB6Project = 198,
        CPlusProject = 199,
        Form = 200,
        OpenFolder = 201,
        ClosedFolder = 202,
        Arrow = 203,
        CSClass = 204,
        Snippet = 205,
        Keyword = 206,
        Info = 207,
        CallBrowserCall = 208,
        CallBrowserCallRecursive = 209,
        XMLEditor = 210,
        VJProject = 211,
        VJClass = 212,
        ForwardedType = 213,
        CallsTo = 214,
        CallsFrom = 215,
        Warning = 216,
    }
}