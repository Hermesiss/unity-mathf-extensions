# Unity Mathf Extensions

## What is this?

Unity [Mathf](https://docs.unity3d.com/ScriptReference/Mathf.html) extensions for more RX-ish style so you can write

```csharp
var result = a * b * .5f * ((a / b * a2.Tan()).Atan() - (a / b * a1.Tan()).Atan());
```

instead of 
```csharp
var result = a * b * .5f * (Mathf.Atan(a / b * Mathf.Tan(a2)) - Mathf.Atan(a / b * Mathf.Tan(a1)));
```

## Features

* All `UnityEngine.Mathf` methods
* Standard [operators and expressions](https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/operators/)
  * Arithmetical `Add`, `Sub`, `Mul`, `Div`, `Frac`
  * Logical `Neg`, `And`, `Or`, `Xor`, `AndCond`, `OrCond`
  * Bitwise `BitComplement`, `BitLeftShift`, `BitRightShift`, `BitAnd`, `BitOr`, `BitXor`
  * Comparison `Less`, `LessEqual`, `Great`, `GreatEqual`

## Installation

You have several options

### From registry

First, you need to add a scoped registry to `Packages/manifest.json`: 

```json
"scopedRegistries": [
    {
      "name": "trismegistus",
      "url": "http://upm.trismegistus.tech:4873/",
      "scopes": [
        "trismegistus.unity"
      ]
    }
]
```

Then open `Window/Package manager`, `All packages`, and install `Trismegistus Mathf Extensions`

### From git url

1. Open `Window/Package manager`
2. `+`, `Add from git URL`
3. Enter `https://github.com/Hermesiss/unity-mathf-extensions.git?path=/Packages/trismegistus.unity.mathf-extensions`