# mattgaikema.com

Rewriting my website (again) using ASP.NET.
This is more for fun and probably will not be hosted.

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
My resume is more complex in that it requires GNU Make to be built, along with PdfLaTeX and Imagemagick.
It also used [poppler-utils](https://poppler.freedesktop.org/), which may not even exist for Windows.

### Running
I developed this on Linux using Mono.
It runs on Windows, but only after I changed the target runtime from 4.5 to 4.0, then to 3.5, then back to 4.5 in Visual Studio.
I have no idea why this worked.
