FROM        benhall/docker-mono
COPY        . /src
WORKDIR     /src
RUN         xbuild Nancy.Demo.Hosting.Docker.sln
EXPOSE      8080
ENTRYPOINT  ["mono", "src/bin/Nancy.Demo.Hosting.Docker.exe"]
