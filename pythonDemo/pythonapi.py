import requests
headers={'content-type':'application/json'}
r=requests.get("http://119.29.0.61:8000/ls",auth=("admin","TvvRvHkyr9b6ls1I"),headers=headers)
print r.text