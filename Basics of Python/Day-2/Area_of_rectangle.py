items = [34,2,654,10]
a = []
for i in range(len(items)):
    if i%2==0:
        a.append("even")
    else:
        a.append("odd")

print(a)
