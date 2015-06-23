Demo project for hosting Nancy and Mono inside a Docker container
=================================================================

Run
-------------

```
  $ docker build -t github.com/benhall/nancy-demo-hosting-docker .
  $ docker run -d --name nancy-demo -p 8080:8080 github.com/benhall/nancy-demo-hosting-docker
  $ docker port nancy-demo 8080 | xargs curl 
```

If you're using via boot2docker then specify the VM IP as part of the curl command

```
  $ curl $(boot2docker ip):8080
```

