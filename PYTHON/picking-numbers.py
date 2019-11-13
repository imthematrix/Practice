#algorithm

# take global variable c which will keep the count of the arrays formed

#initialize looping to run till the input array is empty
#take a stack s, append / push the first element of input array a if stack s is empty or all element in the stack a differ the element by 1
#do it until the end of input array a
#global variable c=len of the stack s
#clear all the values of elements and its duplicate from input array a which are already in s

#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'pickingNumbers' function below.
#
# The function is expected to return an INTEGER.
# The function accepts INTEGER_ARRAY a as parameter.
#

def findDiffWithAll(s, i):
    if len(s)==0:
        return True
    if len([1 for j in s if math.fabs(i-j)<=1]) ==len(s):
        return True
    return False    
    

def pickingNumbers(a):
    # Write your code here
    largest =0
    s=[]
    while len(a)!=0:
        for i in a:
            if len(s)==0 or findDiffWithAll(s, i):
                s.append(i)
        if largest<len(s):
            largest=len(s)
        for i in a:
            if i in s:
                a.remove(i)
        if len(s)!=0:
            s.clear()

    return largest

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    a = list(map(int, input().rstrip().split()))

    result = pickingNumbers(a)

    fptr.write(str(result) + '\n')

    fptr.close()
