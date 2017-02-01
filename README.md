# python-hadoop-api

python hadoop api


简介
hadoop作为常用的大数据工具,同时也是云存储常用工具对于普通数据库存储又不一样,特此开发api接口,让大家不仅限于java

操作说明


url：

http://119.29.0.61:8000


api说明：

//列出文件目录

1、get/post请求

http://119.29.0.61:8000/ls

// 通过目录列出文件目录

2、post请求

http://119.29.0.61:8000/dls

参数：dir

{"dir":""}

// 上传文件到hadoop

3、post请求

参数：filepath：原目录，filename：文件名，disnictfilepath：目的文件目录

{"filepath":"","filename":"","disnictfilepath":""}

http：//119.29.0.61：8000/put

//下载文件到本地

4、post请求

参数：sourcefilepath：原目录，filename：文件名，distinctfilepath：目的文件目录

{"sourcefilepath":"","filename":"","distinctfilepath":""}

http://119.29.0.61:8000/get

//创建文件夹

5、post请求

参数：filepath：文件目录

{"filepath":""}

http://119.29.0.61:8000/mkdir

//删除文件夹

6、delete请求

参数：filepath:文件目录

{"filepath":""}

http://119.29.0.61:8000/rmdir

6、delete请求

参数：filepath:文件目录

{"filepath":""}

http://119.29.0.61:8000/rmdir

7、get请求

http://119.29.0.61:8000/report

8、put请求

参数：filepath:文件目录

{"filepath":""}

http://119.29.0.61:8000/cat

9、put请求

参数：filepath:文件目录,status:权限状态
{"filepath":"",status:""}

http://119.29.0.61:8000/chmod

10、put请求

参数：filepath:文件目录,group:组

{"filepath":"","group":""}

http://119.29.0.61:8000/chgrp

11、put请求

参数：filepath:文件目录,owner:用户

{"filepath":"","owner":""}

http://119.29.0.61:8000/chown

12、put请求

参数：filepath:文件目录

{"filepath":""}

http://119.29.0.61:8000/find

13、delete请求

http://119.29.0.61:8000/countip

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
