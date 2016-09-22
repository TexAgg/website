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
To download my resume and static web projects into the correct directories,
run `download.py`.
This must be done,
otherwise certain files will be missing and you will get 404 errors.

### Running
I developed this on Linux using Mono.
It runs on Windows, but only after I changed the target runtime from 4.5 to 4.0, then to 3.5, then back to 4.5 in Visual Studio.
I have no idea why this worked.