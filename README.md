# Blazorise components for Blazor

Blazorise is a component library built on top of [Blazor](https://blazor.net/) and CSS frameworks like Bootstrap, Bulma and Material.

## Demos

Please look at demos to see Blazorise in action.

- [Bootstrap Demo](https://bootstrapdemo.blazorise.com)
- [Material Demo](https://materialdemo.blazorise.com/)
- [Bulma Demo](https://bulmademo.blazorise.com/) (PREVIEW)

```
Note: This project is still experimental so it's possible that some components will be removed or refactored.
```

[Releases](https://blazorise.com/docs/releases/) and [Roadmap](https://blazorise.com/docs/roadmap/)

## Feeds

* [![NuGet](https://img.shields.io/nuget/vpre/Blazorise.svg)](https://www.nuget.org/profiles/stsrki) ![Nuget](https://img.shields.io/nuget/dt/Blazorise.svg)
* [![Join the chat at https://gitter.im/stsrki/Blazorise](https://badges.gitter.im/stsrki/Blazorise.svg)](https://gitter.im/stsrki/Blazorise?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Installation

Each of the supported css framework is defined by a diferent nuget package. To install them you must run one of the following commands:

```
Install-Package Blazorise.Bootstrap
or
Install-Package Blazorise.Material
or
Install-Package Blazorise.Bulma
```
Note that Bulma implementation is still in progress.

## Usage

The setup process is the same for all supported frameworks, just replace Bootstrap with the one you need.

Now, for a bootstrap framework you must do:

1. in index.html add:

```html
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
```

2. In your main _ViewImports.cshtml add:

```cs
@addTagHelper *, Blazorise

@using Blazorise
```

3. In Startup.cs add:

```cshtml
using Blazorise;
using Blazorise.Bootstrap;

public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBootstrapProviders()
    .AddIconProvider( IconProvider.FontAwesome );
}
```

To setup Blazorise for other frameworks please refer the [Usage](https://blazorise.com/docs/usage/) page in the documentation.

