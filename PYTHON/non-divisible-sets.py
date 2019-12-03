#
# Complete the 'nonDivisibleSubset' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER k
#  2. INTEGER_ARRAY s
#
# def myUpdate(p, q):
#     result={}
#     if !(result.__contains__(p) or result.__contains__(q)):
#         result[]


def nonDivisibleSubset(k, s):
    result=set()
    



    # # inputset=set(s)
    # # print(inputset)
    # # result={} -> this was not working as it gives dictionary a key value pair. incorrectly used data structure
    # l=len(s)
    # # subsetCount=0
    # for i in range(l):
    #     for j in range(i+1,l):
    #         if (s[i] + s[j])%k != 0:
    #             p=[]
    #             p.append(s[i])
    #             p.append(s[j])
    #             result.update(p)
    #             # subsetCount+=1
    #             print (p)

                # for i in p:
                #     if i not in result or result=={}:
                #         result[i]=i
    # finalSubset=set()
    # for i in result.values():
    #     finalSubset.update(i)
    # print(finalSubset)                
    # return len(finalSubset)
    print(result)
    return len(result)

# print(nonDivisibleSubset(3, [1, 7, 2, 4]))
# print(nonDivisibleSubset(4, [19, 10, 12, 24, 25]))
print(nonDivisibleSubset(7, [278, 576, 496 ,727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436]))
