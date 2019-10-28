>**2019/10/24,docker19.03.4, .netcore 3.0,CentOS7.6**   
>摘要：asp.net core 3.0 网站项目容器化部署，使用docker-compose编排Nginx容器、MySQL容器、web容器    
>[博文连接](https://www.cnblogs.com/kasnti/p/11731899.html)   

依赖结构介绍   

整个网站项目取名samplems，一共需要三个容器（按依赖顺序）：   
1.MySQL容器，取名为`samplems.mysql`，来自`mysql`（官方）镜像   
2.web容器，取名为`samplems.web`，来自`samplemsweb`(自己build出来的)镜像   
3.nginx容器，取名为`samplems.nginx`，来自`nginx`(官方)镜像   
使用docker-compose编排三个容器，建立桥接网络（取名`samplems-net`）联系三者   