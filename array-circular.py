def shiftArray(a, s , direction="Right"):
    l=len(a)
    s%=l#resolved the length of s to come into 0 to len(a)-1
    temp=[]
    for i in range(l):

        if i==0:
            temp.append(a[l-s])
        else:
            temp.append(a[i-s])
        

        # print(temp)
    return temp


array=[2,5,7,0,1,3,7]
shift = 3
print([i for i in range(len(array))])
print(array)
print(shiftArray(array, shift ))