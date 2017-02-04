# mattgaikema.com

Source code for [my website](http://mattgaikema.com/).

---

## Instructions

### Git
When you clone the repository via git,
run
```
git clone --recursive https://github.com/TexAgg/website.git
```
to get all the git submodules.
Also, to update submodules to their latest versions, run
```
git submodule update --recursive --remote
```

### Building
All of the subprojects have custom build commands which are invoked when the site is built for debugging.
Each subproject has a README which should detail specific requirements, 
but most subprojects require Python 2 and NodeJS along with TypeScript, UglifyJS, and Browserify.
Building my [resume](https://github.com/TexAgg/Resume#building) is more complex.

### Running
I developed this on Linux using Mono.
It runs on Windows, but only after I changed the target runtime from 4.5 to 4.0, then to 3.5, then back to 4.5 in Visual Studio.
I have no idea why this worked.

---

## Resources
* [SQLite3](http://stackoverflow.com/a/4385764/5415895)