
<!-- TOC -->
* [X39.Util.FluentTesting](#x39utilfluenttesting)
* [Compatibility](#compatibility)
* [Getting Started](#getting-started)
* [Creating your own asserts](#creating-your-own-asserts)
* [Informal](#informal)
  * [Building and Testing](#building-and-testing)
  * [Proper documentation for End-Users](#proper-documentation-for-end-users)
  * [Contributing](#contributing)
    * [Code of Conduct](#code-of-conduct)
    * [Contributors Agreement](#contributors-agreement)
  * [License](#license)
<!-- TOC -->

# X39.Util.FluentTesting

This library offers yet another way to do fluent testing.
I started building this because FluentAssertions left the normal FOSS licencing,
triggering my inner urge to write a utility library for testing myself.

# Compatibility

| Test Framework | Compatible | NuGet Package |
|----------------|------------|---------------|
| XUnit          | ✅          | todo          |
| NUnit          | ❌          | -             |
| MSTest         | ❌          | -             |

# Getting Started
Install the corresponding library of your choice and start doing as follows:
[README.md](../X39.Solutions.PdfTemplate/README.md)
```csharp
public void MyTestMethod()
{
    Expect.That.Value(1).Is().Equal().To(1);
}
```

# Creating your own asserts
The library uses Extension methods around structures to build the assertion
chain. To create your own, pick the correct entrance of your choice and
simply create your own extension method.

All assertions start at `Expect.That`, which creates a `ThatValue`.

# Informal

## Building and Testing

This project uses GitHub Actions for continuous integration. The workflow is defined in `.github/workflows/main.yml`. It
includes steps for restoring dependencies, building the project, running tests, and publishing a NuGet package.

To run the tests locally, use the following command:

```shell
dotnet test --framework net7.0 --no-build --verbosity normal
```

## Proper documentation for End-Users

While the code is documented, an appropriate documentation for end-users is still missing.
This is planned tho given that this is a spare-time project, it might take a while and does not have a high priority (on
my list).
Feel free to contribute to this project by adding documentation for end-users (e.g. using JetBrains Writerside or
similar tools) and
submitting a pull request. I will gladly review it and provide the necessary web-hosting in this repository (including a
domain).

## Contributing

Contributions are welcome!
Please submit a pull request or create a discussion to discuss any changes you wish to make.

### Code of Conduct

Be excellent to each other.

### Contributors Agreement

First of all, thank you for your interest in contributing to this project!
Please add yourself to the list of contributors in the [CONTRIBUTORS](CONTRIBUTORS.md) file when submitting your
first pull request.
Also, please always add the following to your pull request:

```
By contributing to this project, you agree to the following terms:
- You grant me and any other person who receives a copy of this project the right to use your contribution under the
  terms of the GNU Lesser General Public License v3.0.
- You grant me and any other person who receives a copy of this project the right to relicense your contribution under
  any other license.
- You grant me and any other person who receives a copy of this project the right to change your contribution.
- You waive your right to your contribution and transfer all rights to me and every user of this project.
- You agree that your contribution is free of any third-party rights.
- You agree that your contribution is given without any compensation.
- You agree that I may remove your contribution at any time for any reason.
- You confirm that you have the right to grant the above rights and that you are not violating any third-party rights
  by granting these rights.
- You confirm that your contribution is not subject to any license agreement or other agreement or obligation, which
  conflicts with the above terms.
```

This is necessary to ensure that this project can be licensed under the GNU Lesser General Public License v3.0 and
that a license change is possible in the future if necessary (e.g., to a more permissive license).
It also ensures that I can remove your contribution if necessary (e.g., because it violates third-party rights) and
that I can change your contribution if necessary (e.g., to fix a typo, change implementation details, or improve
performance).
It also shields me and every user of this project from any liability regarding your contribution by deflecting any
potential liability caused by your contribution to you (e.g., if your contribution violates the rights of your
employer).
Feel free to discuss this agreement in the discussions section of this repository, i am open to changes here (as long as
they do not open me or any other user of this project to any liability due to a **malicious contribution**).


## License

This project is licensed under the GNU Lesser General Public License v3.0. See the [LICENSE](LICENSE) file for details.
