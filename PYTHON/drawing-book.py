# def flip_page(side, distance,n):
#     page_count=0
#     if side =='front':
        
#     else:
#         for i in range(n, int(distance/2), -2):
#             page_count+=1
#     return page_count
#
# Complete the pageCount function below.
#
def pageCount(n, p):
    #
    # Write your code here.
    #
    counter=0
    front=1
    back=n
    if n%2==0:
        back=n
    else:
        back=n-1
    #while front <= p and p<back:
    #i was using equality here
    #that was wrong because edge case was not getting satisfied
    while front < p and p<back:
        counter+=1
        front +=2
        back-=2
    return counter

print(pageCount(6, 2))
print(pageCount(5, 4))
print(pageCount(5, 1))