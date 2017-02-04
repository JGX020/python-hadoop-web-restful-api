import os

def exportfrommysql(ip,password,database,savefile):
    os.system('mysqldump -h'+ip+' -uroot -p'+password+' -d '+database+'>/root/'+savefile)

def importfrommysql(ip,password,database,savefile):
    os.system('mysql -h'+ip+' -uroot -p'+password+' -d '+database+'</root/'+savefile)