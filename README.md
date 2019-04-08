| <img src="https://github.com/identicons/londresri.png" width=100 alt="GitHub identicon for author LondresRi"> |
|:-----:|
| [**LondresRi**](https://github.com/LondresRi )|

## | **Word Counter Project** |

#### By Shawn Lunsford & Sam Stoia
###### Initiated February 15th, 2019. Last Updated February 19th, 2019.

----------

## Description
A simple program that counts the number of occurrences in a user-inputted string that a user's word appears. Part of the Epicodus C# coursework, independent project, coded in C#.

## Known Bugs

* No known bugs.

## Specifications

| Behavior | Input | Output |
|----------|:-----:|:------:|
| Program accepts user inputs | "\Ca$T!1?" | "\Ca$T!1?" |
| Word and sentence filtered for cohesion | "*Ca$T!1?" | "cat" |
| Sentence broken into word-only array | "That is a cat." | "that, is, a, cat" |
| Compare word to array | "cat" == "this, is, a, cat" | Match success |
| Program counts number of match occurrences | "cat" = "that, cat, is, a, cat" | 2 |
| User alerted to matches found, if any | "Cat" + "That is a cat." | "You have 1 matching word!" |

## Setup and Use

#### Prerequisites
* .NET Core 1.1 SDK or higher
* .NET Core Runtime 1.1 or higher
* [Mono](https://www.mono-project.com/)

#### Download Repo
1. Download required software: .NET Core SDK, .NET Core Runtime, Mono
2. Clone [this repository](https://github.com/LondresRi/WordCounter.Solution): _$ git clone (repo HTTPS)_

#### Open Locally
1. Navigate to the working directory: _$ cd WordCounter.Solution_
2. Use your preferred IDE or editor to edit the project
3. Open the Program.exe file or use _$ mono Program.exe_ to run application

#### Compile Locally
1. Navigate to the project directory: _$ cd WordCounter.Solution/WordCounter_
2. Execute _$ mcs Program.cs Models/Counter.cs_ to compile new Program.exe file

#### Test Locally
1. Navigate to the working directory: _$ cd WordCounter.Solution/WordCounter.Tests_
2. Execute _$ dotnet tests_ to run application tests


## Built With

* Linux Fedora 29
* Atom (IDE)
* C#
* Microsoft SDK
* .NET Core 2.0
* GitBash

## Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| Shawn Lunsford | [LondresRi](https://github.com/LondresRi) |  [lunsford.sk@gmail.com](mailto:lunsford.sk@gmail.com) |

## Support and contact details

If you have any feedback or concerns, please contact me at [lunsford.sk@gmail.com](mailto:lunsford.sk@gmail.com).

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2019 Shawn Lunsford. All Rights Reserved.
```
MIT License

Copyright (c) 2019 [Shawn Lunsford](https://github.com/LondresRi)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)
