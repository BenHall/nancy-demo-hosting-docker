Demo project for hosting Nancy and Mono inside a Docker container
=================================================================

Run
-------------

```
	$ docker run --name nancy-demo -p 8080 github.com/benhall/nancy-demo-hosting-docker
  $ docker port nancy-demo 8080 | xargs curl
```
  
