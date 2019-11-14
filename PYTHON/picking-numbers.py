def pickingNumbers(a):
    # Write your code here
    d={}
    for i in a:
        if d=={} or i not in d.keys():
            d[i]=1
        else:
            temp=d[i]
            d[i]=temp+1
    # print('d =', d)
    largest=0
    
    for i in d.keys():
        if i+1 in d.keys():
            if largest<d[i]+d[i+1]:
                largest=d[i]+d[i+1]
            # print('came in 1st')
        else:
            if largest< d[i]:
                largest=d[i]
    return largest
print('pickingNumbers([1, 2, 2, 3, 1, 2])',pickingNumbers([1, 2, 2, 3, 1, 2]))
print('pickingNumbers([4, 6 ,5, 3, 3, 1])',pickingNumbers([4, 6 ,5, 3, 3, 1]))
print('pickingNumbers([1, 1 ,2, 2, 4, 4, 5, 5, 5])',pickingNumbers([1, 1 ,2, 2, 4, 4, 5, 5, 5]))
