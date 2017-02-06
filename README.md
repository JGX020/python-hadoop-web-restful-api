# python-hadoop-api

python hadoop api


简介

description

hadoop作为常用的大数据工具,同时也是云存储常用工具对于普通数据库存储又不一样,特此开发api接口,让大家不仅限于java

hadoop is a useful big data tool,sometimes is cloud storage tool and other database is not some thing,so I develop these api restful,let

people not just use java

操作说明

operation declear

文件头：application/json

file header:application/json

url：

http://119.29.0.61:8000


api说明：

api declear

//列出文件目录

//list file

1、get/post请求

1、get/post request

http://119.29.0.61:8000/ls

// 通过目录列出文件目录

// though fold list file

2、post请求

post request

http://119.29.0.61:8000/dls

参数：dir

argument: dir

{"dir":""}

// 上传文件到hadoop

// upload file to hadoop

3、post请求

3、post request

参数：filepath：原目录，filename：文件名，disnictfilepath：目的文件目录

argument：filepath：sourcefold，filename：filename，disnictfilepath：distinationfilepath

{"filepath":"","filename":"","disnictfilepath":""}

http：//119.29.0.61：8000/put

//下载文件到本地

//download file to localtion

4、post请求

4、post request

参数：sourcefilepath：原目录，filename：文件名，distinctfilepath：目的文件目录

argument：sourcefilepath：sourcefold，filename：filename，distinctfilepath：distinationpath

{"sourcefilepath":"","filename":"","distinctfilepath":""}

http://119.29.0.61:8000/get

//创建文件夹

//creat fold

5、post请求

5、post request

参数：filepath：文件目录

argument：filepath：filepath

{"filepath":""}

http://119.29.0.61:8000/mkdir

//删除文件夹

//delete fold

6、delete请求

delete request

参数：filepath:文件目录

argument：filepath：fold

{"filepath":""}

http://119.29.0.61:8000/rmdir

6、delete请求

6、delete request

参数：filepath:文件目录

argument：filepath：fold

{"filepath":""}

http://119.29.0.61:8000/rmdir

7、get请求

7、get request

http://119.29.0.61:8000/report

8、put请求

8、put request

参数：filepath:文件目录

argument：filepath：fold

{"filepath":""}

http://119.29.0.61:8000/cat

9、put请求

9、put request

参数：filepath:文件目录,status:权限状态

argument：filepath：fold，status：auth status

{"filepath":"",status:""}

http://119.29.0.61:8000/chmod

10、put请求

10、put request

参数：filepath:文件目录,group:组

argument：filepath：fold，group：group

{"filepath":"","group":""}

http://119.29.0.61:8000/chgrp

11、put请求

11、put request

参数：filepath:文件目录,owner:用户

argument：filepath：fold，owner：user

{"filepath":"","owner":""}

http://119.29.0.61:8000/chown

12、put请求

12、put request

参数：filepath:文件目录

argument：filepath：fold

{"filepath":""}

http://119.29.0.61:8000/find

13、delete请求

13、delete request

http://119.29.0.61:8000/countip

14、post请求

14、post request

http://119.29.0.61:8000/idrsa_pub

15、post请求

15、post request

http://119.29.0.61:8000/idrsa_pub_comeback

16、get请求

16、get request

http://119.29.0.61:8000/idrsa_pub_countstatus

17、put请求

17、put request

参数：program：程序

argument：program：program

{"program":""}

http://119.29.0.61:8000/execute

18、put请求

18、put request

参数：srcfilepath：源文件目录，dstfilepath：目的文件目录

argument：srcfilepath：sourcefilepath，dstfilepath：destinationfilepath

{"srcfilepath":"","dstfilepath":""}

http://119.29.0.61:8000/mv

帐号admin 密码 TvvRvHkyr9b6ls1I

Copyright [蒋光洵] [erick.jiang]

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
