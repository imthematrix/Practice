


def shiftArray(a, s , direction="Right"):
    l=len(a)
    print('l', l)
    s%=l#resolved the length of s to come into 0 to len(a)-1
    if s==0:
        s=l
    
    print('s', s)
    temp=[]
    for i in range(l):

        if i==0:
            temp.append(a[l-s])
        else:
            temp.append(a[i-s])
        

        print(temp)
    return temp


# array=[2,5,7,0,1,3,7]
# array = [1, 2, 3]
array= [39356, 87674, 16667, 54260, 43958, 70429, 53682, 6169, 87496, 66190, 90286, 4912, 44792, 65142, 36183, 43856, 77633, 38902, 1407, 88185, 80399, 72940, 97555, 23941, 96271, 49288, 27021, 32032, 75662, 69161, 33581, 15017, 56835, 66599, 69277, 17144, 37027, 39310, 23312, 24523, 5499, 13597, 45786, 66642, 95090, 98320, 26849, 72722, 37221, 28255, 60906]
shift = 51
print([i for i in range(len(array))])
print(array)
print(shiftArray(array, shift ))