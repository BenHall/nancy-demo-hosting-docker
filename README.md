Demo project for hosting Nancy and Mono inside a Docker container
=================================================================

Run
-------------

```
  $ docker build -t github.com/benhall/nancy-demo-hosting-docker .
  $ docker run -d --name nancy-demo -p 8080:8080 github.com/benhall/nancy-demo-hosting-docker
  $ docker port nancy-demo 8080 | xargs curl 
```

Boot2Docker
-----------

Due to Boot2Docker being inside a VM there is a conflict between the Nancy self hosting code, the IP being bound to and the hostname. The result of this conflict is the response _&lt;h1&gt;Bad Request (Invalid host)&lt;/h1&gt;_

The correct curl is below as it sets the Host so Nancy/Mono knows how to serve the request:

```
$ curl  -H "Host: 0.0.0.0:8080" $(boot2docker ip):8080
```